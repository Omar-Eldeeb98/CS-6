using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_6.Static
{
    internal class Utility

    {
        public int x { get; set; }
        public int y { get; set; }

        //readonly static member attr.
        private readonly static double pi = 3.14;

        // static member prop.
        public static double PI
        {
            get
            {
                return pi;

            }

        }


        //// constant
        //private const double pi = 3.14;


        // static constructor
        static Utility()
        {

            //// used for initialize static attributes.
            //pi = 3.14;  // invalid if i use (const)
        }


        // object member constructor.
        public Utility(int x, int y)
        {
            this.x = x;
            this.y = y;
            //pi = 3.14;
        }

        public override string ToString()
        {
            return $"x: {x} , y: {y}";
        }

        // class member method [static]  ---> depend on class for calling.
        public static double CmToInch(double cm)
        {
            return cm / 2.54; 
        }

        // static member method [ static] ---> depend on class for calling.
        public static double calcCircleArea(double r)
        {
            return PI * r * r;
        }


    }

}
