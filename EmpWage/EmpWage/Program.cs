﻿using System;
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

            EmpWage dMart = new EmpWage("DMart", 20, 2, 10);
            EmpWage reliance = new EmpWage("Reliance", 10, 4, 10);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
            Console.ReadLine();
        }
    }
}
