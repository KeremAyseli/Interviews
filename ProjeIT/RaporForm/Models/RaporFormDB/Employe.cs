using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace RaporForm.Models.RaporFormDB
{
    [Table("Employe")]
    public class Employe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int FormId { get; set; }
        [Required]
        public int EmployeType { get; set; }
        public string EmployeTypeImgUrl { get; set; }
    }
}
