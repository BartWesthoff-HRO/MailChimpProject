using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.ComponentModel;

namespace MailChimp.Models
{
    [Table("logintable", Schema = "public")]
    public class Employee
    {
        [Key]
        public int userid { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage ="Je moet een naam invullen")]
        public string username { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Je moet een wachtwoord invullen")]
        public string password { get; set; }
    }
}