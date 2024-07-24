using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_6.Casting_Operators_Overloading
{
    internal class EmployeeView
    {


        public string fName { get; set; }
        public string lName { get; set; }

        public string email { get; set; }




        // casting operator 

        public static /*EmployeeView*/ explicit operator EmployeeView(Employee emp)
        {
            string[]? names = emp?.fullName?.Split(" ");
            return new EmployeeView()
            {
                fName = names?.Length > 0 ? names[0] : string.Empty,
                lName = names?.Length > 1 ? names[1] : string.Empty,
                email = emp.email

            };
        }



    }
}
