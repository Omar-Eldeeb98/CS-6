using OOP05.First_Project;
using OOP05.Second_Project;
using OOP05.Third_Project;

namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project

            #region 2
            //Point3D p = new Point3D(10, 20, 30);
            //Console.WriteLine(p.ToString());  // Point Coordinates: (10 , 20 , 30)
            #endregion


            #region 3
            //Console.WriteLine("enter coordinates for point 1");
            //Point3D p1 = Point3D.ReadPoint();


            //Console.WriteLine("\n");

            //Console.WriteLine("enter coordinates for point 2");
            //Point3D p2 = Point3D.ReadPoint();


            //Console.WriteLine("\n");

            //Console.WriteLine("----------------------------------");

            //Console.WriteLine($"P1: {p1}");
            //Console.WriteLine($"P2: {p2}");


            //Console.WriteLine("\n");

            #endregion


            #region 4 
            //Console.WriteLine(p1 == p2);
            // Point Coordinates: (1 , 2 , 3) = Point Coordinates: (1 , 2 , 3)
            // True

            #endregion


            #region 5 

            //Console.WriteLine("enter the numbers of Points:");
            //int numsOfPoints;
            //while (!int.TryParse(Console.ReadLine(), out numsOfPoints) || numsOfPoints <= 0)
            //{
            //    Console.WriteLine("Invalid number. Please enter integer number");
            //}
            //Point3D[] arrayPoints = new Point3D[numsOfPoints];

            //for (int i = 0; i < numsOfPoints; i++)
            //{
            //    Console.WriteLine($"enter coordinates for point: {i + 1}");
            //    arrayPoints[i] = Point3D._ReadPoint();
            //}


            //Array.Sort(arrayPoints);

            //Console.WriteLine("points after sort by X and Y coordinates:");

            //foreach (Point3D point in arrayPoints)
            //{
            //    Console.WriteLine(point);
            //}
            #endregion


            #region 6

            //Console.WriteLine("\n");

            //Point3D[] p1 = new Point3D[2]
            //{
            //    new Point3D(1,2,3),
            //    new Point3D(4,5,6)
            //};



            //Point3D[] cloneP = (Point3D[])p1.Clone();

            //Console.WriteLine(p1[1]);    // Point Coordinates: (4 , 5 , 6)
            //Console.WriteLine(cloneP[1]);// Point Coordinates: (4 , 5 , 6)

            #endregion





            #endregion


            #region Second Project


            //int a = 10;
            //int b = 5;

            //Console.WriteLine("Add: " + Maths.Add(a, b));              // Add: 15
            //Console.WriteLine("Subtract: " + Maths.Subtract(a, b));    // Subtract: 5
            //Console.WriteLine("Multiply: " + Maths.Multiply(a, b));    // Multiply: 50
            //Console.WriteLine("Divide: " + Maths.Divide(a, b));        // Divide: 2


            #endregion



            #region Third Project

            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());  // Hours: 1 , Minutes: 10 , Seconds: 15
            //Console.WriteLine("\n");

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString()); // Hours: 1 , Minutes: 0 , Seconds: 0
            //Console.WriteLine("\n");



            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString());  // Hours: 2 , Minutes: 10 , Seconds: 0
            //Console.WriteLine("\n");



            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());   // Minutes: 11, Seconds: 6
            //Console.WriteLine("\n");



            //Duration Du3 = D1 + D2;
            //Console.WriteLine(Du3.ToString()); // Hours: 2, Minutes: 10, Seconds: 15
            //Console.WriteLine("\n");


            //Duration Du3 = D1 +7800;
            //Console.WriteLine(Du3.ToString()); // Hours: 3, Minutes: 20, Seconds: 1
            //Console.WriteLine("\n");



            //Duration Du3 = default;
            //Du3 = Du3 + 666;
            //Console.WriteLine(Du3.ToString()); // Hours: 1, Minutes: 10, Seconds: 15

            //Duration Du3 = new Duration();
            //Du3 = ++D1;
            //Console.WriteLine(Du3.ToString()); // Hours: 1, Minutes: 11, Seconds: 15
            //Console.WriteLine("\n");



            //Duration Du3 = new Duration();
            //Du3 = --D2;
            //Console.WriteLine(Du3.ToString());   // Hours: 1, Minutes: -1, Seconds: 0
            //Console.WriteLine("\n"); 


            //D1 = D1 - D2;
            //Console.WriteLine(D1.ToString());  // Minutes: 10, Seconds: 15
            //Console.WriteLine("\n");


            //Console.WriteLine(D1 > D2);  //True
            //Console.WriteLine("\n");

            //Console.WriteLine(D1 <= D2);  //False
            //Console.WriteLine("\n");



            //Console.WriteLine(D1); // True
            //Console.WriteLine("\n");



            //DateTime dt = (DateTime)D1;
            //Console.WriteLine(dt);  
            //Console.WriteLine("\n");



            #endregion

        }
    }
}
