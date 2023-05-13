using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC_App
{
    internal class MenStudent:Student
    {
        public MenStudent(string name, int weight) : base(name, weight, "Male") { }
    }
}
