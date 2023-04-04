using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class ConnectionLine : IPaintable
    {
        public void Paint(Canvas canvas)
        {
            Console.WriteLine("Drawing connection line");
        }
    }
}