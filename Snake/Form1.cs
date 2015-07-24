using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Snake
{
    public partial class Form1 : Form
    {
        private List<circle> Snake = new List<circle>();
        private circle food = new circle();
        

        public Form1()
        {
            InitializeComponent();
            //Set settings to default
            new Settings();
            Settings.high_score = Properties.Settings.Default.HighScore;
            high_score_label.Text = "High Score: " + Settings.high_score.ToString();

            //Set game speed and start timer
            game_timer.Interval = 100 / Settings.Speed;
            game_timer.Tick += UpdateScreen;
            game_timer.Start();

            //Start game
            StartGame();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check whether the game is over
            if (Settings.GameOver)
            {
                //Check if enter is pressed
                if (input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Settings.GamePause == false)
                {
                    if (input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                        Settings.direction = Direction.Right;
                    else if (input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                        Settings.direction = Direction.Left;
                    else if (input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                        Settings.direction = Direction.Up;
                    else if (input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                        Settings.direction = Direction.Down;

                    MovePlayer();
                }
            }
            game_canvas.Invalidate();
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].x++;
                            break;
                        case Direction.Left:
                            Snake[i].x--;
                            break;
                        case Direction.Up:
                            Snake[i].y--;
                            break;
                        case Direction.Down:
                            Snake[i].y++;
                            break;
                    }

                    //Get maximum X and Y Pos
                    int maxXPos = game_canvas.Size.Width / Settings.Width;
                    int maxYPos = game_canvas.Size.Height / Settings.Height;

                    //Detect collision with game borders.
                    if (Snake[i].x < 0 || Snake[i].y < 0
                        || Snake[i].x >= maxXPos || Snake[i].y >= maxYPos)
                    {
                        Die();
                    }

                    //Detect collision with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].x == Snake[j].x &&
                           Snake[i].y == Snake[j].y)
                        {
                            Die();
                        }
                    }

                    //Detect collision with food piece
                    if (Snake[0].x == food.x && Snake[0].y == food.y)
                    {
                        Eat();
                    }
                }
                //Move body
                else
                {
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }
        }

        private void Eat()
        {
            //Add circle to body
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.bite_sound;
            player.Play();
            circle circle = new circle
            {
                x = Snake[Snake.Count - 1].x,
                y = Snake[Snake.Count - 1].y
            };
            Snake.Add(circle);

            //Update Score
            Settings.Score += Settings.Points;
            label_points.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.dies_sound;
            player.Play();
        }

        private void StartGame()
        {
            label_gameOver.Visible = false;
            label_pause.Visible = false;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stop();
            //Set settings to default
            new Settings();
            //Create new player object
            Snake.Clear();
            circle head = new circle { x = 10, y = 5 };
            Snake.Add(head);
            for (int i = 0; i < 3; i++)
            {
                circle body = new circle { x = 10, y = 4 - i };
                Snake.Add(body);
            }
            label_points.Text = Settings.Score.ToString();
            GenerateFood();
        }

        //Place food object
        private void GenerateFood()
        {
            bool food_over_body = false;
            int max_x_pos = game_canvas.Size.Width / Settings.Width;
            int max_y_pos = game_canvas.Size.Height / Settings.Height;
            int x1, y1;
            Random random = new Random();
            x1 = random.Next(0, max_x_pos);
            y1 = random.Next(0, max_y_pos);
            //Exclude snake coordinates
            for (int i = 0; i < Snake.Count; i++)
            {
                if (Snake[i].x == x1 &&
                   Snake[i].y == y1)
                {
                    food_over_body = true;
                }
            }
            if (food_over_body == false)
            {
                food = new circle { x = x1, y = y1 };
            }
            else
                GenerateFood();
        }

        private void info_click(object sender, EventArgs e)
        {
            about info = new about();
            info.Show();
        }

        private void game_canvas_Paint(object sender, PaintEventArgs e)
        {
            //Graphics canvas = e.Graphics;
            if (!Settings.GameOver)
            {
                    //Set color of snake
                    //Brush snake_color;
                    //Draw snake
                    for (int i = 0; i < Snake.Count; i++)
                    {
                        if (i == 0)
                        {
                            //Draw head
                            //snake_color = Brushes.Black; 
                            Bitmap headIMG = Properties.Resources.head_image;
                            e.Graphics.DrawImage(headIMG, new Rectangle(Snake[i].x * Settings.Width,
                                Snake[i].y * Settings.Height, Settings.Width, Settings.Height));
                        }
                        else
                        {
                            //rest of the body
                            //snake_color = Brushes.Green;
                            Bitmap bodyIMG = Properties.Resources.body_image;
                            e.Graphics.DrawImage(bodyIMG, new Rectangle(Snake[i].x * Settings.Width,
                                Snake[i].y * Settings.Height, Settings.Width, Settings.Height));
                        }

                        //Draw snake
                        //canvas.FillEllipse(snake_color,
                        //    new Rectangle(Snake[i].x * Settings.Width,
                        //    Snake[i].y * Settings.Height,
                        //    Settings.Width,
                        //    Settings.Height));

                        //Draw food
                        //canvas.FillEllipse(Brushes.Red,
                        //    new Rectangle(food.x * Settings.Width,
                        //        food.y * Settings.Height,
                        //        Settings.Width,
                        //        Settings.Height));
                        Bitmap foodIMG = Properties.Resources.food_image;
                        e.Graphics.DrawImage(foodIMG, new Rectangle(food.x * Settings.Width,
                                food.y * Settings.Height, Settings.Width + 2, Settings.Height + 2));
                }
            }
            else
            {
                string gameOver = "Game over\nYour score is: " + Settings.Score + "\nPress enter to try again.";
                label_gameOver.Text = gameOver;
                label_gameOver.Visible = true;
                if (Settings.Score > Settings.high_score && Settings.Score > Properties.Settings.Default.HighScore)
                {
                    Settings.high_score = Settings.Score;
                    high_score_label.Text = "High score: " + Settings.high_score.ToString();
                    if (Settings.high_score > Properties.Settings.Default.HighScore)
                    {
                        Properties.Settings.Default.HighScore = Settings.high_score;
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }

        private void form1_keyDown(object sender, KeyEventArgs e)
        {
            input.ChangeState(e.KeyCode, true);
        }

        private void form1_keyUP(object sender, KeyEventArgs e)
        {
            input.ChangeState(e.KeyCode, false);
        }

        private void pause_key(object sender, KeyPressEventArgs e)
        {
            if (input.KeyPressed(Keys.Escape) && Settings.GameOver == false)
            {
                if (Settings.GamePause == false)
                {
                    Settings.GamePause = true;
                    label_pause.Visible = true;
                }
                else
                {
                    Settings.GamePause = false;
                    label_pause.Visible = false;
                }
            }
            if (input.KeyPressed(Keys.R))
            {
                StartGame();
                //Settings.GamePause = true;
            }
        }

        private void controls_click(object sender, EventArgs e)
        {
            if (controls_box.Visible)
            {
                controls_box.Visible = false;
            }
            else
            {
                controls_box.Visible = true;
                controls_box.BringToFront();
            }

        }

        private void reset_click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HighScore = 0;
            Properties.Settings.Default.Save();
            high_score_label.Text = "High Score: 0";
        }
    }
}
