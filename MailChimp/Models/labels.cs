using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.ComponentModel;


namespace MailChimp.Models
{
    [Table("labels", Schema = "public")]
    public class labels
    {
        [Key]
        public int labelid { get; set; }
        public string lname { get; set; }
    }
}