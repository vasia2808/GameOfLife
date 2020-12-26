﻿using System;
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
        private const int PanelMovingSpeed = 10;
        private bool controlPanelMoving;

        private int resolution;
        private Graphics graphics;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            controlPanel.Location = new Point((Width - controlPanel.Width) / 2, -controlPanel.Height);
            BackgroundImage = new Bitmap(Width, Height);
            graphics = Graphics.FromImage(BackgroundImage);

            DrawGrid();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None)
            {
                if (!controlPanelMoving)
                {
                    if (MouseOnPanelLocation(e))
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
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.Location.X / resolution;
            int y = e.Location.Y / resolution;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    AddCell(x, y);
                    break;

                case MouseButtons.Right:
                    RemoveCell(x, y);
                    break;
            }

            Refresh();
        }

        private void nudResolution_ValueChanged(object sender, EventArgs e)
        {
            DrawGrid();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool MouseOnPanelLocation(MouseEventArgs e)
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

        private void AddCell(int x, int y)
        {
            DrawRectangle(x, y, Brushes.DeepSkyBlue);
        }

        private void RemoveCell(int x, int y)
        {
            DrawRectangle(x, y, new SolidBrush(BackColor));
        }

        private void DrawRectangle(int x, int y, Brush brush)
        {
            graphics.FillRectangle(brush, x * resolution, y * resolution, resolution - 1, resolution - 1);
        }
    }
}
