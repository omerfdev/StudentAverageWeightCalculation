using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWC_App
{
    internal class GirlStudent:Student
    {
        public GirlStudent(string name, int weight) : base(name, weight, "Female") { }
    }
}
