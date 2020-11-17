using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MailChimp.Models
{
    public class ContactPersoon : Persoon
    {
        private int contactpersoonid { get; set; }
        public string bedrijfsnaam { get; set; }


        public List<string> GetLabels(Kenmerk[] kenmrkn, Label[] lbls)
        {
            /*lijst maken voor de labelnamen*/
            List<string> labels = new List<string>();
            /*door alle kenmerken heen gaan*/
            for(int i = 0; i < kenmrkn.Length; i++)
            {
                /*toevoegen aan de labelnamen*/
                if(kenmrkn[i].labelid == lbls[i].labelid)
                {
                    labels.Add(lbls[i].labelname);
                }
            }
            /*indien een persoon geen label heeft dan is er niets*/
            if(labels.Count == 0)
            {
                return null;
            }
            /*terug geven van alle labels die bij een persoon horen*/
            return labels;
        }
        
    }
}