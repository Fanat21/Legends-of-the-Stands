namespace FootballerDirectory2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxFootballers = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelClub = new System.Windows.Forms.Label();
            this.labelGoals = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.pictureBoxFootballer = new System.Windows.Forms.PictureBox();
            this.buttonOpenForm2 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.comboBoxClubs = new System.Windows.Forms.ComboBox();
            this.comboBoxClubInfo = new System.Windows.Forms.ComboBox();
            this.textBoxTotalGoals = new System.Windows.Forms.TextBox();
            this.labelGoalsOn = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxNationality = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxlegendsofthestands = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFootballer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFootballers
            // 
            this.listBoxFootballers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFootballers.BackColor = System.Drawing.Color.DarkGreen;
            this.listBoxFootballers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.listBoxFootballers.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxFootballers.FormattingEnabled = true;
            this.listBoxFootballers.ItemHeight = 25;
            this.listBoxFootballers.Location = new System.Drawing.Point(12, 51);
            this.listBoxFootballers.Name = "listBoxFootballers";
            this.listBoxFootballers.Size = new System.Drawing.Size(381, 529);
            this.listBoxFootballers.TabIndex = 0;
            this.listBoxFootballers.SelectedIndexChanged += new System.EventHandler(this.ListBoxFootballers_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.SystemColors.Info;
            this.labelName.Location = new System.Drawing.Point(114, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя:";
            this.labelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelPosition.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPosition.ForeColor = System.Drawing.SystemColors.Info;
            this.labelPosition.Location = new System.Drawing.Point(73, 44);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(100, 25);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Позиция:";
            // 
            // labelClub
            // 
            this.labelClub.AutoSize = true;
            this.labelClub.BackColor = System.Drawing.Color.Transparent;
            this.labelClub.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelClub.ForeColor = System.Drawing.SystemColors.Info;
            this.labelClub.Location = new System.Drawing.Point(109, 80);
            this.labelClub.Name = "labelClub";
            this.labelClub.Size = new System.Drawing.Size(63, 25);
            this.labelClub.TabIndex = 3;
            this.labelClub.Text = "Клуб:";
            // 
            // labelGoals
            // 
            this.labelGoals.AutoSize = true;
            this.labelGoals.BackColor = System.Drawing.Color.Transparent;
            this.labelGoals.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelGoals.ForeColor = System.Drawing.SystemColors.Info;
            this.labelGoals.Location = new System.Drawing.Point(37, 111);
            this.labelGoals.Name = "labelGoals";
            this.labelGoals.Size = new System.Drawing.Size(136, 25);
            this.labelGoals.TabIndex = 4;
            this.labelGoals.Text = "Голы за клуб:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxName.Location = new System.Drawing.Point(178, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(198, 29);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPosition.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPosition.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPosition.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPosition.Location = new System.Drawing.Point(178, 40);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.ReadOnly = true;
            this.textBoxPosition.Size = new System.Drawing.Size(198, 29);
            this.textBoxPosition.TabIndex = 6;
            this.textBoxPosition.TextChanged += new System.EventHandler(this.TextBoxPosition_TextChanged);
            // 
            // pictureBoxFootballer
            // 
            this.pictureBoxFootballer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFootballer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFootballer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxFootballer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFootballer.Location = new System.Drawing.Point(787, 8);
            this.pictureBoxFootballer.Name = "pictureBoxFootballer";
            this.pictureBoxFootballer.Size = new System.Drawing.Size(399, 330);
            this.pictureBoxFootballer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFootballer.TabIndex = 9;
            this.pictureBoxFootballer.TabStop = false;
            // 
            // buttonOpenForm2
            // 
            this.buttonOpenForm2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenForm2.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonOpenForm2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonOpenForm2.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonOpenForm2.Location = new System.Drawing.Point(1192, 8);
            this.buttonOpenForm2.Name = "buttonOpenForm2";
            this.buttonOpenForm2.Size = new System.Drawing.Size(82, 348);
            this.buttonOpenForm2.TabIndex = 10;
            this.buttonOpenForm2.Text = " История";
            this.buttonOpenForm2.UseVisualStyleBackColor = false;
            this.buttonOpenForm2.Click += new System.EventHandler(this.ButtonOpenForm2_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(284, 33);
            this.textBoxSearch.TabIndex = 11;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonSort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonSort.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonSort.Location = new System.Drawing.Point(302, 12);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(91, 33);
            this.buttonSort.TabIndex = 12;
            this.buttonSort.Text = "Сорт А-Я";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // comboBoxClubs
            // 
            this.comboBoxClubs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClubs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxClubs.FormattingEnabled = true;
            this.comboBoxClubs.Location = new System.Drawing.Point(178, 75);
            this.comboBoxClubs.Name = "comboBoxClubs";
            this.comboBoxClubs.Size = new System.Drawing.Size(202, 30);
            this.comboBoxClubs.TabIndex = 13;
            this.comboBoxClubs.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClubs_SelectedIndexChanged);
            // 
            // comboBoxClubInfo
            // 
            this.comboBoxClubInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClubInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxClubInfo.FormattingEnabled = true;
            this.comboBoxClubInfo.Location = new System.Drawing.Point(178, 111);
            this.comboBoxClubInfo.Name = "comboBoxClubInfo";
            this.comboBoxClubInfo.Size = new System.Drawing.Size(202, 30);
            this.comboBoxClubInfo.TabIndex = 14;
            this.comboBoxClubInfo.SelectedIndexChanged += new System.EventHandler(this.ListBoxFootballers_SelectedIndexChanged);
            // 
            // textBoxTotalGoals
            // 
            this.textBoxTotalGoals.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTotalGoals.Location = new System.Drawing.Point(178, 147);
            this.textBoxTotalGoals.Name = "textBoxTotalGoals";
            this.textBoxTotalGoals.Size = new System.Drawing.Size(202, 29);
            this.textBoxTotalGoals.TabIndex = 15;
            // 
            // labelGoalsOn
            // 
            this.labelGoalsOn.AutoSize = true;
            this.labelGoalsOn.BackColor = System.Drawing.Color.Transparent;
            this.labelGoalsOn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelGoalsOn.ForeColor = System.Drawing.SystemColors.Info;
            this.labelGoalsOn.Location = new System.Drawing.Point(74, 147);
            this.labelGoalsOn.Name = "labelGoalsOn";
            this.labelGoalsOn.Size = new System.Drawing.Size(99, 25);
            this.labelGoalsOn.TabIndex = 16;
            this.labelGoalsOn.Text = "Все голы:";
            this.labelGoalsOn.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.BackColor = System.Drawing.Color.Transparent;
            this.labelNationality.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelNationality.ForeColor = System.Drawing.SystemColors.Info;
            this.labelNationality.Location = new System.Drawing.Point(90, 182);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(82, 25);
            this.labelNationality.TabIndex = 18;
            this.labelNationality.Text = "Страна:";
            this.labelNationality.Click += new System.EventHandler(this.LabelNationality_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDescription.ForeColor = System.Drawing.SystemColors.Info;
            this.labelDescription.Location = new System.Drawing.Point(7, 243);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(145, 25);
            this.labelDescription.TabIndex = 19;
            this.labelDescription.Text = "О футболисте:";
            this.labelDescription.Click += new System.EventHandler(this.LabelDescription_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxDescription.Location = new System.Drawing.Point(403, 387);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(372, 211);
            this.textBoxDescription.TabIndex = 20;
            // 
            // textBoxNationality
            // 
            this.textBoxNationality.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxNationality.Location = new System.Drawing.Point(178, 182);
            this.textBoxNationality.Name = "textBoxNationality";
            this.textBoxNationality.Size = new System.Drawing.Size(202, 29);
            this.textBoxNationality.TabIndex = 22;
            this.textBoxNationality.TextChanged += new System.EventHandler(this.TextBoxNationality_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxNationality);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelGoalsOn);
            this.panel1.Controls.Add(this.comboBoxClubs);
            this.panel1.Controls.Add(this.comboBoxClubInfo);
            this.panel1.Controls.Add(this.textBoxTotalGoals);
            this.panel1.Controls.Add(this.labelGoals);
            this.panel1.Controls.Add(this.labelClub);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.textBoxPosition);
            this.panel1.Controls.Add(this.labelNationality);
            this.panel1.Controls.Add(this.labelPosition);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Location = new System.Drawing.Point(399, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 489);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBoxlegendsofthestands);
            this.panel2.Location = new System.Drawing.Point(399, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 100);
            this.panel2.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxlegendsofthestands
            // 
            this.textBoxlegendsofthestands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxlegendsofthestands.BackColor = System.Drawing.Color.DarkGreen;
            this.textBoxlegendsofthestands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxlegendsofthestands.Font = new System.Drawing.Font("Segoe UI", 18.25F, System.Drawing.FontStyle.Bold);
            this.textBoxlegendsofthestands.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxlegendsofthestands.Location = new System.Drawing.Point(114, 30);
            this.textBoxlegendsofthestands.Name = "textBoxlegendsofthestands";
            this.textBoxlegendsofthestands.Size = new System.Drawing.Size(260, 33);
            this.textBoxlegendsofthestands.TabIndex = 0;
            this.textBoxlegendsofthestands.Text = "Legends of the Stands";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.DarkGreen;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.SystemColors.Info;
            this.exitButton.Location = new System.Drawing.Point(1192, 362);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 306);
            this.exitButton.TabIndex = 25;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1288, 680);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.listBoxFootballers);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonOpenForm2);
            this.Controls.Add(this.pictureBoxFootballer);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Legends of the Stands";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFootballer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFootballers;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelClub;
        private System.Windows.Forms.Label labelGoals;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.PictureBox pictureBoxFootballer;
        private System.Windows.Forms.Button buttonOpenForm2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox comboBoxClubs;
        private System.Windows.Forms.ComboBox comboBoxClubInfo;
        private System.Windows.Forms.TextBox textBoxTotalGoals;
        private System.Windows.Forms.Label labelGoalsOn;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxNationality;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxlegendsofthestands;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
    }
}

