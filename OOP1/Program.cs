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

        }
    }
}
