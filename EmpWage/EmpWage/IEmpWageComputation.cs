﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal interface IEmpWageComputation
    {
        //Interface
        
        
            void AddCompany(string company, int wagePrHrs, int totalWorkHrs, int totalWorkDay);
            void GetWage();
        
    }
}
