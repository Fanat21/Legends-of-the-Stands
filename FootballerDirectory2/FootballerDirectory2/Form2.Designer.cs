using System.Windows.Forms;

namespace FootballerDirectory2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonOpenForm1 = new System.Windows.Forms.Button();
            this.listBoxHistoryEvents = new System.Windows.Forms.ListBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.pictureBoxHistory = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenForm1
            // 
            this.buttonOpenForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenForm1.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonOpenForm1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonOpenForm1.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonOpenForm1.Location = new System.Drawing.Point(1208, 12);
            this.buttonOpenForm1.Name = "buttonOpenForm1";
            this.buttonOpenForm1.Size = new System.Drawing.Size(82, 348);
            this.buttonOpenForm1.TabIndex = 0;
            this.buttonOpenForm1.Text = "Футболисты";
            this.buttonOpenForm1.UseVisualStyleBackColor = false;
            this.buttonOpenForm1.Click += new System.EventHandler(this.ButtonOpenForm1_Click);
            // 
            // listBoxHistoryEvents
            // 
            this.listBoxHistoryEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxHistoryEvents.BackColor = System.Drawing.Color.DarkGreen;
            this.listBoxHistoryEvents.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.listBoxHistoryEvents.ForeColor = System.Drawing.SystemColors.Info;
            this.listBoxHistoryEvents.FormattingEnabled = true;
            this.listBoxHistoryEvents.ItemHeight = 25;
            this.listBoxHistoryEvents.Location = new System.Drawing.Point(12, 51);
            this.listBoxHistoryEvents.Name = "listBoxHistoryEvents";
            this.listBoxHistoryEvents.Size = new System.Drawing.Size(381, 679);
            this.listBoxHistoryEvents.TabIndex = 1;
            this.listBoxHistoryEvents.SelectedIndexChanged += new System.EventHandler(this.ListBoxHistoryEvents_SelectedIndexChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxDescription.Location = new System.Drawing.Point(399, 663);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(803, 20);
            this.textBoxDescription.TabIndex = 2;
            // 
            // pictureBoxHistory
            // 
            this.pictureBoxHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHistory.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxHistory.Location = new System.Drawing.Point(399, 12);
            this.pictureBoxHistory.Name = "pictureBoxHistory";
            this.pictureBoxHistory.Size = new System.Drawing.Size(803, 645);
            this.pictureBoxHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHistory.TabIndex = 3;
            this.pictureBoxHistory.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(277, 33);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // sortButton
            // 
            this.sortButton.BackColor = System.Drawing.Color.DarkGreen;
            this.sortButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.sortButton.ForeColor = System.Drawing.SystemColors.Info;
            this.sortButton.Location = new System.Drawing.Point(295, 12);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(98, 33);
            this.sortButton.TabIndex = 1;
            this.sortButton.Text = "Сортировать ↑";
            this.sortButton.UseVisualStyleBackColor = false;
            this.sortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.DarkGreen;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.SystemColors.Info;
            this.exitButton.Location = new System.Drawing.Point(1208, 325);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 358);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::FootballerDirectory2.Properties.Resources.Снимок_экрана_2025_05_13_231233;
            this.ClientSize = new System.Drawing.Size(1302, 778);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBoxHistory);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.listBoxHistoryEvents);
            this.Controls.Add(this.buttonOpenForm1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Legends of the Stands - История футбола";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button buttonOpenForm1;
        private System.Windows.Forms.ListBox listBoxHistoryEvents;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.PictureBox pictureBoxHistory;
    }
}