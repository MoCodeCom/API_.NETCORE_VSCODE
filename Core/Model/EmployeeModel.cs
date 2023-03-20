using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Model
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; } = 1;
        [Required]
        public string FirstName {get; set;}
        [Required]
        public string LastName { get; set; }
        public string Position {get; set;}
    }
}