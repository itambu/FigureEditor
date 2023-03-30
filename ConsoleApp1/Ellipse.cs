﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Ellipse : Figure
    {
        public double CenterX { get; set; }
        public double CenterY { get; set; }

        public double Width { get; set; }
        public double Height { get; set; }

        public Ellipse(int id, double centerX, double centerY) : base(id)
        {
            CenterX = centerX;
            CenterY = centerY;
        }

        protected override void Draw(Canvas canvas)
        {
            Console.WriteLine("Paint ellispse");
        }
    }
}