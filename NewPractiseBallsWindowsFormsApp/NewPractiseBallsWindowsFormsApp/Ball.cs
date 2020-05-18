﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NewPractiseBallsWindowsFormsApp
{
    class Ball
    {
        protected static Random random = new Random();
        protected int x = 250;
        protected int y = 250;
        protected int vx = 10;
        protected int vy = 10;
        protected Brush brush = Brushes.Red;
        private MainForm form;
        protected Timer timer = new Timer();
        private Rectangle rectangle;
        private int size;
        private double radius;
        private bool active;
        private Graphics graphics;
        public Ball(MainForm form)
        {
            this.form = form;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            size = 50;
            radius = size / 2;
        }
        public void Show()
        {
            Graphics graphics = form.CreateGraphics();
            rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
        private void Go()
        {
            x += vx;
            y += vy;
        }
        private void Clear()
        {
            var graphics = form.CreateGraphics();
            graphics.FillEllipse(Brushes.White, rectangle);
        }
        private void Move()
        {
            Clear();
            Go();
            Show();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public void StopMoving()
        {
            timer.Stop();
            active = false;
        }
        public void Start()
        {
            timer.Start();
            active = true;
        }
        public bool ClickCheck(Point location)
        {
            return Math.Pow(location.X - x-radius, 2) + Math.Pow(location.Y - y-radius, 2) <= Math.Pow(size, 2);
        }
        public bool OnScreen()
        {
            return x < form.Width - size && y < form.Height - size && x > 0 && y > 0;
        }
        public bool IsBallActive()
        {
            return active;
        }
        public void DeleteBalls()
        {
            graphics.Clear(Color.White);
        }
    }
}