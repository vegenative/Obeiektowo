using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;
//temat 1 zadanie 6
namespace Finances
{
    namespace Employees
    {
        class Empolyee
        {
            private string job;
            private int workYear;



            public void SetEmployee(string job, int workYear)
            {
                this.job = job;
                this.workYear = workYear;
            }
            public string GetEmplyee()
            {
                return "he is " + job + " he works for " + workYear + " years";
            }
            //temat 1 zadanie 3
            public struct Wage
            {
                public decimal basicWage;
                public decimal bonusWage;
                public decimal otherWage;
            }
            //temat 1 zadanie 4
            public enum Contract
            {
                FullTime,
                PartTime,
                Contract,
            }
            //temat 1 zadanie 5
            public void SetWage(int basicWage, int bonusWage, int otherWage)
            {

            }
            //temat 1 zadanie 5
            public Wage GetWage()
            {
                return new Wage();
            }

        }
    }
}
