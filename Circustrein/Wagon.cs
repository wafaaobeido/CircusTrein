using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Wagon
    {
        private List<Dier> dieren;
        private Dier dier;

        /* Dieren Toevoegen

         Vlees eet => met dieren die groter zijn en eten planten

         Kleine dier = 1 
        Middelgroot = 3       **** Elke wagon Kan maximaal 10 punten
        Grote dieren = 5

         Elke wagon moet optimaal benut zijn. Het is niet toegestaan om elke die in een aparte wagon te plaatsen */

        public Wagon(List<Dier> Dieren)
        {
            this.dieren = Dieren;
        }

        public void toevoegen()
        {

        }


        public bool? VerdeelQuaEtenEnFormaat()
        {
            Dier.eten plant = new Dier.eten();
            Dier.formaat groot = new Dier.formaat();

            if (plant == Dier.eten.Vlees && groot == Dier.formaat.Klein || plant == Dier.eten.Vlees && groot == Dier.formaat.Middelmatig) return true;
            else if (plant == Dier.eten.Vlees && groot == Dier.formaat.Groot) return false;
           

            return null;
        }

        public int VerdeelQuaPunten()
        {
            int punten = 0;
            Dier.formaat format = new Dier.formaat();

            if (format == Dier.formaat.Groot) punten = 5;
            else if (format == Dier.formaat.Klein) punten = 1;
            else if (format == Dier.formaat.Middelmatig) punten = 3;

            return punten;
        }
    }
}
