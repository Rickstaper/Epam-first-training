using System;

namespace EpamNetTraining
{
    partial class Program
    {
        /// <summary>
        /// Represent a 2D circle
        /// </summary>
        public class Circle
        {
            private Point _center;
            private double _radius;

            /// <summary>
            /// Creates an instence of circle
            /// </summary>
            /// <param name="center">Coordinates of center</param>
            /// <param name="radius">Radius of circle</param>
            public Circle(Point center, double radius)
            {
                _center = center;
                _radius = radius;
            }

            /// <summary>
            /// Checks whether the specified circle parameters are valid
            /// </summary>
            /// <param name="center">Coordinates of center</param>
            /// <param name="radius">Radius of circle</param>
            /// <returns>True if center and radius are valid</returns>
            public static bool isValid(Point center, double radius)
            {
                return radius>0;
            }

            /// <summary>
            /// Get the perimeter of the circle
            /// </summary>
            public double Perimeter
            {
                get { return 2 * Math.PI * _radius; }
            }

            /// <summary>
            /// Get the square of the circle
            /// </summary>
            public double Area
            {
                get { return Math.PI * Math.Pow(_radius, 2); }
            }

            /// <summary>
            /// Defines whether the specified point belongs to the circle
            /// </summary>
            /// <param name="point">A point to check</param>
            /// <returns>True if the circle contains the specified point</returns>
            public bool Contains(Point point)
            {
                var distanceX = Math.Abs(_center.x-point.x);
                var distanceY = Math.Abs(_center.y-point.y);
                var distance = Math.Sqrt(Math.Pow(distanceX,2)+Math.Pow(distanceY,2));
                return distance <= _radius;
            }
        }
    }
}
