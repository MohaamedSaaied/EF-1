using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Entities
{
    internal class Instructor
    {
        // By Fluent Api
        public int id { get; set; }
        public string Name { get; set; }
        public int Bouns { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public double HoureRate { get; set; }

    }
}
