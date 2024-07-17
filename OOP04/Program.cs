using OOP04.Interfaces;

namespace OOP04
{
    internal class Program
    {
        public static void Print10NumberFromSeries(ISeries series)
        {
            if (series == null)
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
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumberFromSeries(seriesByTwo);
            //Print10NumberFromSeries(seriesByThree);
            #endregion


            #region Implment Interface (Implicitly Vs Explicitly) - Example 03
            //AirPlane airPlane = new AirPlane();
            //IMovable movable = new AirPlane();
            //IFlyable flyable = new AirPlane();
            //movable.Forward();
            //flyable.Forward();
            #endregion


            #region Deep Copy Vs Shallow Copy [Array Of Value Type]

            #region Shallow Copy
            //int[] Arr01 = { 1, 2, 4 };
            //int[] Arr02 = { 4, 5, 6 };
            //Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode()}");

            //// Shallow Copy
            //Arr02 = Arr01;
            ////this object {1,2,3} has 2 refereces
            ////this object {4,5,6} Unreachable object
            //Console.WriteLine("after shallow copy");
            //Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode()}");

            //Arr02[0] = 100;
            //Console.WriteLine(Arr02[0]);
            #endregion

            #region Deep Copy

            ////Clone method will genrate new object
            ////with new and diffrent identity
            ////this object will have the same object state[data]
            ////of the caller object

            //Arr02 = (int[])Arr01.Clone(); // Deep Copy
            //Console.WriteLine("after Deep Copy");
            //Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode()}");

            //Arr02[0] = 100;
            //Console.WriteLine(Arr02[0]);
            
            #endregion


            #endregion



        }
    }
}
