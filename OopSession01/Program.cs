using Microsoft.VisualBasic.FileIO;
using System.Security;
using System.Security.Cryptography;

namespace OopSession01
{

    enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    enum Seasons
    {
        Spring, Summer, Autumn, Winter
    }
    [Flags]
    enum Permissions : byte
    {
        Read = 1, Write = 2, Execute = 4, Delete = 8
    }

    enum Colors
    {
        red, green, blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //Console.WriteLine("Days of Week : ");
            //string[] days = Enum.GetNames(typeof(WeekDays)); // GetNames() => Retrieves an array of the names of the constants in a specified enumeration.
            //foreach (string day in days)
            //{
            //    Console.WriteLine(day);
            //} 

            #endregion

            #region Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //bool IsParse;
            //Seasons season;
            //do
            //{
            //    Console.Write("Enter the Season : ");
            //    IsParse = Enum.TryParse(Console.ReadLine(), out season);
            //} while (!IsParse);

            //switch (season)
            //{
            //    case Seasons.Spring:
            //        Console.WriteLine("spring march to may.");
            //        break;
            //    case Seasons.Winter:
            //        Console.WriteLine(" winter December to February.");
            //        break;
            //    case Seasons.Summer:
            //        Console.WriteLine("summer june to august.");
            //        break;
            //    case Seasons.Autumn:
            //        Console.WriteLine("autumn September to November.");
            //        break;
            //    default:
            //        break;
            //} 

            #endregion

            #region Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum
            //Permissions permissions = (Permissions)3; // read , write

            //Console.WriteLine(permissions);

            //if ((permissions & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Delete is Existed.");
            //}
            //else
            //{
            //    permissions ^= Permissions.Delete;   // Add Permission Delete .
            //}
            //Console.Write("After Adding : ");
            //Console.WriteLine(permissions);

            //if ((permissions & Permissions.Write) == Permissions.Write)
            //{
            //    permissions ^= Permissions.Write;
            //}
            //else
            //{
            //    Console.WriteLine("Write is Not Existed. ");  // remove Permission Write .
            //}
            //Console.Write("After Rremoving : ");
            //Console.WriteLine(permissions);

            #endregion

            #region Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.Write("Enter the Color : ");
            //string input = Console.ReadLine();  
            //bool IsParse = Enum.TryParse(input, out Colors Color);
            //if (IsParse)
            //{
            //    Console.WriteLine($"{Color} is Primary Color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not Primary Color.");

            //} 
            #endregion
        }
    }
}
