using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangle : Figure
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }

        protected override void Draw(Canvas canvas)
        {
            Console.WriteLine("Rectangle is painted");
        }

        public Rectangle(int id) : base(id) { }
    }
}
