using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class FigureEditor
    {
        public List<Figure> Figures { get; private set; }

        public Canvas? Canvas { get; private set; }

        public FigureEditor(Canvas canvas, List<Figure>? figures)
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
    }
}