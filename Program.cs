using System.ComponentModel;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment_15
{
    enum WeekDays
    {
        Monday,Tuesday ,Wednesday ,Thursday ,Friday ,Saturday , Sunday
    }

    enum Season
    {
        Spring, Summer, Autumn, Winter
    }

    [Flags]
    enum Permissions : byte
    {
        None = 0, Read = 1, Write = 2, Delete = 4, Execute = 8
    }

    enum Colors
    {
        Red , Green, Blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //1.Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.

            //Console.WriteLine("Days of the Week:");

            //WeekDays[] daysOfWeek = (WeekDays[])Enum.GetValues(typeof(WeekDays));

            //for (int i = 0; i < daysOfWeek.Length; i++)
            //{
            //    Console.WriteLine(daysOfWeek[i]);
            //}
            #endregion

            #region question 2
            //2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects
            //and populate it with data.Then, write a C# program to display the details of all the persons in the array.

            ////intialize obj from person
            //Person[] personArray = new Person[3];

            ////array with 3 person
            ////this used without constructor
            //personArray[0].Name = "kerloss";
            //personArray[0].Age = 25;

            ////this used with constructor
            //personArray[1] = new Person("mohamed", 26);
            //personArray[2] = new Person("maha", 30);

            ////display array
            //for (int i = 0; i < personArray.Length; i++)
            //{
            //    Console.WriteLine($"Name: {personArray[i].Name} , Age: {personArray[i].Age}");
            //}
            #endregion

            #region question 3
            //3.Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding 
            //month range for that season. Note range for seasons ( spring march to may , summer june to august,
            //autumn September to November , winter December to February)

            //Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string input = Console.ReadLine();

            ////if condition to check the input enter 
            //if (Enum.TryParse(input, true, out Season selectedSeason))
            //{
            //    switch (selectedSeason)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine($"Month ({selectedSeason}) Range: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine($"Month ({selectedSeason}) Range: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine($"Month ({selectedSeason}) Range: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine($"Month ({selectedSeason}) Range: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season entered.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}
            #endregion

            #region question 4

            //1.Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific 
            //Permission is existed inside variable

            //Permissions myPermissions = (Permissions) 0;
            //Console.WriteLine($"Current Permissions: {myPermissions}"); //None

            ////Add permission by or bitwise operator |
            //myPermissions = myPermissions | Permissions.Read | Permissions.Write | Permissions.Delete;
            //Console.WriteLine($"After Adding Delete Permission: {myPermissions}"); //Read , Write , Delete

            ////Remove permission by &~ (NAND) or ^ (XOR)
            //myPermissions &= ~Permissions.Write;
            //Console.WriteLine($"After Removing Write Permission: {myPermissions}"); //Read , Delete
            //myPermissions ^= Permissions.Delete;
            //Console.WriteLine($"After Removing Delete Permission: {myPermissions}"); //Read

            ////Check if specific permission exists
            //if ((myPermissions & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("The Permission of Delete existed");
            //}
            //else
            //{
            //    Console.WriteLine("The permission of Delete not existed");
            //}

            //if ((myPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("The Permission of Read existed");
            //}
            //else
            //{
            //    Console.WriteLine("The permission of Read not existed");
            //}
            #endregion

            #region question 5
            //5.Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and displays a message indicating
            //whether the input color is a primary color or not.

            //Console.Write("Enter a color name (Red, Green, Blue): ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors selectedColor))
            //{
            //    switch (selectedColor)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{selectedColor} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{selectedColor} Invalid color enterd");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid color entered.");
            //}
            #endregion

            #region question 6
            //6.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# 
            //program that takes two points as input from the user and calculates the distance between them.

            ////global variable to be used in object of point
            //double x1, y1, x2 ,y2;

            //do
            //{
            //    Console.Write("Enter coordinate of first point X: ");
            //} while (!double.TryParse(Console.ReadLine(), out x1));

            //do
            //{
            //    Console.Write("Enter coordinate of first point Y: ");
            //} while (!double.TryParse(Console.ReadLine(), out y1));

            //Point point1 = new Point(x1,y1);

            //do
            //{
            //    Console.Write("Enter coordinate of second point X: ");
            //} while (!double.TryParse(Console.ReadLine(), out x2));

            //do
            //{
            //    Console.Write("Enter coordinate of second point Y: ");
            //} while (!double.TryParse(Console.ReadLine(), out y2));

            //Point point2 = new Point(x2,y2);

            //double distance = CalcDistance(point1, point2);

            //Console.Write($"The distance between 2 points is: {distance}");

            ////function to calculate the distance between 2 points
            //static double CalcDistance(Point p1 , Point p2)
            //{
            //    double deltaX = p2.X - p1.X;
            //    double deltaY = p2.Y - p1.Y;

            //    double distance = Math.Sqrt(deltaX*deltaX + deltaY*deltaY);

            //    return distance;
            //}
            #endregion

            #region question 7
            //5.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes
            //details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] person = new Person[3];
            //int age;

            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.Write($"Enter name of person {i + 1}: ");
            //    string name = Console.ReadLine();

            //    do
            //    {
            //        Console.Write($"Enter age of person {i + 1}: ");
            //    } while (!int.TryParse(Console.ReadLine(), out age));

            //    person[i] = new Person(name, age);
            //}

            ////find the oldest person
            //Person oldestPerson = person[0];
            //for (int i = 1; i < person.Length; i++)
            //{
            //    if (person[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = person[i];
            //    }
            //}

            ////display name and age of oldest person
            //Console.WriteLine($"The oldest person name is {oldestPerson.Name} with age = {oldestPerson.Age}");
            #endregion
        }
    }
}
