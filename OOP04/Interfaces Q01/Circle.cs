using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interfaces_Q01
{
    internal class Circle : ICircle
    {
        public Circle(double _radius)
        {
            Radius = _radius;
        }
        public double Radius { get;set; }
        public double Area { get { return Math.PI * Radius * Radius; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius = {Radius}\nArea = {Area}");
        }

        
    }
}
