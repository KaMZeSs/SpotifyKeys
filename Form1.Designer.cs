namespace SpotifyKeys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Load_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spotifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateDefault_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateSpecified_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseStart_textbox = new System.Windows.Forms.TextBox();
            this.PauseStart_label = new System.Windows.Forms.Label();
            this.PauseStart_button = new System.Windows.Forms.Button();
            this.NextTrack_textbox = new System.Windows.Forms.TextBox();
            this.NextTrack_label = new System.Windows.Forms.Label();
            this.NextTrack_button = new System.Windows.Forms.Button();
            this.PreviousTrack_textbox = new System.Windows.Forms.TextBox();
            this.PreviousTrack_label = new System.Windows.Forms.Label();
            this.PreviousTrack_button = new System.Windows.Forms.Button();
            this.FastForwardTrack_textbox = new System.Windows.Forms.TextBox();
            this.FastForwardTrack_label = new System.Windows.Forms.Label();
            this.FastForwardTrack_button = new System.Windows.Forms.Button();
            this.RewindTrack_textbox = new System.Windows.Forms.TextBox();
            this.RewindTrack_label = new System.Windows.Forms.Label();
            this.RewindTrack_button = new System.Windows.Forms.Button();
            this.Status_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.spotifyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_ToolStripMenuItem,
            this.Load_ToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // Save_ToolStripMenuItem
            // 
            this.Save_ToolStripMenuItem.Name = "Save_ToolStripMenuItem";
            this.Save_ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.Save_ToolStripMenuItem.Text = "Сохранить настройки";
            this.Save_ToolStripMenuItem.Click += new System.EventHandler(this.Save_ToolStripMenuItem_Click);
            // 
            // Load_ToolStripMenuItem
            // 
            this.Load_ToolStripMenuItem.Name = "Load_ToolStripMenuItem";
            this.Load_ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.Load_ToolStripMenuItem.Text = "Загрузить настройки";
            this.Load_ToolStripMenuItem.Click += new System.EventHandler(this.Load_ToolStripMenuItem_Click);
            // 
            // spotifyToolStripMenuItem
            // 
            this.spotifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateDefault_ToolStripMenuItem,
            this.UpdateSpecified_ToolStripMenuItem});
            this.spotifyToolStripMenuItem.Name = "spotifyToolStripMenuItem";
            this.spotifyToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.spotifyToolStripMenuItem.Text = "Spotify";
            // 
            // UpdateDefault_ToolStripMenuItem
            // 
            this.UpdateDefault_ToolStripMenuItem.Name = "UpdateDefault_ToolStripMenuItem";
            this.UpdateDefault_ToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.UpdateDefault_ToolStripMenuItem.Text = "Подключить, используя стандартные значения";
            // 
            // UpdateSpecified_ToolStripMenuItem
            // 
            this.UpdateSpecified_ToolStripMenuItem.Name = "UpdateSpecified_ToolStripMenuItem";
            this.UpdateSpecified_ToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.UpdateSpecified_ToolStripMenuItem.Text = "Подключить, введя название окна";
            // 
            // PauseStart_textbox
            // 
            this.PauseStart_textbox.Location = new System.Drawing.Point(12, 56);
            this.PauseStart_textbox.Name = "PauseStart_textbox";
            this.PauseStart_textbox.ReadOnly = true;
            this.PauseStart_textbox.Size = new System.Drawing.Size(199, 23);
            this.PauseStart_textbox.TabIndex = 1;
            // 
            // PauseStart_label
            // 
            this.PauseStart_label.AutoSize = true;
            this.PauseStart_label.Location = new System.Drawing.Point(12, 38);
            this.PauseStart_label.Name = "PauseStart_label";
            this.PauseStart_label.Size = new System.Drawing.Size(114, 15);
            this.PauseStart_label.TabIndex = 2;
            this.PauseStart_label.Text = "Пауза/Продолжить";
            // 
            // PauseStart_button
            // 
            this.PauseStart_button.Location = new System.Drawing.Point(217, 56);
            this.PauseStart_button.Name = "PauseStart_button";
            this.PauseStart_button.Size = new System.Drawing.Size(75, 23);
            this.PauseStart_button.TabIndex = 3;
            this.PauseStart_button.Text = "Настроить";
            this.PauseStart_button.UseVisualStyleBackColor = true;
            this.PauseStart_button.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // NextTrack_textbox
            // 
            this.NextTrack_textbox.Location = new System.Drawing.Point(12, 112);
            this.NextTrack_textbox.Name = "NextTrack_textbox";
            this.NextTrack_textbox.ReadOnly = true;
            this.NextTrack_textbox.Size = new System.Drawing.Size(199, 23);
            this.NextTrack_textbox.TabIndex = 1;
            // 
            // NextTrack_label
            // 
            this.NextTrack_label.AutoSize = true;
            this.NextTrack_label.Location = new System.Drawing.Point(12, 94);
            this.NextTrack_label.Name = "NextTrack_label";
            this.NextTrack_label.Size = new System.Drawing.Size(102, 15);
            this.NextTrack_label.TabIndex = 2;
            this.NextTrack_label.Text = "Следующий трек";
            // 
            // NextTrack_button
            // 
            this.NextTrack_button.Location = new System.Drawing.Point(217, 112);
            this.NextTrack_button.Name = "NextTrack_button";
            this.NextTrack_button.Size = new System.Drawing.Size(75, 23);
            this.NextTrack_button.TabIndex = 3;
            this.NextTrack_button.Text = "Настроить";
            this.NextTrack_button.UseVisualStyleBackColor = true;
            this.NextTrack_button.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // PreviousTrack_textbox
            // 
            this.PreviousTrack_textbox.Location = new System.Drawing.Point(311, 112);
            this.PreviousTrack_textbox.Name = "PreviousTrack_textbox";
            this.PreviousTrack_textbox.ReadOnly = true;
            this.PreviousTrack_textbox.Size = new System.Drawing.Size(199, 23);
            this.PreviousTrack_textbox.TabIndex = 1;
            // 
            // PreviousTrack_label
            // 
            this.PreviousTrack_label.AutoSize = true;
            this.PreviousTrack_label.Location = new System.Drawing.Point(311, 94);
            this.PreviousTrack_label.Name = "PreviousTrack_label";
            this.PreviousTrack_label.Size = new System.Drawing.Size(108, 15);
            this.PreviousTrack_label.TabIndex = 2;
            this.PreviousTrack_label.Text = "Предыдущий трек";
            // 
            // PreviousTrack_button
            // 
            this.PreviousTrack_button.Location = new System.Drawing.Point(516, 112);
            this.PreviousTrack_button.Name = "PreviousTrack_button";
            this.PreviousTrack_button.Size = new System.Drawing.Size(75, 23);
            this.PreviousTrack_button.TabIndex = 3;
            this.PreviousTrack_button.Text = "Настроить";
            this.PreviousTrack_button.UseVisualStyleBackColor = true;
            this.PreviousTrack_button.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // FastForwardTrack_textbox
            // 
            this.FastForwardTrack_textbox.Location = new System.Drawing.Point(12, 172);
            this.FastForwardTrack_textbox.Name = "FastForwardTrack_textbox";
            this.FastForwardTrack_textbox.ReadOnly = true;
            this.FastForwardTrack_textbox.Size = new System.Drawing.Size(199, 23);
            this.FastForwardTrack_textbox.TabIndex = 1;
            // 
            // FastForwardTrack_label
            // 
            this.FastForwardTrack_label.AutoSize = true;
            this.FastForwardTrack_label.Location = new System.Drawing.Point(12, 154);
            this.FastForwardTrack_label.Name = "FastForwardTrack_label";
            this.FastForwardTrack_label.Size = new System.Drawing.Size(113, 15);
            this.FastForwardTrack_label.TabIndex = 2;
            this.FastForwardTrack_label.Text = "Пролистать вперед";
            // 
            // FastForwardTrack_button
            // 
            this.FastForwardTrack_button.Location = new System.Drawing.Point(217, 172);
            this.FastForwardTrack_button.Name = "FastForwardTrack_button";
            this.FastForwardTrack_button.Size = new System.Drawing.Size(75, 23);
            this.FastForwardTrack_button.TabIndex = 3;
            this.FastForwardTrack_button.Text = "Настроить";
            this.FastForwardTrack_button.UseVisualStyleBackColor = true;
            this.FastForwardTrack_button.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // RewindTrack_textbox
            // 
            this.RewindTrack_textbox.Location = new System.Drawing.Point(311, 172);
            this.RewindTrack_textbox.Name = "RewindTrack_textbox";
            this.RewindTrack_textbox.ReadOnly = true;
            this.RewindTrack_textbox.Size = new System.Drawing.Size(199, 23);
            this.RewindTrack_textbox.TabIndex = 1;
            // 
            // RewindTrack_label
            // 
            this.RewindTrack_label.AutoSize = true;
            this.RewindTrack_label.Location = new System.Drawing.Point(311, 154);
            this.RewindTrack_label.Name = "RewindTrack_label";
            this.RewindTrack_label.Size = new System.Drawing.Size(105, 15);
            this.RewindTrack_label.TabIndex = 2;
            this.RewindTrack_label.Text = "Пролистать назад";
            // 
            // RewindTrack_button
            // 
            this.RewindTrack_button.Location = new System.Drawing.Point(516, 172);
            this.RewindTrack_button.Name = "RewindTrack_button";
            this.RewindTrack_button.Size = new System.Drawing.Size(75, 23);
            this.RewindTrack_button.TabIndex = 3;
            this.RewindTrack_button.Text = "Настроить";
            this.RewindTrack_button.UseVisualStyleBackColor = true;
            this.RewindTrack_button.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Location = new System.Drawing.Point(311, 56);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(81, 15);
            this.Status_label.TabIndex = 4;
            this.Status_label.Text = "Status: Closed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 207);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.PreviousTrack_button);
            this.Controls.Add(this.RewindTrack_button);
            this.Controls.Add(this.FastForwardTrack_button);
            this.Controls.Add(this.NextTrack_button);
            this.Controls.Add(this.PreviousTrack_label);
            this.Controls.Add(this.PauseStart_button);
            this.Controls.Add(this.RewindTrack_label);
            this.Controls.Add(this.FastForwardTrack_label);
            this.Controls.Add(this.NextTrack_label);
            this.Controls.Add(this.PreviousTrack_textbox);
            this.Controls.Add(this.RewindTrack_textbox);
            this.Controls.Add(this.PauseStart_label);
            this.Controls.Add(this.FastForwardTrack_textbox);
            this.Controls.Add(this.NextTrack_textbox);
            this.Controls.Add(this.PauseStart_textbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem Save_ToolStripMenuItem;
        private ToolStripMenuItem Load_ToolStripMenuItem;
        private ToolStripMenuItem spotifyToolStripMenuItem;
        private ToolStripMenuItem UpdateDefault_ToolStripMenuItem;
        private ToolStripMenuItem UpdateSpecified_ToolStripMenuItem;
        private TextBox PauseStart_textbox;
        private Label PauseStart_label;
        private Button PauseStart_button;
        private TextBox NextTrack_textbox;
        private Label NextTrack_label;
        private Button NextTrack_button;
        private TextBox PreviousTrack_textbox;
        private Label PreviousTrack_label;
        private Button PreviousTrack_button;
        private TextBox FastForwardTrack_textbox;
        private Label FastForwardTrack_label;
        private Button FastForwardTrack_button;
        private TextBox RewindTrack_textbox;
        private Label RewindTrack_label;
        private Button RewindTrack_button;
        private Label Status_label;
    }
}