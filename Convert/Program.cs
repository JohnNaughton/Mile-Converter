using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert
{
    class Program
    {
        private static double kilometres;
        private static double metres = 0;
        private static int selection = 0;
        private static double inches = 0;
        private static double feet = 0;
        

        static void Main(string[] args)
        {
            menu();
        }   // end main method  

        private static void menu()
        {
            distance();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("**********************************************\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1.	Convert to Kilometres\n2.	Convert to Inches\n3.	Convert to Feet\n4.	Exit the Program");
            selection = int.Parse(Console.ReadLine());

            if (selection < 1 || selection >= 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nInvalid Selection Try Again\n");
                Console.ForegroundColor = ConsoleColor.Green;
                menu();               
            }   // end if
            else
            {
                switch (selection)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("**********************************************\n");
                        Console.Write("{0} Metres converted to Kilometres is: {1}", metres, kilometres);
                        showKilometres();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("**********************************************\n");
                        Console.Write("{0} Metres converted to Inches is: {1}", metres, inches);
                        ShowInches();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("**********************************************\n");
                        Console.Write("{0} Metres converted to Feet is: {1}", metres, feet);
                        ShowFeet();
                        break;
                    case 4:
                        break;
                }   // end switch     
            }   // end else
             
        }    // end menu 

        private static void distance()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("\nEnter a distance in meters: ");
            metres = double.Parse(Console.ReadLine());

            while (!(metres >= 1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nInvalid Input. PLease enter the number that is more than or equal to one.\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nEnter a distance in meters: ");
                metres = double.Parse(Console.ReadLine());
            }   // end while
        }

        private static void showKilometres()
        {
            kilometres = metres * 0.001;
            Console.WriteLine(kilometres);
            menu();
        }   // end showKilometres

        private static void ShowInches()
        {
            inches = metres * 39.37;
            Console.WriteLine(inches);
            menu();
        }   // end ShowInches

        private static void ShowFeet()
        {
            feet = metres * 3.281;
            Console.WriteLine(feet);
            menu();
        }   // end ShowFeet


    }   // end Class

}

