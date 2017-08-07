using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclesIntersection
{
    class Program
    {
        public class Circle
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Radius { get; set; }
        }
        static void Main(string[] args)
        {
            var firstCircleData = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var secondCircleData = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Circle firstCircle = new Circle()
            {
                X = firstCircleData[0],
                Y = firstCircleData[1],
                Radius = firstCircleData[2]
            };

            Circle secondCircle = new Circle()
            {
                X = secondCircleData[0],
                Y = secondCircleData[1],
                Radius = secondCircleData[2]
            };



            if (Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }

        private static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            var centersDistance = Math.Sqrt(Math.Pow((Math.Abs(firstCircle.X - secondCircle.X)), 2) + Math.Pow((Math.Abs(firstCircle.Y - secondCircle.Y)), 2));
            var radiusSum = firstCircle.Radius + secondCircle.Radius;
            if (radiusSum >= centersDistance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
