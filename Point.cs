namespace EpamNetTraining
{
    partial class Program
    {
        /// <summary>
        /// Represent a 2D point
        /// </summary>
        public class Point
        {
            /// <summary>
            /// Creates an instance of point
            /// </summary>
            /// <param name="coordinateX">Coordinate x</param>
            /// <param name="coordinateY">Coordinate y</param>
            public Point(double coordinateX,double coordinateY)
            {
                x = coordinateX;
                y = coordinateY;
                
            }
            /// <summary>
            /// Sets or gets coordinates x and y
            /// </summary>
            public double x { get; set; }
            public double y { get; set; }
        }
    }
}
