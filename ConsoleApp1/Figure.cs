using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Figure : IFigure
    {
        public int Id { get; init; }
        protected abstract void Draw(Canvas canvas);

        public void Paint(Canvas canvas)
        {
            // doing something
            Console.WriteLine(Id);

            Draw(canvas);
        }

        public Figure(int id)
        {
            Id = id;
        }


    }
}