﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Entities
{
    internal class Student
    {
        // By Convention
        public int id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }

    }
}
