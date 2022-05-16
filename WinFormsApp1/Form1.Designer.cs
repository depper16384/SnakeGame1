namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_Game = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label_score = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_play = new System.Windows.Forms.Button();
            this.button_theme = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox_Snake = new System.Windows.Forms.PictureBox();
            this.pictureBox_Menu = new System.Windows.Forms.PictureBox();
            this.button_light = new System.Windows.Forms.Button();
            this.button_dark = new System.Windows.Forms.Button();
            this.label_GameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Game)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Snake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Game
            // 
            this.pictureBox_Game.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox_Game.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Game.Location = new System.Drawing.Point(0, 12);
            this.pictureBox_Game.Name = "pictureBox_Game";
            this.pictureBox_Game.Size = new System.Drawing.Size(800, 438);
            this.pictureBox_Game.TabIndex = 0;
            this.pictureBox_Game.TabStop = false;
            this.pictureBox_Game.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label_score.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_score.Location = new System.Drawing.Point(198, 1);
            this.label_score.MaximumSize = new System.Drawing.Size(100, 20);
            this.label_score.MinimumSize = new System.Drawing.Size(45, 20);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(45, 20);
            this.label_score.TabIndex = 1;
            this.label_score.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_score.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.newGameToolStripMenuItem.Text = "GameOver";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkThemeToolStripMenuItem,
            this.lightThemeToolStripMenuItem});
            this.themeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darkThemeToolStripMenuItem
            // 
            this.darkThemeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.darkThemeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkThemeToolStripMenuItem.Text = "Dark Theme";
            this.darkThemeToolStripMenuItem.Click += new System.EventHandler(this.darkThemeToolStripMenuItem_Click);
            // 
            // lightThemeToolStripMenuItem
            // 
            this.lightThemeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lightThemeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            this.lightThemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightThemeToolStripMenuItem.Text = "Light Theme";
            this.lightThemeToolStripMenuItem.Click += new System.EventHandler(this.lightThemeToolStripMenuItem_Click);
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.SystemColors.WindowText;
            this.button_play.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_play.FlatAppearance.BorderSize = 4;
            this.button_play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_play.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_play.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_play.Location = new System.Drawing.Point(198, 185);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(404, 40);
            this.button_play.TabIndex = 3;
            this.button_play.Text = "PLAY";
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_theme
            // 
            this.button_theme.BackColor = System.Drawing.SystemColors.WindowText;
            this.button_theme.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_theme.FlatAppearance.BorderSize = 4;
            this.button_theme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_theme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_theme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_theme.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_theme.Location = new System.Drawing.Point(198, 248);
            this.button_theme.Name = "button_theme";
            this.button_theme.Size = new System.Drawing.Size(155, 66);
            this.button_theme.TabIndex = 4;
            this.button_theme.Text = "CHANGE THEME";
            this.button_theme.UseVisualStyleBackColor = false;
            this.button_theme.Click += new System.EventHandler(this.button_theme_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.WindowText;
            this.button_exit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_exit.FlatAppearance.BorderSize = 4;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_exit.Location = new System.Drawing.Point(447, 248);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(155, 66);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // pictureBox_Snake
            // 
            this.pictureBox_Snake.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox_Snake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Snake.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Snake.Image")));
            this.pictureBox_Snake.ImageLocation = "";
            this.pictureBox_Snake.Location = new System.Drawing.Point(577, 213);
            this.pictureBox_Snake.Name = "pictureBox_Snake";
            this.pictureBox_Snake.Size = new System.Drawing.Size(221, 243);
            this.pictureBox_Snake.TabIndex = 6;
            this.pictureBox_Snake.TabStop = false;
            // 
            // pictureBox_Menu
            // 
            this.pictureBox_Menu.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBox_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Menu.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Menu.Name = "pictureBox_Menu";
            this.pictureBox_Menu.Size = new System.Drawing.Size(800, 450);
            this.pictureBox_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Menu.TabIndex = 7;
            this.pictureBox_Menu.TabStop = false;
            // 
            // button_light
            // 
            this.button_light.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_light.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_light.FlatAppearance.BorderSize = 4;
            this.button_light.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_light.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_light.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_light.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_light.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_light.Location = new System.Drawing.Point(198, 248);
            this.button_light.Name = "button_light";
            this.button_light.Size = new System.Drawing.Size(63, 66);
            this.button_light.TabIndex = 8;
            this.button_light.Text = "LIGHT";
            this.button_light.UseVisualStyleBackColor = false;
            this.button_light.Visible = false;
            this.button_light.Click += new System.EventHandler(this.button_light_Click);
            // 
            // button_dark
            // 
            this.button_dark.BackColor = System.Drawing.SystemColors.WindowText;
            this.button_dark.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_dark.FlatAppearance.BorderSize = 4;
            this.button_dark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button_dark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.button_dark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dark.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_dark.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_dark.Location = new System.Drawing.Point(290, 248);
            this.button_dark.Name = "button_dark";
            this.button_dark.Size = new System.Drawing.Size(63, 66);
            this.button_dark.TabIndex = 8;
            this.button_dark.Text = "DARK";
            this.button_dark.UseVisualStyleBackColor = false;
            this.button_dark.Visible = false;
            this.button_dark.Click += new System.EventHandler(this.button_dark_Click);
            // 
            // label_GameOver
            // 
            this.label_GameOver.AutoSize = true;
            this.label_GameOver.BackColor = System.Drawing.SystemColors.WindowText;
            this.label_GameOver.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_GameOver.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_GameOver.Location = new System.Drawing.Point(0, 101);
            this.label_GameOver.MinimumSize = new System.Drawing.Size(800, 25);
            this.label_GameOver.Name = "label_GameOver";
            this.label_GameOver.Size = new System.Drawing.Size(800, 25);
            this.label_GameOver.TabIndex = 9;
            this.label_GameOver.Text = "Game over! Score:100";
            this.label_GameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_GameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_GameOver);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.button_dark);
            this.Controls.Add(this.button_light);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_theme);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox_Snake);
            this.Controls.Add(this.pictureBox_Game);
            this.Controls.Add(this.pictureBox_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Game)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Snake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Game;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightThemeToolStripMenuItem;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_theme;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox_Snake;
        private System.Windows.Forms.PictureBox pictureBox_Menu;
        private System.Windows.Forms.Button button_light;
        private System.Windows.Forms.Button button_dark;
        private System.Windows.Forms.Label label_GameOver;
    }
}
