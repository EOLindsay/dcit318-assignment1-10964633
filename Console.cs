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
                Console.WriteLine("The grade is: A");
            }
            else if (grade >=80)
            {
                Console.WriteLine("The grade is: B");
            }
            else if (grade >=70)
            {
                Console.WriteLine("The grade is: C");
            }else if (grade >=60)
            {
                Console.WriteLine("The grade is: D");
            }else
            {
                Console.WriteLine("The grade is: F")
            }
        }
    }
}
