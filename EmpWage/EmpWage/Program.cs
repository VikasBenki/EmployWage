using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to EmpWage problem");
            EmpWage employee = new EmpWage();
            employee.MonthlyEmpWage();
            Console.ReadLine();
        }
    }
}
