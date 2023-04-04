using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class FilledCircle : Circle, ISquareable, IPaintable
    {
        public Color BackGroundColor { get; set; }

        public FilledCircle(int id, double centerX, double centerY): base(id, centerX, centerY) 
        {
        }

        public new void Paint(Canvas canvas)
        {
            base.Draw(canvas);
            Console.WriteLine("Fill Circle");
        }

        protected override void Draw(Canvas canvas)
        {
            base.Draw(canvas);
            Console.WriteLine("Fill Circle");
        }
    }
}