using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class Employee
    {
        public static Boolean CheckEmpDate(string dateofjoining)
        {
            return (Convert.ToDateTime(dateofjoining).Year < 2018);
        }
        public static Double CalculateSalary(double salary)
        {
            return (salary*1.1);
        }
    }
}
