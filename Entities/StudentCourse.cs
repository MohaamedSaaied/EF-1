using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Entities
{
    internal class StudentCourse
    {
        // Class Configration
        public int Stud_id { get; set; }
        public int Course_id { get; set; }
        public double Grade { get; set; }
    }
}
