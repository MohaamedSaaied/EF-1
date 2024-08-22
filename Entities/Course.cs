using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Entities
{
    internal class Course
    {      
        // By DbContext 
        public int id { get; set; }
        public string Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Course(int id,string Duration,string Name,string Description) 
        {

            this.id = id;
            this.Duration = Duration;
            this.Name = Name;
            this.Description = Description;

        }

    }
}
