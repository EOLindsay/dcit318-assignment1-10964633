using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an application to run");
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Type Identifier")
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    GradeCalculator();
                    break;
                case 2:
                    TicketPriceCalculator();
                    break;
                case 3:
                    TriangleTypeIdentifier();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        static void GradeCalculator()
        {  
            Console.Write("Enter a numerical grade between 0 and 100");
            int grade = int.parse(Console.ReadLine());
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
        static void TicketPriceCalculator()
        {
            Console.Write("Enter your age: ");
            if (age >= 65 || age <= 12)
            {
                Console.WriteLine("The ticket price is: GHC7");
            }
            else
            {
                Console.WriteLine("The ticket price is: GHC10");
            }
        }
        static void TriangleTypeIdentifier()
        {
            Console.Write("Enter the length of side 1:");
            double side1 = double.Parse(Console.ReadLine());
             Console.Write("Enter the length of side 2:");
            double side2 = double.Parse(Console.ReadLine());
             Console.Write("Enter the length of side 3:");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("This triangle is of type Equilateral.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("This triangle is of type Isosceles.");
            }
            else
            {
                Console.WriteLine("This triangle is of type Scalene.")
            }
        }
    }
}