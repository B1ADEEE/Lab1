using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Band : IComparable
    {
        public string BandName { get; set; }
        public int YearFormed { get; set; }
        public string Members { get; set; }

        public Band(string bandname,int yearformed,string members)
        {
            BandName = bandname;
            YearFormed = yearformed;
            Members = members;
        }
        public Band()
        {

        }
        public override string ToString()
        {
            return BandName;
        }
        public int CompareTo(object obj)
        {
            Band otherband = obj as Band;
            return this.BandName.CompareTo(otherband.BandName);
        }
    }
}
