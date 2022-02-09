using System;

namespace ComparisionOfAngles
{
    class Program
    {  
        static void Main(string[] args)
        {
            bool complete = false;
            while (!complete)
            {
                Console.WriteLine("Enter the coordinates of the points " +
                    "\n data format: x1,y1,x2,y2");
                string enterValue = Console.ReadLine();
                string[] splitEnterValue = enterValue.Split(new char[] { ',' });
                Point A;
                Point B;
                try
                {
                    SetPoints(out A, out B, splitEnterValue);
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrectly entered data");
                    continue;
                }
                if (A.IsMoreAngleOX(B)) Console.WriteLine("Larger angle forms a segment: OA");
                else if (A.IsLessAngleOX(B)) Console.WriteLine("Larger angle forms a segment: OB");
                else Console.WriteLine("The  segments form the same angles");

                Console.WriteLine("Check other points?");
                if (Console.ReadLine() == "yes") continue;
                else break;
            }
        }
        static void SetPoints(out Point a, out Point b, string[] value)
        {
            if (value.Length != 4) throw new ArgumentException();
            try
            {
                a = new Point(Convert.ToDouble(value[0]), Convert.ToDouble(value[1]));
                b = new Point(Convert.ToDouble(value[2]), Convert.ToDouble(value[3]));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
