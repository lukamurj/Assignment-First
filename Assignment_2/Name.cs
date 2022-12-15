using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Name
    {
        public string First { get; set; }
        public string Last { get; set; }
        public Name(string First, string Last)
        {
            this.First = First;
            this.Last = Last;
        }
    }
}
