using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        #region CursonShown
        private bool _CursorShown = true;
        private bool CursorShown
        {
            get
            {
                return _CursorShown;
            }
            set
            {
                if (value == _CursorShown)
                {
                    return;
                }

                if (value)
                {
                    Cursor.Show();
                }
                else
                {
                    Cursor.Hide();
                }

                _CursorShown = value;
            }
        }
        #endregion

        private enum GameStatus
        {
            Start,
            Pause,
            Reset
        }

        #region constants
        private const int PanelMovingSpeed = 10;
        private const int MaxSpeed = 16;
        private const int MinSpeed = 500;
        private readonly Color cellColor = Color.DeepSkyBlue;
        #endregion

        private bool controlPanelMoving;
        private GameStatus gameStatus = GameStatus.Reset;
        private int resolution;
        private Graphics graphics;
        private GameEngine gameEngine;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            controlPanel.Location = new Point((Width - controlPanel.Width) / 2, -controlPanel.Width);
            BackgroundImage = new Bitmap(Width, Height);
            graphics = Graphics.FromImage(BackgroundImage);

            nudResolution_ValueChanged(null, null);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None)
            {
                if (!controlPanelMoving)
                {
                    if (MouseOnControlPanelLocation(e))
                    {
                        ShowControlPanel();
                    }
                    else
                    {
                        HideControlPanel();
                    }
                }
            }
            else
            {
                MainForm_MouseDown(sender, e);
            }

            if (gameStatus == GameStatus.Start)
            {
                CursorShown = true;
                timerMouse.Start();
            }
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            timerMouse.Stop();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (gameStatus != GameStatus.Start)
            {
                int x = e.Location.X / resolution;
                int y = e.Location.Y / resolution;

                switch (e.Button)
                {
                    case MouseButtons.Left:
                        AddCell(x, y);
                        gameEngine.AddCell(x, y);
                        break;

                    case MouseButtons.Right:
                        RemoveCell(x, y);
                        gameEngine.RemoveCell(x, y);
                        break;
                }

                Refresh();
            }
        }

        private void nudResolution_ValueChanged(object sender, EventArgs e)
        {
            resolution = (int)nudResolution.Value;
            InitializeGameEngine();
            DrawGrid();
            Refresh();
        }

        private void nudSpeed_ValueChanged(object sender, EventArgs e)
        {
            timerGame.Interval = (int)Map((int)nudSpeed.Value, (int)nudSpeed.Minimum, (int)nudSpeed.Maximum, MinSpeed, MaxSpeed);
        }

        private float Map(float n, float start1, float stop1, float start2, float stop2)
        {
            return (n - start1) / (stop1 - start1) * (stop2 - start2) + start2;
        }

        #region Buttons
        private void buttonStart_Click(object sender, EventArgs e)
        {
            switch (gameStatus)
            {
                case GameStatus.Start:
                    gameStatus = GameStatus.Pause;
                    buttonStart.Text = "Continue";
                    PauseGame();
                    break;

                case GameStatus.Pause:
                    gameStatus = GameStatus.Start;
                    buttonStart.Text = "Pause";
                    StartGame();
                    break;

                case GameStatus.Reset:
                    gameStatus = GameStatus.Start;
                    buttonStart.Text = "Pause";
                    StartGame();
                    break;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            gameStatus = GameStatus.Reset;
            buttonStart.Text = "Start";
            ResetGame();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void timerGame_Tick(object sender, EventArgs e)
        {
            DrawGeneration();
        }

        private void timerMouse_Tick(object sender, EventArgs e)
        {
            CursorShown = false;
            timerMouse.Stop();
        }

        #region MovingControlPanel
        private bool MouseOnControlPanelLocation(MouseEventArgs e)
        {
            return e.Location.X < controlPanel.Location.X + controlPanel.Width && e.Location.X >= controlPanel.Location.X && e.Location.Y < controlPanel.Height;
        }

        private async void ShowControlPanel()
        {
            controlPanelMoving = true;
            controlPanel.Enabled = true;

            while (controlPanel.Location.Y < 0 - PanelMovingSpeed)
            {
                controlPanel.Location = new Point(controlPanel.Location.X, controlPanel.Location.Y + PanelMovingSpeed);
                await Task.Delay(16);
            }

            controlPanel.Location = new Point(controlPanel.Location.X, 0);
            controlPanelMoving = false;
        }

        private async void HideControlPanel()
        {
            controlPanelMoving = true;

            while (controlPanel.Location.Y > -controlPanel.Height + PanelMovingSpeed)
            {
                controlPanel.Location = new Point(controlPanel.Location.X, controlPanel.Location.Y - PanelMovingSpeed);
                await Task.Delay(16);
            }

            controlPanel.Location = new Point(controlPanel.Location.X, -controlPanel.Height);
            controlPanel.Enabled = false;
            controlPanelMoving = false;
        }
        #endregion

        private void StartGame()
        {
            DisableControls();

            gameEngine.SetRules(textBoxBorn.Text, textBoxSurvive.Text);

            timerGame.Start();
        }

        private void PauseGame()
        {
            timerGame.Stop();
        }

        private void ResetGame()
        {
            timerGame.Stop();
            InitializeGameEngine();
            DrawGrid();
            Refresh();
            textBoxGeneration.Text = "0";
            EnableControls();
        }

        private void EnableControls()
        {
            SetControlsEnabled(true);
        }

        private void DisableControls()
        {
            SetControlsEnabled(false);
        }

        private void SetControlsEnabled(bool enabled)
        {
            nudResolution.Enabled = enabled;
            textBoxBorn.Enabled = enabled;
            textBoxSurvive.Enabled = enabled;
        }

        private void InitializeGameEngine()
        {
            gameEngine = new GameEngine
            (
                rows: Height / resolution,
                cols: Width / resolution
            );
        }

        #region Draw

        private void DrawGeneration()
        {
            gameEngine.NextGeneration();

            bool[,] field = gameEngine.GetCurrentGeneration();

            DrawGrid();

            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if (field[x, y])
                    {
                        AddCell(x, y);
                    }
                }
            }

            textBoxGeneration.Text = gameEngine.CurrentGeneration.ToString();
            Refresh();
        }
        private void DrawGrid()
        {
            graphics.Clear(BackColor);

            Pen pen = new Pen(Brushes.Black);

            for (int x = resolution - 1; x < Width; x += resolution)
            {
                graphics.DrawLine(pen, new Point(x, 0), new Point(x, Height));
            }

            for (int y = resolution - 1; y < Height; y += resolution)
            {
                graphics.DrawLine(pen, new Point(0, y), new Point(Width, y));
            }
        }

        private void AddCell(int x, int y)
        {
            DrawRectangle(x, y, new SolidBrush(cellColor));
        }

        private void RemoveCell(int x, int y)
        {
            DrawRectangle(x, y, new SolidBrush(BackColor));
        }

        private void DrawRectangle(int x, int y, Brush brush)
        {
            graphics.FillRectangle(brush, x * resolution, y * resolution, resolution - 1, resolution - 1);
        }
        #endregion
    }
}
