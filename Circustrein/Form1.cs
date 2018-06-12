using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {
        static List<Dier> Dieren = new List<Dier>()
        /*{
            new Dier("Lion", Dier.eten.Vlees, Dier.formaat.Middelmatig),
            new Dier("Kat", Dier.eten.Vlees,Dier.formaat.Klein),
            new Dier("Dog", Dier.eten.Vlees, Dier.formaat.Middelmatig),
            new Dier("Bird", Dier.eten.Planten, Dier.formaat.Klein),
            new Dier("Eleph", Dier.eten.Planten, Dier.formaat.Groot)

        }*/;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_toevoegen_Click(object sender, EventArgs e)
        {
           
        }
    
        private void btn_verdelen_Click(object sender, EventArgs e)
        {
            List<Wagon> wagons = refill(Dieren);
            foreach (var item in wagons)
            {
                listBox1.Items.Add(item.Id);
                foreach (var dier in item.dieren)
                {
                    listBox1.Items.Add(dier.Naam + " - " + dier.Eten + " - " + dier.Formaat);
                }

            }
        }

        private static List<Wagon> refill(List<Dier> dieren)
        {
            List<Wagon> newwagon = new List<Wagon>();

            foreach (var item in dieren)
            {
               
                if (!item.Check)
                {
                    Wagon wagon = new Wagon { Id = GetIdForNewWagon(newwagon) };
                    foreach (var dier in dieren)
                    {
                        if (!dier.Check)
                        {
                            wagon = DierToevogen(wagon, dier);
                        }

                    }
                    newwagon.Add(wagon);
                }
               
                
            }


            return newwagon;
        }

        private static Wagon DierToevogen(Wagon wagon, Dier dier)
        {
            if (GetPuntenFromWagon(wagon, dier) + dier.punten <= 10)
            {
                if (Isvalid(wagon, dier))
                {
                    wagon.dieren.Add(dier);
                    dier.Check = true;
                }

            }
            return wagon;
        }

        private static bool Isvalid(Wagon wagon, Dier dier)
        {
            if (wagon.dieren != null)
            {
                foreach (var item in wagon.dieren)
                {
                    if (item.Eten == Dier.eten.Vlees)
                    {
                        if (item.Formaat == Dier.formaat.Middelmatig)
                        {
                            if (dier.Formaat == Dier.formaat.Groot && dier.Eten == Dier.eten.Planten)
                            {
                                return true;
                            }
                            return false;
                        }
                        if (item.Formaat == Dier.formaat.Klein)
                        {
                            if (dier.Formaat == Dier.formaat.Middelmatig && dier.Eten == Dier.eten.Planten || dier.Formaat == Dier.formaat.Klein && dier.Eten == Dier.eten.Planten)
                            {
                                return true;
                            }
                            return false;
                        }

                    }
                    return true;
                }
            }
            return true;
        }

        private static int GetPuntenFromWagon(Wagon wagon, Dier dier)
        {
            int punt = 0;
            if (wagon.dieren != null)
            {
                foreach (var item in wagon.dieren)
                {
                    punt += item.punten;
                }
                return punt;
            }
            return 0;

        }

        private static int GetIdForNewWagon(List<Wagon> newwagon)
        {
            if (!IsEmbty(newwagon))
            {
                return newwagon.Count() + 1;
            }
            return 1;
        }

        private static bool IsEmbty(List<Wagon> newwagon)
        {
            if (newwagon.Count() == 0)
            {
                return true;
            }
            return false;
        }
    }
}
