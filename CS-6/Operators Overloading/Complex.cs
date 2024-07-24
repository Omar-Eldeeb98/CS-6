using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_6.Operators_Overloading
{
    internal class Complex
    {
        // properties
        public int real { get; set; }
        public int imaginary { get; set; }

        // methods
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }


        #region operator overloading.

        // operator (+) overloading method
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {

                real = (left?.real ?? 0) + (right?.real ?? 0),
                imaginary = (left?.imaginary ?? 0) + (right?.imaginary ?? 0)

            };
        }

        // operator (-) overloading method
        public static Complex operator -(Complex left, Complex right)

        {
            return new Complex()
            {

                real = (left?.real ?? 0) - (right?.real ?? 0),
                imaginary = (left?.imaginary ?? 0) - (right?.imaginary ?? 0)
            };

        }



        // operator (++) overloading method
        public static Complex operator ++(Complex complex)
        {
            return new Complex()
            {
                real = (complex?.real ?? 0) + 1,
                imaginary = (complex?.imaginary ?? 0)
            };
        }

        // operator (--) overloading method
        public static Complex operator --(Complex complex)
        {
            return new Complex()
            {
                real = (complex?.real ?? 0) - 1,
                imaginary = (complex?.imaginary ?? 0)
            };
        }




        // operator (>) overloading method
        public static bool operator >(Complex left, Complex right)
        {
            if (left.real == right.real)
            {
                return left.imaginary > right.imaginary;
            }
            else
            {
                return left.real > right.real;
            }

        }


        // operator (<) overloading method
        public static bool operator <(Complex left, Complex right)
        {
            if (left.real == right.real)
            {
                return left.imaginary < right.imaginary;
            }
            else
            {
                return left.real < right.real;
            }

        }



        #endregion



        #region casting operators overloading.


        // (int) casting operator overloading.

        public static /*int*/ explicit operator int (Complex c) 

        {
            return c?.real ?? 0;

        }



        // (string) casting operator overloading.

        public static /*string*/ explicit operator string(Complex c)

        {
            return c?.ToString() ?? string.Empty;    

        }














        #endregion


    }
}
