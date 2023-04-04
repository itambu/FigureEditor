using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public interface IFigure : IPaintable
    {
        int Id { get; }
    }
}