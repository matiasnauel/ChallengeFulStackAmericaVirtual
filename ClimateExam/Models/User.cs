using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClimateExam.Models
{
    [Table("User", Schema = "dbo")]
    public partial class User
    {
        [Key]
        public int IdUser { get; set; }
        [Display(Name = "Nombre de usuario")]
        public string NameUser { get; set; }
        [Display(Name = "Clave de usuario")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Active { get; set; }
    }
}
