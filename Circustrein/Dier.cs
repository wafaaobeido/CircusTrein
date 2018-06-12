using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Dier
    {
        public string Naam { get; set; }
        public eten Eten { get; set; }
        public formaat Formaat { get; set; }
        public bool Check { get; set; }
        public bool IsAllowed { get; set; }
        public enum eten { Vlees,Planten };
        public enum formaat { Klein ,Middelmatig ,Groot };
        public int punten {
            get
            {
                if (Formaat == Dier.formaat.Groot) return 5;
                else if (Formaat == Dier.formaat.Klein) return 1;
                else if (Formaat == Dier.formaat.Middelmatig) return 3;
                return 0;
            }
        }

        public Dier()
        {

        }
        
        public Dier(string naam, eten eten, formaat formaat)
        {
            this.Naam = naam;
            this.Eten = eten;
            this.Formaat = formaat;
        }
        
    }
}
