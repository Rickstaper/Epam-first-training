using System;
namespace EpamNetTraining
{
    partial class Program
    {
        /// <summary>
        /// Represent a 2D Square
        /// </summary>
        public class Square
        {
            private Point _FirstPoint;
            private double _side;
            /// <summary>
            /// Creates an instence of square
            /// </summary>
            /// <param name="FirstPoint">Coordinates of first point</param>
            /// <param name="side">Length of side</param>
            public Square(Point FirstPoint, double side)
            {
                _FirstPoint = FirstPoint;
                _side = side;
            }
            /// <summary>
            /// Checks whether the specified square parameters are valid
            /// </summary>
            /// <param name="center">Coordinates of first point</param>
            /// <param name="radius">Length of side</param>
            /// <returns>True if first point and side are valid</returns>
            public static bool isValid(Point FirstPoint, double side)
            {
                return side > 0;
            }
            /// <summary>
            /// Get the perimeter of the square
            /// </summary>
            public double Perimeter
            {
                get { return 4 * _side; }
            }
            /// <summary>
            /// Get the square of the square
            /// </summary>
            public double Area
            {
                get { return Math.Pow(_side,2); }
            }
            /// <summary>
            /// Defines whether the specified point belongs to the square
            /// </summary>
            /// <param name="point">A point to check</param>
            /// <returns>True if the square contains the specified point</returns>
            public bool Contains(Point point)
            {
                var distanceX = _FirstPoint.x + _side;
                var distanceY = _FirstPoint.y - _side;
                return _FirstPoint.x <= point.x && distanceX >= point.x && _FirstPoint.y >= point.y && distanceY <= point.y;
            }
        }
    }
}
