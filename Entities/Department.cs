using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Entities
{
    internal class Department
    {
        //  By Annotation
        [Key]
        public int Dept_id { get; set; }


        [Required]
        [StringLength(50)]
        public string Name { get; set; }


        [NotMapped]
        public int Ins_id { get; set; }


        public DateTime Hire_Date { get; set; }

    }
}
