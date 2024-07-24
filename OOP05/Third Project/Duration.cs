using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Third_Project
{
    internal class Duration
    {
        // attributes
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }


        // constructors
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        // Parameterless constructor
        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }
        // Constructor with total seconds
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }


        // methods

        // Helper method to convert Duration to total seconds
        private int ToTotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
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


        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Duration d = (Duration)obj;
            return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
        }

        public override int GetHashCode()
        {
        
            return Hours.GetHashCode() ^ Minutes.GetHashCode() ^ Seconds.GetHashCode();
        }





        // operators overloading
       
        // + overloading
        public static Duration operator +(Duration d1, Duration d2)
        {

            return new Duration()
            {
                Hours = d1.Hours + d2.Hours,
                Minutes = d1.Minutes + d2.Minutes,
                Seconds = d1.Seconds + d2.Seconds
            };    

        }


        // - overloading
        public static Duration operator -(Duration d1, Duration d2)
        {

            return new Duration()
            {
                Hours = d1.Hours - d2.Hours,
                Minutes = d1.Minutes - d2.Minutes,
                Seconds = d1.Seconds - d2.Seconds
            };

        }



        public static Duration operator +(Duration d, int totalSeconds)
        {

            return new Duration((d.ToTotalSeconds() + totalSeconds));
            
           
        }


        // operator (++) overloading method
        public static Duration operator ++(Duration duration)
        {
            return new Duration()
            {
                Hours = duration.Hours,
               Minutes = duration.Minutes + 1,
               Seconds = duration.Seconds
            };
        }

        // operator (--) overloading method
       
        public static Duration operator --(Duration duration)
        {
            return new Duration()
            {
                Hours = duration.Hours,
                
                Minutes = duration.Minutes - 1,
                Seconds = duration.Seconds
            };
        }



        // >
        public static bool operator >(Duration d1, Duration d2)
        {

            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }


        // < 
        public static bool operator <(Duration d1, Duration d2)
        {

            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }

        // >=
        public static bool operator >=(Duration d1, Duration d2)
        {
       

            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }

        // <=
        public static bool operator <=(Duration d1, Duration d2)
        {
         

            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }


         // true, false
        public static implicit operator bool(Duration d)
        {
            return d.ToTotalSeconds() > 0;
        }



        public static explicit operator DateTime(Duration d)
        {            
            DateTime referenceDate = new DateTime();
           
            DateTime resultDate = referenceDate.AddSeconds(d.ToTotalSeconds());

            return resultDate;
        }


    }
}
