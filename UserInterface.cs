using System;


namespace EpamNetTraining
{
    partial class Program
    {
        public class UserInterface
        {
            /// <summary>
            /// Asking the user to enter center coordinates and raduis
            /// </summary>
            /// <returns>Instance of Circle</returns>
            public Circle EnterCircle()
            {
                Console.WriteLine("Enter circle center coordinates and radius:");
                Console.WriteLine("X\tY\tR");
                string input = Console.ReadLine();

                string[] values = input.Split(' ');
                double coordinateX = double.Parse(values[0]);
                double coordinateY = double.Parse(values[1]);
                double radius = double.Parse(values[2]);

                Point centerCoords = new Point(coordinateX,coordinateY);

                if (Circle.isValid(centerCoords, radius))
                {
                    return new Circle(centerCoords, radius);
                }

                return null;
            }
            /// <summary>
            /// Asking the user to enter first point coordinates and side
            /// </summary>
            /// <returns>Instance of Square</returns>
            public Square EnterSquare()
            {
                Console.WriteLine("Enter square first point coordinates and side:");
                Console.WriteLine("X\tY\tSide");
                string input = Console.ReadLine();

                string[] values = input.Split(' ');
                double coordinateX = double.Parse(values[0]);
                double coordinateY = double.Parse(values[1]);
                double side = double.Parse(values[2]);

                Point firstPoint = new Point(coordinateX,coordinateY);

                if (Square.isValid(firstPoint, side))
                {
                    return new Square(firstPoint, side);
                }
                return null;
            }
            /// <summary>
            /// Asking the user to enter 2D coordinates
            /// </summary>
            /// <returns>Instance of point</returns>
            public Point EnterPoint()
            {
                Console.WriteLine("Enter point in the following format:");
                Console.WriteLine("X\tY");
                string input = Console.ReadLine();

                string[] values = input.Split(' ');
                double coordinateX = double.Parse(values[0]);
                double coordinateY = double.Parse(values[1]);

                Point PointCoordinates = new Point(coordinateX, coordinateY);
                return PointCoordinates;

            }
            /// <summary>
            /// Transmits the perimeter of the circle to the user
            /// </summary>
            /// <param name="circle"></param>
            public double PerimeterCircle(Circle circle)
            {
                return circle.Perimeter;
            }
            /// <summary>
            /// Transmits the perimeter of the square to the user
            /// </summary>
            /// <param name="square"></param>
            public double PerimeterSquare(Square square)
            {
                return square.Perimeter;
            }
            /// <summary>
            /// Transmits the square of the circle to the user
            /// </summary>
            /// <param name="circle"></param>
            public double areaCircle(Circle circle)
            {
                return circle.Area;
            }
            /// <summary>
            /// Transmits the square of the square to the user
            /// </summary>
            /// <param name="square"></param>
            public double areaSquare(Square square)
            {
                return square.Area;
            }
            /// <summary>
            /// Tells the users whether the specified point belongs to the circle or not
            /// </summary>
            /// <param name="circle"></param>
            /// <param name="point"></param>
            public void CheckPointBelongsCircle(Circle circle, Point point)
            {
                if (circle.Contains(point))
                {
                    Console.WriteLine("The point belongs to the circle");
                }
                else
                {
                    Console.WriteLine("The point doesn't belong to the circle");
                }
            }

            public void CheckPointBelongsSquare(Square square,Point point)
            {
                if (square.Contains(point))
                {
                    Console.WriteLine("The point belongs to the square");
                }
                else
                {
                    Console.WriteLine("The point doesn't belong to the square");
                }
            }

            public void Wait()
            {
                Console.ReadKey();
            }
        }
    }
}
