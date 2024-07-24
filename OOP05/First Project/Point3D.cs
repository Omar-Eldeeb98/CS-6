using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.First_Project
{
    internal class Point3D : IComparable , ICloneable
    {

        // properties.
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }



        // constructors.
        public Point3D() : this(0.0 , 0.0, 0.0)   // default constructor
        {

        }
        public Point3D(double x, double y, double z)  // Constructor with three parameters
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D(double x, double y) : this(x, y, 0.0) // Constructor with two parameters (x, y)
        {

        }

       

        public Point3D(double x) : this(x, 0.0, 0.0) // Constructor with one parameter (x)
        {

        }

        // methods
        public override string ToString()
        {
            return $"Point Coordinates: ({X} , {Y} , {Z})";
        }


        private static bool tryParseCoordinate(string input , out double coordinate)
        {
            if(double.TryParse(input , out coordinate))
            {
                return true;
            }
            else
            {
                 coordinate = 0.0;
                return false;
            }
           
        }


        // Method to read and validate a single coordinate
        private static double readCoordinate(string coordinateName)
        {
            double coordinate;
            bool flag;

            do
            {
                Console.WriteLine($"enter coordinate: {coordinateName} ");
                string input = Console.ReadLine();
                flag = tryParseCoordinate(input, out coordinate);
                if (!flag)
                {
                    Console.WriteLine($"Invalid {coordinateName} . Please try again.");
                }

            } while (!flag);

            return coordinate;
        }


        // Method to read coordinates from user
        public static  Point3D ReadPoint()
        {
            double x = readCoordinate("X");
            double y = readCoordinate("Y");
            double z = readCoordinate("Z");
            return new Point3D(x, y, z);
        }

        public static Point3D _ReadPoint()
        {
            double x = readCoordinate("X");
            double y = readCoordinate("Y");
           
            return new Point3D(x, y);
        }



        public int CompareTo(object? obj)
        {

            Point3D point3D = (Point3D) obj;
            if(point3D is not null)
            {
                return 1;
            }
            int result = X.CompareTo(point3D.X);
            if(result == 0)
            {
                result = Y.CompareTo(point3D.Y);
            }
            return result;

           
        }

        public object Clone()
        {
            return new Point3D(X , Y , Z);
        }

        // (==) overload
        public static bool operator == (Point3D p1, Point3D p2)
        {
         if (p1.X == p2.X && p1.Y == p2.Y && p1.Y == p2.Y)
            {
                Console.WriteLine($"{p1.ToString()} = {p2.ToString()}");
                return true;
            }
         else
                Console.WriteLine("P1 is not equal P2");
            return false;
        }

        // Overload != operator
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }



    }
}
