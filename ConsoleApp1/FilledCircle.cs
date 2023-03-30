using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class FilledCircle : Circle
    {
        public Color BackGroundColor { get; set; }

        public FilledCircle(int id, double centerX, double centerY): base(id, centerX, centerY) 
        {
        }


        protected override void Draw(Canvas canvas)
        {
            base.Draw(canvas);
            Console.WriteLine("Fill Circle");
        }
    }
}