using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class FigureEditor
    {
        public List<IFigure> Figures { get; private set; }

        public Canvas? Canvas { get; private set; }

        public FigureEditor(Canvas canvas, List<IFigure>? figures)
        {
            Canvas = canvas;
            Figures = figures!;
        }

        public void PaintAll()
        {
            if (Figures == null)
            {
                throw new NullReferenceException($"{nameof(Figures)} is null");
            }
            if (Canvas == null)
            {
                throw new NullReferenceException($"{nameof(Canvas)} is null");
            }

            foreach (var f in Figures)
            {
                f.Paint(Canvas);
            }
        }

        public double TotalSquare()
        {
            double temp = 0;
            foreach (var f in Figures) 
            {
                ISquareable? item = f as ISquareable;
                if (item!= null)
                {
                    temp += item.Square;
                }
            }

            return temp;
        }
    }
}