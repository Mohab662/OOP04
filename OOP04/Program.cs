using OOP04.Interfaces;
using OOP04.Interfaces_EX2;

namespace OOP04
{
    internal class Program
    {
        public static void Print10NumberFromSeries(ISeries series)
        {
            if (series==null)
            {
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current}\t");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region Interface - Example 02
            SeriesByTwo seriesByTwo = new SeriesByTwo();
            SeriesByThree seriesByThree = new SeriesByThree();
            Print10NumberFromSeries(seriesByTwo);
            Print10NumberFromSeries(seriesByThree);
            #endregion
            AirPlane airPlane = new AirPlane();
            IMovable movable = new AirPlane();
            IFlyable flyable = new AirPlane();
            movable.Forward();
            flyable.Forward();




        }
    }
}
