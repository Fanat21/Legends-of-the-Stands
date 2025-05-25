using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq; // Добавлено для LINQ

namespace FootballerDirectory2
{
    public partial class Form2 : Form
    {
        private readonly List<FootballHistoryEvent> historyEvents = new List<FootballHistoryEvent>(); // Добавлено readonly
        private static readonly List<KeyValuePair<string, FootballHistoryEvent>> list = new List<KeyValuePair<string, FootballHistoryEvent>>();
        private readonly List<KeyValuePair<string, FootballHistoryEvent>> originalDisplayItems = list;
        private Form1 form1Instance = null;
        private bool updatingUI = false;
        private bool sortAscending = true;

        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadFootballHistory(GetHistoryEvents());
        }

        public class FootballHistoryEvent
        {
            public string Title { get; set; }
            public int Year { get; set; }
            public string ImagePath { get; set; }
            public string Description { get; set; }
        }

        private List<FootballHistoryEvent> LoadFootballHistoryFromCsv(string filePath)
        {
            List<FootballHistoryEvent> events = new List<FootballHistoryEvent>();
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
                if (values.Length < 4)
                {
                    Console.WriteLine($"Ошибка: Слишком мало полей в строке {lineIndex + 1}: {line}");
                    continue;
                }

                try
                {
                    FootballHistoryEvent historyEvent = new FootballHistoryEvent
                    {
                        Title = values[0].Trim(),
                        Year = int.TryParse(values[1].Trim(), out int year) ? year : 0,
                        ImagePath = values[2].Trim(),
                        Description = values[3].Trim()
                    };
                    events.Add(historyEvent);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка обработки строки {lineIndex + 1}: {line}. Детали: {ex.Message}");
                }
            }
            return events;
        }

        private List<FootballHistoryEvent> GetHistoryEvents()
        {
            return historyEvents;
        }

        private void LoadFootballHistory(List<FootballHistoryEvent> historyEvents)
        {
            if (historyEvents is null)
            {
                throw new ArgumentNullException(nameof(historyEvents));
            }

            string filePath = "football_history.csv";

            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Файл {filePath} не найден. Убедитесь, что он находится в папке с исполняемым файлом.");
                return;
            }

            try
            {
                historyEvents = LoadFootballHistoryFromCsv(filePath);
                Console.WriteLine($"Загружено {historyEvents.Count} событий из файла {filePath}");

                originalDisplayItems.Clear();
                foreach (var evt in historyEvents)
                {
                    string displayText = $"{evt.Title} ({evt.Year})";
                    originalDisplayItems.Add(new KeyValuePair<string, FootballHistoryEvent>(displayText, evt));
                }

                UpdateListBox(originalDisplayItems);

                if (historyEvents.Count > 0)
                {
                    listBoxHistoryEvents.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Список событий пуст. Проверьте содержимое файла football_history.csv.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }
        private void UpdateListBox(List<KeyValuePair<string, FootballHistoryEvent>> eventList)
        {
            listBoxHistoryEvents.DataSource = null;
            listBoxHistoryEvents.Items.Clear();

            foreach (var evt in eventList)
            {
                listBoxHistoryEvents.Items.Add(evt);
            }

            listBoxHistoryEvents.DisplayMember = "Key";
            listBoxHistoryEvents.ValueMember = "Value";
        }

        private void ListBoxHistoryEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("ListBoxHistoryEvents_SelectedIndexChanged вызван");
            if (updatingUI) return;

            try
            {
                updatingUI = true;

                if (listBoxHistoryEvents.SelectedItem is KeyValuePair<string, FootballHistoryEvent> selectedPair)
                {
                    FootballHistoryEvent selectedEvent = selectedPair.Value;
                    Console.WriteLine($"Выбрано событие: {selectedEvent.Title}, описание: {selectedEvent.Description}");
                    textBoxDescription.Text = selectedEvent.Description;

                    try
                    {
                        if (!string.IsNullOrEmpty(selectedEvent.ImagePath) && File.Exists(selectedEvent.ImagePath))
                        {
                            using (Image image = Image.FromFile(selectedEvent.ImagePath))
                            {
                                pictureBoxHistory.Image = new Bitmap(image);
                            }
                        }
                        else
                        {
                            pictureBoxHistory.Image = null;
                        }
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show($"Файл изображения не найден: {ex.Message}");
                        pictureBoxHistory.Image = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                        pictureBoxHistory.Image = null;
                    }
                }
                else
                {
                    textBoxDescription.Text = "";
                    pictureBoxHistory.Image = null;
                }
            }
            finally
            {
                updatingUI = false;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.ToLower();
            List<KeyValuePair<string, FootballHistoryEvent>> filteredEvents = new List<KeyValuePair<string, FootballHistoryEvent>>();

            if (string.IsNullOrEmpty(searchTerm))
            {
                filteredEvents = new List<KeyValuePair<string, FootballHistoryEvent>>(originalDisplayItems);
            }
            else
            {
                foreach (var evt in originalDisplayItems)
                {
                    if (evt.Key.ToLower().Contains(searchTerm))
                    {
                        filteredEvents.Add(evt);
                    }
                }
            }

            UpdateListBox(filteredEvents);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<string, FootballHistoryEvent>> currentItems = new List<KeyValuePair<string, FootballHistoryEvent>>(listBoxHistoryEvents.Items.Cast<KeyValuePair<string, FootballHistoryEvent>>());

            if (sortAscending)
            {
                currentItems.Sort((a, b) => a.Value.Year.CompareTo(b.Value.Year));
            }
            else
            {
                currentItems.Sort((a, b) => b.Value.Year.CompareTo(a.Value.Year));
            }

            UpdateListBox(currentItems);

            sortAscending = !sortAscending;
            sortButton.Text = sortAscending ? "Сортировать ↑" : "Сортировать ↓";
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonOpenForm1_Click(object sender, EventArgs e)
        {
            if (form1Instance == null || form1Instance.IsDisposed)
            {
                form1Instance = new Form1();
            }
            form1Instance.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}