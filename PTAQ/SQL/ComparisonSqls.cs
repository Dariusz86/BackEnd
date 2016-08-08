using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.SQL
{
    static class ComparisonSqls
    {
        public static string CountFromGivenTable = @"Select NationalIDNumber, LoginId, JobTitle From [HumanResources].[Employee]
                                                    Where JobTitle = '{0}' And BirthDate = '{1}' And Gender = 'M'";
        public const string Top20Employees = "Select TOP 20 * From [HumanResources].[Employee]";
    }
}
