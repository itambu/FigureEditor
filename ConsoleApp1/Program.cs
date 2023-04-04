// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
//using System.Drawing;


//--------------------------------------------------------------------------------------
// creating object model
var figures = new List<IFigure> { 
    new Circle(1, 10, 10), 
    new FilledCircle(2, 20, 20), 
    new Rectangle(3), 
    new Ellipse(5, 10, 40) { Width = 100, Height = 400 } 
};
var canvas  = new Canvas();
var editor = new FigureEditor(canvas, figures);



//--------------------------------------------------------------------------------------
// using object model
editor.PaintAll();

Console.WriteLine(editor.TotalSquare());




