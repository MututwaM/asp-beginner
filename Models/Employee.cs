using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mvcdemo.Models
{
    [Table("employee")]
    public class Employee
    {

        public int EmployeeId{get; set;}

        public String Name { get; set;}
        public String Gender { get; set;}
        public String City { get; set;}

  

    }
}
