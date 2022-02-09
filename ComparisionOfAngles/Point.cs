using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisionOfAngles
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double GetAngleOX()
        {
            double AngleOX = Math.Atan2(Y, X) * 180 / Math.PI;
            if (AngleOX < 0) return 180 + Math.Abs(AngleOX);
            else return AngleOX;
        }

        public bool IsMoreAngleOX(Point point)
        {
            return GetAngleOX() > point.GetAngleOX();
        }

        public bool IsLessAngleOX(Point point)
        {
            return GetAngleOX() < point.GetAngleOX();
        }
        public bool IsEqualAngleOX(Point point)
        {
            return GetAngleOX() == point.GetAngleOX();
        }

        public void PrintPoint()
        {
            Console.Write($"x = {X}; y = {Y}");
        }

    }
}
