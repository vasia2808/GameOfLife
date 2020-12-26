using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        private int resolution;
        private Graphics graphics;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ControlPanel.Location = new Point((Width - ControlPanel.Width) / 2, 0);
            BackgroundImage = new Bitmap(Width, Height);
            graphics = Graphics.FromImage(BackgroundImage);

            DrawGrid();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void nudResolution_ValueChanged(object sender, EventArgs e)
        {
            DrawGrid();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DrawGrid()
        {
            resolution = (int)nudResolution.Value;

            graphics.Clear(BackColor);

            Pen pen = new Pen(Brushes.Black);

            for (int x = 0; x < Width; x += resolution)
            {
                graphics.DrawLine(pen, new Point(x, 0), new Point(x, Height));
            }

            for (int y = 0; y < Height; y += resolution)
            {
                graphics.DrawLine(pen, new Point(0, y), new Point(Width, y));
            }

            Refresh();
        }

        private void AddCell()
        {

        }

        private void RemoveCell()
        {

        }

        private void DrawCell()
        {

        }
    }
}
