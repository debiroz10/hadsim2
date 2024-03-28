using System;
using System.Security.Cryptography;

class Program
{
    // Function to calculate properties of a rectangular tower
    static void RectangularTower()
    {
        // Prompt user for tower height and width
        Console.Write("Enter the height of the rectangular tower: ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Enter the width of the rectangular tower: ");
        int width = int.Parse(Console.ReadLine());

        // Check if tower is a rectangle or a square based on the difference between height and width
        if (Math.Abs(height - width) > 5)
        {
            // Calculate and print the area if it's a rectangle
            int area = height * width;
            Console.WriteLine("The area of the rectangular tower is: " + area);
        }
        else
        {
            // Calculate and print the perimeter if it's a square
            int perimeter = 2 * (height + width);
            Console.WriteLine("The perimeter of the rectangular tower is: " + perimeter);
        }
    }

    // Function to calculate properties of a triangular tower and print its shape
    static void TriangularTower()
    {
        // Prompt user for tower height and width
        Console.Write("Enter the height of the triangular tower: ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Enter the width of the triangular tower: ");
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("1. Calculation of the perimeter of the triangle");
        Console.WriteLine("2. Printing the triangle");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        // Present options for triangular tower
        switch (choice)
        {
            case "1":
                // Calculate perimeter of the triangular tower
                double side = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width / 2.0, 2));
                double perimeter = 2 * side + width;
                Console.WriteLine("The perimeter of the triangular tower is: " + perimeter);
                break;
            case "2":
                // Checking conditions for printing the triangle
                if (width % 2 == 0 || width > 2 * height)
                {
                    Console.WriteLine("Unable to print the triangle");
                    return;
                }
                // Calculation of the number of lines in the middle of the triangle
                // The amount of odd numbers that are in the width minus the first and the last
                int odd = width / 2 - 1;
                //There is no odd number to fill the triangle in the middle
                if (odd==0)
                {
                    Console.WriteLine("Unable to print the triangle There is no odd number to fill the triangle in the middle");
                    return;
                }
                // Checking if the rows are divided evenly and keeping the remainder
                int check = (height - 2) % odd;
                {
                  int  rows = 1;
                    int help = 0; // A variable that will help us check if we have reached all the rows
                    int numStars = 1;
                    while (help != height-1)
                    {
                        //Print lines

                        for (int i = 1; i <= rows; i++)
                        {
                            // Print spaces
                            for (int j = 0; j < (width - numStars) / 2; j++)
                            {
                                Console.Write(" ");
                            }

                            //print stars
                            for (int j = 0; j < numStars; j++)
                            {
                                Console.Write("*");
                                
                            }
                            help++;

                            // Print spaces
                            for (int j = 0; j < (width - numStars) / 2; j++)
                            {
                                Console.Write(" ");
                            }

                            Console.WriteLine();    
                        }
                        if (check != 0)//Checking if the rows are evenly distributed
                        {
                            rows = (height - 2) / odd + check;
                            check = 0;
                        }
                        else { rows = (height - 2) / odd; }
                        
                        numStars += 2;
                    }
                }
                // print the last line
                for (int i = 0; i < width; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void Main(string[] args)
    {
        // Main menu loop
        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Rectangular Tower");
            Console.WriteLine("2. Triangular Tower");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RectangularTower();
                    break;
                case "2":
                    TriangularTower();
                    break;
                case "3":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }
}

