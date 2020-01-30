using System;
using System.Windows;
namespace Conditional_Statements
{
    class Program
    {
        private static int grade;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Expected Grade for the Course");


            try
            {
                //Gather the user input 
                string input = Console.ReadLine();

                //this variable will be used to store the different grades
                int grades = int.Parse(input);
                //calculate grade
                //this variable will be used to get the number 


                if (grade >= 98)

                    Console.WriteLine("You got an A+ Nice!");

                else if (grade >= 92)

                    Console.WriteLine("Woah! you got an A!");
                else if (grade >= 90)
                    Console.WriteLine("You got an A-");
                else if (grade >= 88)
                    Console.WriteLine("You got an B+. Do Better!");
                else if (grade >= 82)
                    Console.WriteLine("You got a B. You are average");
                else if (grade >= 80)
                    Console.WriteLine("You got a B-. You are bad");
                else if (grade >= 78)
                    Console.WriteLine("You got a C+. Now is the time to start thinking about switching majors");
                else if (grade >= 72)
                    Console.WriteLine("You got a C");
                else if (grade >= 70)
                    Console.WriteLine("You got C minus");
                else if (grade >= 68)
                    Console.WriteLine("You got a D+, Abandon ship and drop course!");
                else if (grade >= 62)
                    Console.WriteLine("You got a D. All hope is lost");
                else if (grade >= 61)
                    Console.WriteLine("You recieved a D-. Quit");
                else if (grade <= 60)
                    Console.WriteLine("You Failed the course with a F. Switch majors");
            }
            catch 
            {
                Console.WriteLine(" Enter a value between 0 and 100");
            }
        }
    }
}
