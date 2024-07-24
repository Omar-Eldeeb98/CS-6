using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_6.Sealed
{
    internal class Parent
    {
        public virtual void print()
        {
            Console.WriteLine("i am parent.");
        }

    }

    class Child: Parent
    {
        // sealed method
        public sealed override void print()
        {
            Console.WriteLine("i am child.");
        }
    }


    class GrandChild:Child
    {

    }
}
