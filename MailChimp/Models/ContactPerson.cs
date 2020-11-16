using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.ComponentModel;

namespace MailChimp.Models
{
    [Table("contactpersontable", Schema = "public")]
    public class ContactPerson
    {
        [Key]
        public int personid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }

    }
}