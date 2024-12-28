using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP1
{

    enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    enum seasons
    {
        Spring, Summer, Autumn, Winter
    }
    [Flags]
    enum Permissions: byte
    {
       No=16, Read=1, write=2, Delete=4, Execute=8
    }
     
    enum colors
    {
        Red, Green, Blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.

            //for (int i = 0; i < Enum.GetValues(typeof(WeekDays)).Length; i++) 
            //{ 
            //Console.WriteLine((WeekDays)i);
            //}



            #endregion

            #region Q2
            //2.Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter)
            //as its members.Write a C# program that takes a season name as input from the user
            //and displays the corresponding month range for that season. Note range for seasons
            //( spring march to may , summer june to august , autumn September to November , winter December to February)


            //Console.WriteLine("Enter season Name : ");

            //    string input = Console.ReadLine();

            // Enum.TryParse(input, true, out seasons seasons);


            ////january february march april may june july august september october november december

            //switch (seasons)
            //{
            //    case seasons.Spring:
            //        Console.WriteLine("Spring: march , april and may");
            //        break;
            //    case seasons.Summer:
            //        Console.WriteLine("Summer: june , july and august");
            //        break;
            //    case seasons.Autumn:
            //        Console.WriteLine("Autumn: september , october and november");
            //        break;
            //    case seasons.Winter:
            //        Console.WriteLine("Winter: december , january and february");
            //        break;
            //}

            #endregion

            #region Q3
            // 3.Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum
            //create Variable from previous Enum to Add and Remove Permission from variable,
            //check if specific Permission is existed inside variable

            //Permissions per= Permissions.Read | Permissions.Delete| Permissions.write| Permissions.Execute;



            //if ((per & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read is exist");
            //}
            //else
            //{
            //    per = per ^ Permissions.Read; 
            //    Console.WriteLine(per);
            //}



            //if ((per & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Delete is exist");
            //}
            //else
            //{
            //    per = per ^ Permissions.Delete;
            //    Console.WriteLine(per);
            //}


            //if ((per & Permissions.write) == Permissions.write)
            //{
            //    Console.WriteLine("write is exist");
            //}
            //else
            //{
            //    per = per ^ Permissions.write;
            //    Console.WriteLine(per);
            //}



            //if ((per & Permissions.Execute) == Permissions.Execute)
            //{
            //    Console.WriteLine("Execute is exist");
            //}
            //else
            //{
            //    per = per ^ Permissions.Execute;
            //    Console.WriteLine(per);
            //}

            #endregion

            #region Q4
            //4.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and displays a message
            //indicating whether the input color is a primary color or not



            //Console.WriteLine("Enter Color : ");
            //string input = Console.ReadLine();


            //if (Enum.TryParse(input, true, out colors color)) 
            //{

            //    if (color == colors.Red || color == colors.Green || color == colors.Blue)
            //    {
            //        Console.WriteLine($"{color} is a primary color");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("the input color isnt a primary color");
            //}



            #endregion

            #region Q5
            //5.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Point p1 = new Point();
            //Point p2 = new Point();

            //Console.WriteLine("Enter  p1.x:");
            //p1.X = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter p1.y:");
            //p1.Y = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter p2.x:");
            //p2.X = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter p2.y:");
            //p2.Y = double.Parse(Console.ReadLine());

            //double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));

            //Console.WriteLine(distance);
            #endregion


            #region Demo
            #region Exceptions

            // Exceptions
            // 1. System Exceptions
            //// 1.1 Format Exception
            //// 1.2 Index Out Of Range Exception
            //// 1.3 Null Reference Exception
            //// 1.4 Invalid Operation Exception
            //1.5 Arithmetic Exception
            //1.5.1 Divided By Zero Exception
            //1.5.2 Overflow Exception
            // 2. Application Exception







            //public static void DoSomeCode()

            //int X, Y, Z;
            //X = int. Parse(Console.ReadLine());// FormatException
            //Y = int. Parse(Console.ReadLine());

            //Z = X / Y;// DivideByZeroException

            //int[] Numbers = { 1, 2, 3 };

            //Numbers[10] = 100;// IndexOutOfRangeException
            //}


            //try
            //{
            //int X, Y, Z;
            //bool Flag;
            ////X= int.Parse(Console. ReadLine());// FormatException
            //do

            //{
            //Flag = int.TryParse(Console.ReadLine(), out X);
            //} while (!Flag) ;
            //Y = int.Parse(Console.ReadLine());

            //Z = X / Y;// DivideByZeroException


            //if (Numbers?.Length > 10)
            //{
            ////int[] Numbers = { 1, 2, 3 };

            //}

            //Numbers[10] = 100;// IndexOutOfRangeException
            //}


            #endregion


            #region Asscess Modifiers

            // private --> inside class only
            // internal --> inside class scope and other classes inside same project
            // internal --> inside class scope and other classes inside other project (Import)


            //public TypeA()
            //{
            //TypeB typeB = new TypeB();
            //}
            //prIvate int X;
            //internal int Y;
            //public int Z;

            #endregion

            #region ENUM



            //  enum Gender
            //  {
            //Male , Female
            // }
            //enum Days
            //  {
            //Saturday,
            //Sunday,
            //Monday,
            //Tuesdayl,
            //Wednesday,
            //Thursday,
            //Friday
            //   }

            //    enum Gender : byte
            //{
            //    Male, Female
            //}
            //enum Grades
            //{
            //    A, B, C, D, E, F
            //}

            //    enum Roles
            //{
            //    Admin = 10, Viewer = 20, Editor = 30
            //}




            #region Ex01

            //string Day = "Hamada";
            //Days Day = Days. Friday;
            //   Grades grade = Grades.A;
            //    if (grade == Grades.A)
            //{
            //        Console.WriteLine(":)");
            // }
            //      else
            // {
            //           Console.WriteLine(":(");
            //           }

            #endregion

            #region Ex02

            //Grades grade = (Grades)2;

            //Console.WriteLine(grade);


            //Console.WriteLine(grade); // C
            //Grades grade = (Grades)10;// Excplicit Casting

            //Console.WriteLine(grade); // }0

            #endregion


            #region Ex03
            //Grades grade = (Grades) Enum. Parse(typeof(Grades), Console. ReadLine());
            //EnumITryParse(typeof(Grades), Console. ReadLine(), out object Result);
            //Grades grade = (Grades) Result;
            //Console. WriteLine (Result);
            #endregion


            #region Ex04
            //string gender = "male";

            //Enum.TryParse(typeof(Gender), gender, out object Result);

            //Console.WriteLine(Result);

            //Enum.TryParse(gender, true, out Gender Result);
            #endregion

            #endregion

            #region permissions


            //class Employee
            //{
            //public string Name;
            //public int Age;
            //public decimal Salary;
            //public Gender Gender; // Male - Female / 0 - 1
            //public Permissions Permissions;
            //}

            //[Flags]
            //enum Permissions : byte
            //{
            //Delete = 1, Execute = 2, Read = 4, Write = 8
            //}




            //Employee employee = new Employee();
            //employee.Name = "Ali";
            //employee.Age = 20;
            //employee.Permissions = (Permissions)3;

            //Console.WriteLine(employee.Permissions);// Delete, Execute


            // XOR
            //employee.Permissions = employee.Permissions ^ Permissions.Read;

            //Console.WriteLine(employee.Permissions);// Delete, Execute ,Read

            //employee.Permissions = employee.Permissions ^ Permissions.Read;

            //Console.WriteLine(employee.Permissions);// Delete, Execute

            // &


            //if ((employee.Permissions & Permissions.Read) == Permissions.Read)
            //{
            //Console.WriteLine("Read is exist");
            //}
            //else
            //{
            //employee.Permissions = employee.Permissions ^ Permissions.Read;
            //}



            //OR    


            //employee.Permissions = employee.Permissions | Permissions.Read;


            //Console.WriteLine(employee.Permissions);


            #endregion

            #region Struct


            //// What You Can Write Inside The Struct Or Class
            ////1. Attributes[Fields] => Member Variable

            /////int x;
            ////int y;


            ////2. Functions[Constructor, Getter Setter, Method]


            //Constructor Special Function
            //1.Name Constructor Same Name Class or Struct
            //2.no return



            //public Point(int _x, int _y)
            //X= _x;
            //Y= _y;


            ////3. Properties[Full Property, Automatic Property, Indexer]
            ////4. Events
            
            ////Access Modifier Allowed Inside Struct?
            ////1. Private[Default]
            ////2. Internal
            ////3. Public







            //Console.WriteLine(P01.X);//invalid
            //P01.X=10;
            //P01.Y = 20;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01 = new Point(2);

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);


            //Point p01
            //Console.WriteLime(P01); //AlexGroupDemoSession0100P.Point
            //Console.WriteLine(P01.ToString()): //AlexGroupDemoSession0100P.Point



            //int X = 10;
            //Console.WriteLine(X);
            //Console.WriteLine(X.ToString());
            #endregion
            #endregion

        }
    }
}
