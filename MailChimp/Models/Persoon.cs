using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MailChimp.Models
{
    public class Persoon
    {
        public string voornaam { get; set; }
        public string tussenvoegsel { get; set; }
        public string achternaam { get; set; }
        public string email { get; set; }
        private int persoonid { get; set; }
    }
}