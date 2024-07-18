using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interfaces_Q01
{
    internal class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double _width, double _height)
        {
            Height = _height;
            Width = _width;
        }
        public double Area { get { return Width * Height; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Width = {Width}\nHieght = {Height}\nArea = {Area}");
        }
    }
}
