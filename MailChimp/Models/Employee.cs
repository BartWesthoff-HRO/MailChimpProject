using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.ComponentModel;

namespace MailChimp.Models
{
    [Table("medewerker", Schema = "public")]
    public class Employee : Persoon
    {
        [Key]
        public int medewerkerid { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage ="Je moet een naam invullen")]
        public string gebruikersnaam { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Je moet een wachtwoord invullen")]
        public string wachtwoord { get; set; }
    }
}