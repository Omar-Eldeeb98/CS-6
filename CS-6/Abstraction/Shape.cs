using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_6.Abstraction
{
    // abstract class, can not take an object from it.
    // [abstract class] : is a partial implementation to another class.
    internal abstract class Shape
    {
        // properties
        public decimal dimention1 { get; set; }

        public decimal dimention2 { get; set; }


        // abstract method, not implemented.
        public abstract decimal calcArea();


        public abstract decimal calcPerimeter();

    }


    //---------------------------------------------------------

    // class: abstract class ---> inherit & implement
    class Rectangle:Shape
    {
        // abstract method
        public override decimal calcArea()
        {
            return dimention1 * dimention2;
        }

        public override decimal calcPerimeter()
        {
            return (dimention1 + dimention2) * 2;
        }
    }



    // -----------------------------------------------------------

    class Square : Shape
    {
        public Square(decimal dimention)
        {
            this.dimention1 = this.dimention2 = dimention;
        }
        public override decimal calcArea()
        {
            return dimention1 * dimention2; 
        }

        public override decimal calcPerimeter()
        {
            return dimention1 * 4;
        }
    }


    // -----------------------------------------------------------


    class Circle : Shape
    {

        public Circle(decimal radius)
        {
            dimention1 =  dimention2 = radius;
        }

        public override decimal calcArea()
        {
            return 3.14m * dimention2 * dimention2;
        }

        public override decimal calcPerimeter()
        {
            return 2 * 3.14m * dimention1; 
        }
    }






}
