﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circle : Figure, ISquareable
    {
        public double CenterX { get; set; }
        public double CenterY { get; set; }

        public double Radius { get; set; }

        public double Square => Math.PI*Radius*Radius;

        protected override void Draw(Canvas canvas)
        {
            Console.WriteLine("Circle. Kuku");
        }

        public Circle(int id, double centerX, double centerY) : base(id)
        {
            this.CenterX = centerX;
            this.CenterY = centerY;
        }

        public void Move(double dx, double dy)
        {
            CenterX += dx;
            CenterY += dy;
        }
    }
}
