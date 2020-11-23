using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MailChimp.Models
{

    [Table("contactpersontable", Schema = "public")]
    public class klant
    {
        [Key]
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Bedrijfsnaam { get; set; }
    }
}