using System;
namespace EpamNetTraining
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Epam training!";

            try
            {
                // creates the class instance
                var ui = new UserInterface();

                Circle circle;
                Square square;
                double perimeterCircle, squareCircle, perimeterSquare, squareSquare;
                Point pointCircle, pointSquare;
                bool caseOne, caseTwo;
                caseOne = caseTwo = false;

                perimeterCircle = squareCircle = perimeterSquare = squareSquare = 0;

                int sector = 1;

                // The user gets prompts and input field
                do
                {
                    Console.WriteLine("0) Exit!");
                    Console.WriteLine("1) Create the circle.");
                    Console.WriteLine("2) Create the sqaure.");
                    Console.WriteLine("3) Re-create plane shapes.");
                    Console.Write("Plese choose an action:");
                    sector = Int32.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (sector)
                    {
                        case 0:
                            break;
                        case 1:
                            if (caseOne)
                            {
                                Console.WriteLine("The circle is already created!");
                                break;
                            }

                            circle = ui.EnterCircle();
                            pointCircle = ui.EnterPoint();

                            perimeterCircle = ui.PerimeterCircle(circle);
                            squareCircle = ui.areaCircle(circle);
                            ui.CheckPointBelongsCircle(circle, pointCircle);
                            Console.WriteLine($"Perimeter of the circle is: {perimeterCircle}");
                            Console.WriteLine($"Square of the circle is: {squareCircle}");
                            caseOne = true;
                            break;
                        case 2:
                            if (caseTwo)
                            {
                                Console.WriteLine("The square is already created!");
                                break;
                            }

                            square = ui.EnterSquare();
                            pointSquare = ui.EnterPoint();

                            perimeterSquare = ui.PerimeterSquare(square);
                            squareSquare = ui.areaSquare(square);
                            ui.CheckPointBelongsSquare(square, pointSquare);
                            Console.WriteLine($"Perimeter of the square is: {perimeterSquare}");
                            Console.WriteLine($"Square of the square is: {squareSquare}");
                            caseTwo = true;
                            break;
                        case 3:
                            caseOne = caseTwo = false;
                            Console.WriteLine("You can create plane shapes again!");
                            break;
                        default: Console.WriteLine("Input error!"); break;
                    }
                    if(caseTwo && caseOne)
                    {
                        // calculates the average perimeter and area
                        double averagePerimeter = (perimeterCircle + perimeterSquare) / 2;
                        double averageArea = (squareCircle + squareSquare) / 2;

                        // Shows the average perimeter and area
                        Console.WriteLine();
                        Console.WriteLine($"Average perimetr:{averagePerimeter}");
                        Console.WriteLine($"Average square:{averageArea}");

                        // finding the largest perimeter 
                        if (perimeterCircle > perimeterSquare)
                        {
                            Console.WriteLine("The largest perimeter have circle!");
                        }
                        else
                        {
                            Console.WriteLine("The largest perimter have square!");
                        }
                    }
                }
                while (sector != 0);


                ui.Wait();
            }
            catch
            {
                Console.WriteLine("An error occurred while implementing(calculating) the figure!");
            }
        }
    }
}
