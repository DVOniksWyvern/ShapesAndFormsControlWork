using System;

namespace ShapesAndForms
{
    class Program
    {

        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Enter a shape name (Available choices are square, diamond, triangle or rectangle): ");
            string userChoice = Console.ReadLine().ToUpper();

            double area;
            double perimeter;


            if (userChoice == "SQUARE")
            {
                Console.WriteLine("Enter square side length value: ");

                long squareSide = Int64.Parse(Console.ReadLine());

                for (long i = 1; i <= squareSide; i++)

                {
                    for (long j = 1; j <= squareSide; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                area = squareSide * squareSide;
                perimeter = 4 * squareSide;

                Console.WriteLine("Area: {0}, Perimeter: {1}", area, perimeter);
            }
            else if (userChoice == "DIAMOND")
            {
                long i, j, diamondSide;
                Console.Write("Enter diamond side length value: ");

                diamondSide = Convert.ToInt64(Console.ReadLine());

                for (i = 0; i <= diamondSide; i++)

                {
                    for (j = 1; j <= diamondSide - i; j++)
                        Console.Write(" ");
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }

                for (i = diamondSide - 1; i >= 1; i--)

                {
                    for (j = 1; j <= diamondSide - i; j++)
                        Console.Write(" ");
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write(" * ");
                    Console.Write("\n");
                }

                double diagonal = 2 * diamondSide - 1;
                area = diagonal * diagonal / 2;
                perimeter = 4 * diamondSide;

                Console.WriteLine("Area: {0}, Perimeter: {1}", area, perimeter);

            }

            else if (userChoice == "TRIANGLE")

            {
                long triangleSide, i, j, count = 1;
                Console.Write("Enter triangle side length:");
                triangleSide = long.Parse(Console.ReadLine());

                count = triangleSide - 1;
                for (j = 1; j <= triangleSide; j++)
                {

                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;

                    for (i = 1; i <= 2 * j - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }

                double triangleBase = 2 * triangleSide - 1;
                double height = triangleSide;
                area = (triangleBase * height) / 2;
                perimeter = triangleBase + 2 * triangleSide;

                Console.WriteLine("Area: {0}, Perimeter: {1}", area, perimeter);
            }
            else if (userChoice == "RECTANGLE")
            {
                Console.WriteLine("Enter rectangle width value:");

                long height = long.Parse(Console.ReadLine());

                Console.WriteLine("Enter rectangle height value:");

                long width = long.Parse(Console.ReadLine());

                for (long i = 1; i <= width; i++)

                {
                    for (long j = 1; j <= height; j++)

                    {
                        Console.Write(" * "); //only one which looks right with spaces
                    }

                    Console.WriteLine("");

                }
                area = height * width;
                perimeter = 2 * height + 2 * width;

                Console.WriteLine("area: {0}, perimeter:{1}", area, perimeter);

            }
            else
            {
                Console.WriteLine("Invalid choice: Available shapes are Square, Diamond, Triangle or Rectangle. Please, try again.");
            }

        Decide:
            Console.WriteLine("Another shape? Yes or No");

            string UserDecision = Console.ReadLine().ToUpper();

            switch (UserDecision)
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Invalid input - only 'Yes' or 'No' are valid inputs. Please, try again.");
                    goto Decide;

            }
        }
    }
}