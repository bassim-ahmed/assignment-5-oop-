using session_5__oop_.abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_5__oop_.abstraction
{
    //abstract class :is partial implemention to another class[Not fully Implemnted]
    //can not create an object from abstract class
    internal abstract class Shape
    {
        protected Shape(decimal dim01, decimal dim02)
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }

        public decimal Dim01 {  get; set; }
        public decimal Dim02 { get; set; }

        //Abstract Method ->not Implemented
        //must be contained inside abstract class
        public abstract decimal CalcArea();
        public abstract decimal perimeter { get; }
    }
    abstract class Recbase : Shape {
        protected Recbase(decimal dim01, decimal dim02) : base(dim01, dim02)
        {
        }

        public override decimal CalcArea()
        {
            return Dim01 + Dim02;
        }
    }

}
//Class:Class->Inherit
//Class:Interface ->Implement
//Class:abstract class->Inhertand implemnt
//Sahpe -:abstract class
 class Rectangle : Recbase {
    public Rectangle(decimal dim01, decimal dim02) : base(dim01, dim02)
    {
    }

    public override decimal perimeter
    {
        get { return (Dim01 + Dim02) * 2; }
    }

}
    class squrae : Recbase
{
    public squrae(decimal  Dim ) : base(Dim, Dim)
    {

    }

    public override decimal perimeter
        {
            get { return Dim01 * 4; }
        }

     
    }



