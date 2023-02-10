using System;
using System.ComponentModel;

namespace HellowCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //wlecome user to our application
            Console.WriteLine("welcome to student grade application ");
            //ask user write the grade and username
            Console.WriteLine("Please enter your Name");
            string UserName = Console.ReadLine();
            Console.WriteLine("Please enter your grade");
            double GradeStudent = 0;
            //check if user enter a valid number
            bool bIsNumber = double.TryParse(Console.ReadLine(), out GradeStudent);
            if (!bIsNumber)
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }
            //check if number not less than zero and grdeter than 100
            if (GradeStudent < 0 || GradeStudent > 100)
            {
                Console.WriteLine("number must be between 0 and 100");
                return;
            }
            //check if grade faill
            if (GradeStudent < 50)
            {
                Console.WriteLine("oops! " + UserName + " you are failed");

            }
            //check if grade fair
            else if (GradeStudent >= 50 && GradeStudent < 65)
            {
                Console.WriteLine("Congratulations " + UserName + " you are fair");
            }
            //check if grade very good
            else if (GradeStudent >= 65 && GradeStudent < 75)
            {
                Console.WriteLine("Congratulations " + UserName + " you are good");

            }
            //check if grade very good
            else if (GradeStudent >= 75 && GradeStudent < 85)
            {
                Console.WriteLine("Congratulations " + UserName + " you are vary good");

            }
            //check grade excelent
            else
            {
                Console.WriteLine("Congratulations " + UserName + " you are excelent");

            }
            Console.ReadKey();
        }
    }

}
