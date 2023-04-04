using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Line : Figure
    {


        public Line(int id) : base(id)
        {
        }

        protected override void Draw(Canvas canvas)
        {
            throw new NotImplementedException();
        }
    }
}