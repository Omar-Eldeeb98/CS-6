using CS_6.Abstraction;
//using CS_6.Casting_Operators_Overloading;
using CS_6.Operators_Overloading;
using CS_6.Partial;
using CS_6.Static;
using System.Drawing;
using Rectangle = CS_6.Abstraction.Rectangle;


namespace CS_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Operators overloading.

            #region Binary operators - overloading.

            //Complex complex1 = new Complex()
            //{
            //    real = 3,
            //    imaginary = 5
            //};

            //Console.WriteLine(complex.ToString()); // 3 + 5!



            //Complex complex2 = new Complex()
            //{

            //    real = 2,
            //    imaginary = 4
            //};


            //Console.WriteLine(complex2.ToString()); // 2+ 4i
            //Console.WriteLine("----------");

            //Complex complex3 = complex + complex2; 
            //Console.WriteLine(complex3.ToString()); // 5 + 9i

            //Console.WriteLine("\n");

            //Console.WriteLine("----------");
            //Complex complex4 = complex - complex2;
            //Console.WriteLine(complex4.ToString()); // 1 + 1i


            //Complex c = default; // null
            //c += complex;
            //Console.WriteLine(c.ToString()); // 3 + 5i
            #endregion


            #region Unary operators - overloading.


            //Complex complex1 = new Complex()
            //{
            //    real = 3,
            //    imaginary = 5
            //};





            //Complex complex2 = new Complex()
            //{

            //    real = 2,
            //    imaginary = 4
            //};



            //complex2 = ++complex1; // ++ (3 + 5i)
            //Console.WriteLine(complex2.ToString()); // 4 + 5i



            //complex2 = --complex1; // -- (3 + 5i)
            //Console.WriteLine(complex2.ToString()); // 2 + 5i

            #endregion



            #region Relational operators - overloading.


            //Complex c1 = new Complex()
            //{
            //    real = 3,
            //    imaginary = 5
            //};

            //Complex c2 = new Complex()
            //{
            //    real = 2,
            //    imaginary = 4
            //};


            //Complex c3 = default; // null 


            //if(c1>c2)
            //{
            //    Console.WriteLine("c1 greater than c2");
            //}
            //else if(c2 > c1)
            //{
            //    Console.WriteLine("c2 greater than c1");
            //}





            #endregion



            #endregion


            #region Casting Operators overloading.

            //object obj = 2; // boxing

            //int x = (int) obj; // explicit casting, unsafe casting.
            //Console.WriteLine(x); // 2


            //Complex complex = new Complex() { real = 2,imaginary = 4};
            //int y = (int) complex;

            //Console.WriteLine(complex.ToString()); // 2 + 4i
            //Console.WriteLine(y);                  // 2


            //string s = (string) complex;
            //Console.WriteLine($"s: {s}"); // s: 2 + 4i



            //Employee employee = new Employee()
            //{
            //    id = 1,
            //    fullName = "Omar Eldeeb",
            //    email = "Omar123@email.com",
            //    password = "password123",
            //    securityStamp = Guid.NewGuid(), 

            //};


            //EmployeeView employeeView = new EmployeeView();
            //employeeView = (EmployeeView) employee;

            //Console.WriteLine(employeeView.fName); // Omar
            //Console.WriteLine(employeeView.lName); // Eldeeb
            //Console.WriteLine(employeeView.email); // Omar123@email.com


            #endregion


            #region Abstraction



            //Rectangle rectangle = new Rectangle()
            //{
            //dimention1 = 10,
            //dimention2 = 30,
            //};

            //Console.WriteLine("area of rectangle:" + rectangle.calcArea()); //300
            //Console.WriteLine("perimeter of rectangle: " + rectangle.calcPerimeter()); // 80
            //Console.WriteLine("\n");



            //Square square = new Square(10);
            //Console.WriteLine("square area: " + square.calcArea());             // square area: 100
            //Console.WriteLine("square perimeter: " + square.calcPerimeter());   // square perimeter: 40
            //Console.WriteLine("\n");


            //Circle circle = new Circle(30);
            //Console.WriteLine("circle area: " + circle.calcArea());           // circle area: 2826.00
            //Console.WriteLine("circle perimeter: " + circle.calcPerimeter()); // circle perimeter: 188.40
            //Console.WriteLine("\n");





            #endregion


            #region Static

            // [static]   ---> class member.
            // [non static] ----> object member.

            //Utility u1 = new Utility(10, 20);
            //Console.WriteLine($"cm to inch : {u1.CmToInch(254)}"); // cm to inch : 100

            //Console.WriteLine($"cm to inch : {Utility.CmToInch(254)}"); 
            // cm to inch : 100
            // انا بخلى ال method static لو القيمة بناعتها مش معتمدة على object 


            /* Console.WriteLine(Utility.calcCircleArea(10));*/ // output: 314



            #endregion


            #region Partial

            //Employee employee = new Employee();
            //employee.id = 10;
            //employee.name = "Omar";
            //employee.age = 30;
            //employee.test = 100;
            //employee.print();





            #endregion


        }
    }
}
