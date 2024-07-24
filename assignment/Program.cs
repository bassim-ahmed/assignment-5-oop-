using assignment.part_1;
using assignment.part2;

namespace assignment
{

    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }


        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }


        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }


        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else if (Minutes > 0)
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else
            {
                return $"Seconds: {Seconds}";
            }
        }


     

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }

    internal class Program
    {


       


        static void Main(string[] args)
        {
            #region part 1
            //Point3D point=new Point3D(1,5,3);
            ////Console.WriteLine(point);
            //Console.WriteLine("Enter coordinates for Point P1:");
            //Point3D P1 = Point3D.FromInput();
            //Console.WriteLine("Enter coordinates for Point P2:");
            //Point3D P2 = Point3D.FromInput();
            //Console.WriteLine($"P1 == P2: {P1 == P2}");//false
            //Point3D[] points = { new Point3D(3, 2, 1), new Point3D(1, 2, 3), new Point3D(2, 3, 1) };
            //Array.Sort(points);

            //Console.WriteLine("Sorted Points:");
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}
            //Point3D P3 = (Point3D)P1.Clone();
            //Console.WriteLine($"Cloned Point: {P3}");
            #endregion
            #region part2
            int a = 10;
            int b = 5;

            Console.WriteLine($"Add: {assignment.part2.Math.Add(a, b)}");
            Console.WriteLine($"Subtract: {assignment.part2.Math.Subtract(a, b)}");
            Console.WriteLine($"Multiply: {assignment.part2.Math.Multiply(a, b)}");
            Console.WriteLine($"Divide: {assignment.part2.Math.Divide(a, b)}");
            #endregion
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); 

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString()); 

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString()); 

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString()); 

        }





    }
}
