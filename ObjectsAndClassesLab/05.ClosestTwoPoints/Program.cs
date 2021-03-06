﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class Program
    {
        public class Point
        {
            public double X { get; set; }

            public double Y { get; set; }
        }
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPointParts = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                points.Add(new Point
                {
                    X = currentPointParts[0],
                    Y = currentPointParts[1]
                });
            }

            var minDistance = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    double currentDistance = CalculateDistance(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y})");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y})");


        }
        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = Math.Pow(Math.Abs(firstPoint.X - secondPoint.X), 2);
            var diffY = Math.Pow(Math.Abs(firstPoint.Y - secondPoint.Y), 2);
            return Math.Sqrt(diffX + diffY);
        }
    }
}
