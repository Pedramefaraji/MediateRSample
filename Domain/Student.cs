using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Student
    {
        [Required]
        [MaxLength(10,ErrorMessage ="حداکثر 1000"),MinLength(1,ErrorMessage ="حداقل 1")]
        public int id { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
    }
}
