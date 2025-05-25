using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace FootballerDirectory2
{
    public partial class Form1 : Form
    {
        private List<Player> players = new List<Player>();
        private List<Player> originalPlayers = new List<Player>();

        private bool updatingComboBoxes = false; // Флаг для предотвращения рекурсии

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            comboBoxClubs.DropDownStyle = ComboBoxStyle.DropDownList; // DropDownList для comboBoxClubs
            comboBoxClubInfo.DropDownStyle = ComboBoxStyle.DropDownList; // DropDownList для comboBoxClubInfo
            LoadFootballers();
        }

        public class Club
        {
            public string Name { get; set; }
            public int Goals { get; set; }
        }

        public class Player
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public string CurrentClub { get; set; }
            public List<Club> Clubs { get; set; }
            public string ImagePath { get; set; }
            public int TotalGoals { get; set; }
            public string Nationality { get; set; }
            public string Description { get; set; } // Для характеристики
        }

        public List<Player> LoadPlayersFromCsv(string filePath)
        {
            List<Player> players = new List<Player>();
            string[] lines = File.ReadAllLines(filePath);

            for (int lineIndex = 0; lineIndex < lines.Length; lineIndex++)
            {
                string line = lines[lineIndex].Trim();
                if (string.IsNullOrWhiteSpace(line))
                {
                    Console.WriteLine($"Пропущена пустая строка {lineIndex + 1}");
                    continue;
                }

                string[] values = line.Split(';'); 
                if (values.Length < 7)
                {
                    Console.WriteLine($"Ошибка: Слишком мало полей в строке {lineIndex + 1}: {line}");
                    continue;
                }

                try
                {
                    Player player = new Player
                    {
                        Name = values[0].Trim(),
                        Position = values[1].Trim(),
                        CurrentClub = values[2].Trim(),
                        ImagePath = values[3].Trim(),
                        Clubs = new List<Club>(),
                        Nationality = values[values.Length - 2].Trim(),
                        Description = values[values.Length - 1].Trim()
                    };

                    // Загрузка информации о клубах (начинаются с индекса 4 и до Nationality)
                    int totalGoals = 0;
                    for (int i = 4; i < values.Length - 2; i += 2) // До предпоследнего поля (Nationality)
                    {
                        if (i + 1 < values.Length - 2)
                        {
                            string clubName = values[i].Trim();
                            string goalsStr = values[i + 1].Trim();

                            // Проверяем, является ли goalsStr числом
                            if (int.TryParse(goalsStr, out int goals))
                            {
                                Club club = new Club
                                {
                                    Name = clubName,
                                    Goals = goals
                                };
                                player.Clubs.Add(club);
                                totalGoals += club.Goals;
                            }
                            else
                            {
                                Console.WriteLine($"Ошибка: Неверный формат голов ({goalsStr}) в строке {lineIndex + 1}: {line}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Ошибка: Недостаточно данных для клуба в строке {lineIndex + 1}: {line}");
                        }
                    }
                    player.TotalGoals = totalGoals;
                    players.Add(player);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка обработки строки {lineIndex + 1}: {line}. Детали: {ex.Message}");
                }
            }
            return players;
        }

        private void LoadFootballers()
        {
            string filePath = "footballers.csv";

            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Файл {filePath} не найден. Убедитесь, что он находится в папке с исполняемым файлом.");
                return;
            }

            try
            {
                players = LoadPlayersFromCsv(filePath);
                originalPlayers = players.ToList(); // Сохраняем копию оригинального списка
                UpdateListBox(players);  // Обновляем ListBox с помощью метода UpdateListBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void UpdateListBox(List<Player> playerList)
        {
            listBoxFootballers.DataSource = null; // Сначала очищаем DataSource
            listBoxFootballers.DataSource = playerList;
            listBoxFootballers.DisplayMember = "Name";
        }

        private void ListBoxFootballers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatingComboBoxes) return; // Предотвращаем рекурсию

            try
            {
                updatingComboBoxes = true;

                if (listBoxFootballers.SelectedItem is Player selectedPlayer)
                {
                    textBoxName.Text = selectedPlayer.Name;
                    textBoxPosition.Text = selectedPlayer.Position;
                    comboBoxClubs.Text = selectedPlayer.CurrentClub;

                    try
                    {
                        if (!string.IsNullOrEmpty(selectedPlayer.ImagePath) && File.Exists(selectedPlayer.ImagePath))
                        {
                            using (Image image = Image.FromFile(selectedPlayer.ImagePath))
                            {
                                pictureBoxFootballer.Image = new Bitmap(image);
                            }
                        }
                        else
                        {
                            pictureBoxFootballer.Image = null;
                        }
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show($"Файл изображения не найден: {ex.Message}");
                        pictureBoxFootballer.Image = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                        pictureBoxFootballer.Image = null;
                    }

                    // Заполняем comboBoxClubs списком клубов
                    comboBoxClubs.Items.Clear();
                    foreach (Club club in selectedPlayer.Clubs)
                    {
                        comboBoxClubs.Items.Add(club.Name);
                    }

                    // Если есть клубы, выбираем первый
                    if (selectedPlayer.Clubs.Count > 0)
                    {
                        comboBoxClubs.SelectedIndex = 0;
                    }
                    else
                    {
                        comboBoxClubs.SelectedIndex = -1; //Чтобы comboBoxClubInfo очистился, когда нет клубов
                    }

                    // Обновляем информацию о клубе в comboBoxClubInfo
                    UpdateClubInfoComboBox();

                    // Отображаем общее количество голов в textBoxTotalGoals
                    textBoxTotalGoals.Text = selectedPlayer.TotalGoals.ToString();

                    // Отображаем национальность и характеристику
                    textBoxNationality.Text = selectedPlayer.Nationality;
                    textBoxDescription.Text = selectedPlayer.Description;
                }
                else
                {
                    // Очищаем поля, если не выбран игрок
                    textBoxName.Text = "";
                    textBoxPosition.Text = "";
                    comboBoxClubs.Text = "";
                    comboBoxClubs.Items.Clear();
                    comboBoxClubInfo.Items.Clear();
                    pictureBoxFootballer.Image = null;
                    textBoxTotalGoals.Text = "";
                    textBoxNationality.Text = "";
                    textBoxDescription.Text = "";
                }
            }
            finally
            {
                updatingComboBoxes = false; // Снимаем флаг в любом случае
            }
        }

        private void UpdateClubInfoComboBox()
        {
            if (updatingComboBoxes) return; // Предотвращаем рекурсию

            try
            {
                updatingComboBoxes = true;
                comboBoxClubInfo.Items.Clear();

                if (listBoxFootballers.SelectedItem is Player selectedPlayer &&
                    selectedPlayer.Clubs.Count > 0 &&
                    comboBoxClubs.SelectedIndex != -1)
                {
                    string selectedClubName = comboBoxClubs.SelectedItem.ToString();
                    Club selectedClub = selectedPlayer.Clubs.FirstOrDefault(c => c.Name == selectedClubName);

                    if (selectedClub != null)
                    {
                        comboBoxClubInfo.Items.Add(selectedClub.Goals.ToString());
                        if (comboBoxClubInfo.Items.Count > 0)
                        {
                            comboBoxClubInfo.SelectedIndex = 0;
                            comboBoxClubInfo.Text = comboBoxClubInfo.Items[0].ToString();
                        }
                        else
                        {
                            comboBoxClubInfo.Text = "";
                        }
                    }
                }
            }
            finally
            {
                updatingComboBoxes = false; // Снимаем флаг в любом случае
            }
        }

        private void ComboBoxClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatingComboBoxes) return; // Предотвращаем рекурсию
            UpdateClubInfoComboBox();
        } 
        private void ButtonOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower();
            List<Player> filteredPlayers = originalPlayers
                .Where(p => p.Name.ToLower().Contains(searchText))
                .ToList();
            UpdateListBox(filteredPlayers);
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            List<Player> sortedPlayers = players.OrderBy(p => p.Name).ToList();
            UpdateListBox(sortedPlayers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void TextBoxClub_TextChanged(object sender, EventArgs e)
        {
        }
        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void TextBoxPosition_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxNationality_TextChanged(object sender, EventArgs e)
        {
        }

        private void LabelBirthDate_Click(object sender, EventArgs e)
        {
        }

        private void PickerBirthDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void LabelNationality_Click(object sender, EventArgs e)
        {
        }

        private void PickerBirthDate_TextChanged(object sender, EventArgs e)
        {
        }

        private void LabelDescription_Click(object sender, EventArgs e)
        {

        }

        private void LabelName_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}