using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Album
    {
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public int Sales { get; set; }
        public DateTime YearsSinceRelease { get; set; }

        public Album(string name, int yearofrelease, int sales)
        {
            Name = name;
            YearOfRelease = yearofrelease;
            Sales = sales;
        }
        public Album()
        {

        }
        public override string ToString()
        {
            YearsSinceRelease = DateTime.Now;
            YearsSinceRelease = YearsSinceRelease.AddYears(-YearOfRelease);
            int CalcYearRelease = YearsSinceRelease.Year;
            return string.Format($"{Name} - {YearOfRelease} With {Sales} Total Sales. Its been {CalcYearRelease} Years since Release");
        }
    }
}
