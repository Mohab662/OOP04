using OOP04.Interfaces;
using OOP04.Interfaces_Q03;

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
            #region Part01
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


            #region Deep Copy Vs Shallow Copy [Array Of Reference Type (String)]

            #region Shallow Copy
            //string[] Name01 = new string[] { "mohab " };
            //string[] Name02 = new string[1];

            //Console.WriteLine($"HashCode Arr01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Name02.GetHashCode()}");

            ////// Shallow Copy
            //Name02 = Name01;
            //Console.WriteLine("after shallow copy");
            //Console.WriteLine($"HashCode Arr01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Name02.GetHashCode()}");

            //Console.WriteLine(Name01[0]); // mohab
            //Console.WriteLine(Name02[0]); // mohab

            //Name02[0] = "Mohamed";
            //Console.WriteLine("after changing");
            //Console.WriteLine($"HashCode Arr01 = {Name01[0]}");
            //Console.WriteLine($"HashCode Arr02 = {Name02[0]}");
            #endregion

            #region Deep Copy
            //Name02 = (string[])Name01.Clone();

            //Console.WriteLine("after Deep copy");
            //Console.WriteLine($"HashCode Arr01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Name02.GetHashCode()}");

            //Console.WriteLine(Name01[0]); // Mohamed
            //Console.WriteLine(Name02[0]); // Mohamed

            //Name02[0] = "Bekan";
            //Console.WriteLine("after changing");
            //Console.WriteLine($"HashCode Arr01 = {Name01[0]}"); // Mohamed
            //Console.WriteLine($"HashCode Arr02 = {Name02[0]}"); // Belkan

            #endregion

            #endregion


            #region Part 05 Deep Copy Vs Shallow Copy [Array Of Reference Type (StringBuilder)]

            //StringBuilder[] Name01 = new StringBuilder[1];

            //Name01[0] = new StringBuilder ( "mohab" );

            //StringBuilder[] Name02 = new StringBuilder[1];

            #region Shallow Copy
            //Console.WriteLine($"HashCode Arr01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Name02.GetHashCode()}");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //////// Shallow Copy
            //Console.WriteLine("after shallow copy");
            //Console.WriteLine($"HashCode Arr01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Name02.GetHashCode()}");
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //Name02[0].Append("Nagy");
            //Console.WriteLine("after change");
            //Console.WriteLine($"HashCode Arr01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Name02.GetHashCode()}");

            #endregion

            #region Deep copy
            //Name02 = (StringBuilder[])Name01.Clone();
            //Console.WriteLine("after Deep copy");
            //Console.WriteLine($"HashCode Arr01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Name02.GetHashCode()}");
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //Name02[0].Append("Nagy");
            //Console.WriteLine("after change");
            //Console.WriteLine($"HashCode Arr01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HashCode Arr02 = {Name02.GetHashCode()}"); 
            #endregion

            #endregion

            #region Interfaces - ICloneable
            //Employee employee01 = new Employee()
            //{
            //    Id = 1,
            //    Name = "mohab",
            //    Salary = 5000,
            //    Department = new Department
            //    {
            //        Id = 150,
            //        Name = "AR"
            //    }
            //};
            //Employee employee02 = new Employee()
            //{
            //    Id = 2,
            //    Name = "Belkan",
            //    Salary = 5000,
            //    Department = new Department
            //    {
            //        Id = 100,
            //        Name = "HR"
            //    }
            //};
            //Console.WriteLine($"Hash code of employee01 = {employee01.GetHashCode()} ");
            //Console.WriteLine($"Hash code of employee02 = {employee02.GetHashCode()} ");

            //Employee employee03 = employee01; // shallow copy

            //employee03 = (Employee)employee01.Clone(); // Deep copy

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Hash code of employee01 = {employee01.GetHashCode()} ");
            //Console.WriteLine($"Hash code of employee03 = {employee03.GetHashCode()} ");

            //employee03.Department.Name = "SR";

            //Console.WriteLine(employee01);
            //Console.WriteLine(employee03);
            #endregion

            #region Built-In Interface ICompareable
            //int[] Numbers = { 7, 5, 3, 15, 7, 8, 64, 6, 56 };

            //Array.Sort(Numbers);

            //Employee[] employees =
            //{
            //    new Employee(){Id=10,Name="mohab",Salary=3000 },
            //     new Employee(){Id=101,Name="Nagy",Salary=10000 },
            //      new Employee(){Id=150,Name="Belkan",Salary=8000 }
            //};
            //Array.Sort(employees);
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #endregion

            /////////Part 02 Choose
            #region Part 02

            #region Part 02 Choose
            //Question 1: What is the primary purpose of an interface in C#?
            // a) To provide a way to implement multiple inheritance

            //Question 2: Which of the following is NOT a valid access modifier for interface members in C#?
            // a) private

            //Question 3: Can an interface contain fields in C#?
            // a) Yes

            //Question 4: In C#, can an interface inherit from another interface?
            // b) Yes, interfaces can inherit from multiple interfaces

            //Question 5: Which keyword is used to implement an interface in a class in C#?
            // d) implements

            //Question 6: Can an interface contain static methods in C#?
            // a) Yes

            //Question 7: In C#, can an interface have explicit access modifiers for its members?
            // b) No, all members are implicitly public

            //Question 8: What is the purpose of an explicit interface implementation in C#?
            // a) To hide the interface members from outside access

            //Question 9: In C#, can an interface have a constructor?
            // b) No, interfaces cannot have constructors

            //Question 10: How can a C# class implement multiple interfaces?
            // c) By separating interface names with commas 
            #endregion

            #region Part 02 Interfaces

            #region Question 01:

            //Circle circle = new Circle(10);
            //circle.DisplayShapeInfo();

            //Rectangle rectangle = new Rectangle(10, 20);
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Question 02:

            //IAuthenticationService authenticationService = new BasicAuthenticationService("mohab","123","SA" );

            //Console.WriteLine(authenticationService.AuthenticateUser("mohab", "123"));
            //Console.WriteLine(authenticationService.AuthorizeUser("mohab","SAssss"));

            #endregion

            #region Question 03:

            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //string recipient = "mohabmbelkan.com";
            //string message = "This is  notification.";

            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification(recipient, message);
            //pushService.SendNotification(recipient, message);

            #endregion

            #endregion

            #endregion



        }

    }
}
