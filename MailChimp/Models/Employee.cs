using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace MailChimp.Models
{
    [Table("logintable", Schema = "public")]
    public class Employee
    {
        [Key]
        public int userid { get; set; }
        public string username { get; set; }
        public string password { get; set; }       
    }
}