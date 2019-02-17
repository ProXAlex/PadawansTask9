using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            if(points == null)
                throw new ArgumentNullException();
            if(range<=0)
                throw new ArgumentException("Range can be only positive numbers");

            List<Point> resultList = new List<Point>();

            foreach (var point1 in points)
            {
                if(Math.Abs(point1.X - point.X) <= range && Math.Abs(point1.Y - point.Y) <= range)
                    resultList.Add(point1);
            }

            return resultList;
        }
    }
}