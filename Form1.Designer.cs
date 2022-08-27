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
            this.WorkState_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseStart_textbox = new System.Windows.Forms.TextBox();
            this.PauseStart_label = new System.Windows.Forms.Label();
            this.PauseStart_button = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            // 
            // Load_ToolStripMenuItem
            // 
            this.Load_ToolStripMenuItem.Name = "Load_ToolStripMenuItem";
            this.Load_ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.Load_ToolStripMenuItem.Text = "Загрузить настройки";
            // 
            // spotifyToolStripMenuItem
            // 
            this.spotifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateDefault_ToolStripMenuItem,
            this.UpdateSpecified_ToolStripMenuItem,
            this.WorkState_ToolStripMenuItem});
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
            // WorkState_ToolStripMenuItem
            // 
            this.WorkState_ToolStripMenuItem.Name = "WorkState_ToolStripMenuItem";
            this.WorkState_ToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.WorkState_ToolStripMenuItem.Text = "Прога работает";
            this.WorkState_ToolStripMenuItem.Click += new System.EventHandler(this.WorkState_ToolStripMenuItem_Click);
            // 
            // PauseStart_textbox
            // 
            this.PauseStart_textbox.Location = new System.Drawing.Point(12, 56);
            this.PauseStart_textbox.Name = "PauseStart_textbox";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PauseStart_button);
            this.Controls.Add(this.PauseStart_label);
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
        private ToolStripMenuItem WorkState_ToolStripMenuItem;
    }
}