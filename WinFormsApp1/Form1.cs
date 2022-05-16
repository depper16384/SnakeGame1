using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        Color black;
        Color maroon;
        string gray_hex = "#222222";
        Color gray;
        Color white;
        Color light_gray;

        SolidBrush area_brush;
        SolidBrush red_brush;
        SolidBrush blue_brush;

        Point[] snake;
        Point apple;



        int len = 1;
        int score;
        int width, height;

        Random ran;
        public Form1()
        {
            InitializeComponent();

            black = SystemColors.WindowText;
            maroon = Color.Maroon;
            gray = System.Drawing.ColorTranslator.FromHtml(gray_hex);
            white = SystemColors.HighlightText;
            light_gray = SystemColors.ScrollBar;

            ran = new Random();

            snake = new Point[10000];

            pictureBox_Game.Image = new Bitmap(pictureBox_Game.Width, pictureBox_Game.Height);
            width = pictureBox_Game.Width / 10;
            height = pictureBox_Game.Height / 10;
            snake[0].X = width / 2;
            snake[0].Y = height / 2;

            area_brush = new SolidBrush(Color.Black);
            red_brush = new SolidBrush(Color.Red);
            blue_brush = new SolidBrush(Color.Blue);

            apple.X = ran.Next(0, width - 1);
            apple.Y = ran.Next(0, height - 1);
        }
        public void refreshStatus()
        {
            label_score.Text = $"Score: {Convert.ToString(score)}";


            score = len - 4;

        }
        string direction = "up";
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox_Game.Image);
            if (button_play.Visible == false)
            {
                g.FillRectangle(area_brush, 0, 0, pictureBox_Game.Width, pictureBox_Game.Height);
                for (int i = 1; i < len; i++)
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }


                for (int i = 0; i < len; i++)
                {
                    if (snake[i].X < 0) snake[i].X += width;
                    if (snake[i].X > width) snake[i].X -= width;
                    if (snake[i].Y < 0) snake[i].Y += height;
                    if (snake[i].Y > height) snake[i].Y -= height;
                    g.FillRectangle(red_brush, snake[i].X * 10, snake[i].Y * 10, 10, 10);
                    refreshStatus();
                    if (apple.X == snake[i].X && apple.Y == snake[i].Y)
                    {
                        apple.X = ran.Next(0, width - 1);
                        apple.Y = ran.Next(0, height - 1);
                        len++;

                    }
                }

                g.FillEllipse(blue_brush, apple.X * 10, apple.Y * 10, 10, 10);
                if (direction == "up") snake[0].Y -= 1;
                if (direction == "down") snake[0].Y += 1;
                if (direction == "left") snake[0].X -= 1;
                if (direction == "right") snake[0].X += 1;

                if (len > 10000 - 3) len = 10000 - 3;

                for (int i = len; i >= 0; i--)
                {
                    snake[i + 1].X = snake[i].X;
                    snake[i + 1].Y = snake[i].Y;

                }
                if (len < 4) len++;
                pictureBox_Game.Invalidate();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval < 11) timer1.Interval = 11;
            timer1.Interval -= 10;
        }


        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {


            if (direction == "left")
            {
                if (e.KeyCode == Keys.W)
                {
                    direction = "up";
                }
                if (e.KeyCode == Keys.S)
                {
                    direction = "down";
                }
                if (e.KeyCode == Keys.Up)
                {
                    direction = "up";
                }
                if (e.KeyCode == Keys.Down)
                {
                    direction = "down";
                }
            }
            if (direction == "right")
            {
                if (e.KeyCode == Keys.W)
                {
                    direction = "up";
                }
                if (e.KeyCode == Keys.S)
                {
                    direction = "down";
                }
                if (e.KeyCode == Keys.Up)
                {
                    direction = "up";
                }
                if (e.KeyCode == Keys.Down)
                {
                    direction = "down";
                }
            }
            if (direction == "up")
            {
                if (e.KeyCode == Keys.A)
                {
                    direction = "left";
                }
                if (e.KeyCode == Keys.D)
                {
                    direction = "right";
                }
                if (e.KeyCode == Keys.Left)
                {
                    direction = "left";
                }
                if (e.KeyCode == Keys.Right)
                {
                    direction = "right";
                }
            }
            if (direction == "down")
            {
                if (e.KeyCode == Keys.A)
                {
                    direction = "left";
                }
                if (e.KeyCode == Keys.D)
                {
                    direction = "right";
                }
                if (e.KeyCode == Keys.Left)
                {
                    direction = "left";
                }
                if (e.KeyCode == Keys.Right)
                {
                    direction = "right";
                }
            }
        }

        private void OpenMenu()
        {
            menuStrip1.Visible = false;
            label_score.Visible = false;
            pictureBox_Game.Visible = false;
            button_dark.Visible = false;
            button_light.Visible = false;
            label_GameOver.Visible = false;

            pictureBox_Snake.Visible = true;
            pictureBox_Menu.Visible = true;
            button_play.Visible = true;
            button_theme.Visible = true;
            button_exit.Visible = true;


            snake[0].X = width / 3;
            snake[0].Y = height / 3;
        }
        private void OpenGame()
        {
            menuStrip1.Visible = true;
            label_score.Visible = true;
            pictureBox_Game.Visible = true;

            pictureBox_Snake.Visible = false;
            pictureBox_Menu.Visible = false;
            button_play.Visible = false;
            button_theme.Visible = false;
            button_exit.Visible = false;
            button_dark.Visible = false;
            button_light.Visible = false;
            label_GameOver.Visible = false;

            snake[0].X = width / 2;
            snake[0].Y = height / 2;
        }

        private void CloseGame()
        {
            this.Close();
        }
        private void SetColorDark(ToolStripMenuItem item)
        {
            item.BackColor = gray;
            foreach (ToolStripMenuItem ddItem in item.DropDownItems)
            {
                SetColorDark(ddItem);
            }
        }
        private void SetColorDarkFont(ToolStripMenuItem item)
        {
            item.ForeColor = white;
            foreach (ToolStripMenuItem ddItem in item.DropDownItems)
            {
                SetColorDarkFont(ddItem);
            }
        }
        private void ChangeonDark()
        {
            for (int i = 0; i < menuStrip1.Items.Count; i++)
            {
                SetColorDark(menuStrip1.Items[i] as ToolStripMenuItem);
                SetColorDarkFont(menuStrip1.Items[i] as ToolStripMenuItem);
            }
            menuStrip1.BackColor = gray;
            label_score.BackColor=gray;
            label_score.ForeColor=white;
            label_GameOver.ForeColor = white;
            label_GameOver.BackColor = black;
            pictureBox_Game.BackColor = black;
            pictureBox_Snake.BackColor = black;
            pictureBox_Menu.BackColor = black;
            button_play.ForeColor = white;
            button_play.BackColor = black;
            button_play.FlatAppearance.MouseOverBackColor = gray;
            button_theme.ForeColor = white;
            button_theme.BackColor = black;
            button_theme.FlatAppearance.MouseOverBackColor = gray;
            button_exit.ForeColor = white;
            button_exit.BackColor = black;
            button_exit.FlatAppearance.MouseOverBackColor = gray;
            this.BackColor = gray;
            area_brush = new SolidBrush(black);

        }
        private void SetColorLight(ToolStripMenuItem item)
        {
            item.BackColor = light_gray;
            foreach (ToolStripMenuItem ddItem in item.DropDownItems)
            {
                SetColorLight(ddItem);
            }
        }
        private void SetColorLightFont(ToolStripMenuItem item)
        {
            item.ForeColor = black;
            foreach (ToolStripMenuItem ddItem in item.DropDownItems)
            {
                SetColorLightFont(ddItem);
            }
        }
        private void ChangeonLight()
        {
            for (int i = 0; i < menuStrip1.Items.Count; i++)
            {
                SetColorLight(menuStrip1.Items[i] as ToolStripMenuItem);
                SetColorLightFont(menuStrip1.Items[i] as ToolStripMenuItem);
            }
            menuStrip1.BackColor = light_gray;
            label_score.BackColor = light_gray;
            label_score.ForeColor = black;
            label_GameOver.ForeColor = black;
            label_GameOver.BackColor = white;
            pictureBox_Game.BackColor = white;
            pictureBox_Snake.BackColor = white;
            pictureBox_Menu.BackColor = white;
            button_play.ForeColor = black;
            button_play.BackColor = white;
            button_play.FlatAppearance.MouseOverBackColor = light_gray;
            button_theme.ForeColor = black;
            button_theme.BackColor = white;
            button_theme.FlatAppearance.MouseOverBackColor = light_gray;
            button_exit.ForeColor = black;
            button_exit.BackColor = white;
            button_exit.FlatAppearance.MouseOverBackColor = light_gray;
            this.BackColor = white;
            area_brush = new SolidBrush(white);
        }
        private void button_play_Click(object sender, EventArgs e)
        {
            OpenGame();
        }

        private void button_theme_Click(object sender, EventArgs e)
        {
            button_theme.Visible = false;
            button_light.Visible = true;
            button_dark.Visible = true;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            CloseGame();
        }
        private void button_light_Click(object sender, EventArgs e)
        {
            button_theme.Visible = true;
            button_light.Visible = false;
            button_dark.Visible = false;
            ChangeonLight();
        }
        private void button_dark_Click(object sender, EventArgs e)
        {
            button_theme.Visible = true;
            button_light.Visible = false;
            button_dark.Visible = false;
            ChangeonDark();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameOver();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseGame();
        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeonDark();
        }

        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeonLight();
        }
        private void GameOver()
        {
            OpenMenu();
            len = 4;
            label_GameOver.Visible = true;
            label_GameOver.Text = ($"Game over! Score: { Convert.ToString(score)}");
            score = 0;
        }
    }
}
