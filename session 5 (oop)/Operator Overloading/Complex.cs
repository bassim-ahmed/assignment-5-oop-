using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_5__oop_.Operator_Overloading
{
    internal class Complex
    {
        public int Real {  get; set; }
        public int Imag { get; set; }
        public override string ToString()
        {
            return $"{Real} + {Imag}I";
        }
        #region operator overridin
        // +
        //NON PRIVATE //CLASS MEMBER METHOD
        public static Complex operator + (Complex a, Complex b) {
            //2+5I
            //5+2i
            //7+7I

            return new Complex()
            {
                Real = (a?.Real?? 0)+(b?.Real?? 0),
                Imag=(a?.Imag?? 0)+(b?.Imag ??0)
            };
        }
        public static Complex operator -(Complex a, Complex b)
        {
            //2+5I
            //5+2i
            //7+7I

            return new Complex()
            {
                Real = (a?.Real ?? 0) - (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) - (b?.Imag ?? 0)
            };

           
        }
        #region operators overloading unary
        //++
        public static Complex operator ++ (Complex  c)
        {

            return new Complex()
            {
                Real = (c?.Real ?? 0) + 1,
                Imag = (c?.Imag ?? 0)

            };



        }

        //--
        public static Complex operator --(Complex c)
        {

            return new Complex()
            {
                Real = (c?.Real ?? 0) - 1,
                Imag = (c?.Imag ?? 0)

            };




        }
        public static bool operator > (Complex Left,Complex Right)
        {

            if (Left.Real == Right.Real) 
            return Left.Imag > Right.Imag;
            else
              return Left.Real > Right.Real;

        }
        public static bool operator <(Complex Left, Complex Right)
        {

            if (Left.Real == Right.Real)
                return Left.Imag < Right.Imag;
            else
                return Left.Real < Right.Real;

        }
        #region casting operators overloading
        //(int)
        public static explicit operator int (Complex c)
        {

          return c?.Real??0;




        }
        public static /*string*/ implicit operator string(Complex c)
        {

            return c?.ToString()??string.Empty;


        }

        #endregion
        #endregion
        #endregion
    }
}
