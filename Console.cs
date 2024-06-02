using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade between 0 and 100");
            int grade = int.parse(ConsoleApp.ReadLine());
            if (grade >= 90)
            {
                ConsoleApp.WriteLine("The grade is: A");
            }
            else if (grade >=80)
            {
                ConsoleApp.WriteLine("The grade is: B");
            }
            else if (grade >=70)
            {
                ConsoleApp.WriteLine("The grade is: C");
            }else if (grade >=60)
            {
                ConsoleApp.WriteLine("The grade is: D");
            }else
            {
                ConsoleApp.WriteLine("The grade is: F")
            }
        }
    }
}