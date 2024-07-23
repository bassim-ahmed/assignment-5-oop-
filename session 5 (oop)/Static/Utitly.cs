using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_5__oop_.Static
{
    //helper class
    internal class Utitly
    {

        public int X { get; set; }
        public int Y { get; set; }
        public Utitly(int x, int y)
        {
            X = x;
            Y = y;
        }
        //class member construct 
        //static constructor
         static Utitly()
        {
            //pi = 3.149;
        }
        private static double pi=3.14;
        public static double PI
        {
            get { return pi; }
            //set { pi = value; }
        }

        public override string ToString()
        {

            return $"x: {X},Y:{Y}";

        }
        //cM TO iNCH
        public static double CmToInch(double cm)
        {

        return cm/2.54; 
        }
        public static double CalcCircleArea(double R)
        {
            return pi * R * R;
        }
    }


    }

