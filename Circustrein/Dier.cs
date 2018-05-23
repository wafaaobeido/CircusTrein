using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Dier
    {
        public string naam;
        public enum eten { Vlees,Planten };
        public eten eet { get; set; }
        public enum formaat { Klein,Middelmatig,Groot };
        public formaat dierformaat { get; set; }

        public Dier()
        {

        }


    }
}
