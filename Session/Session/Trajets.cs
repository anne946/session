using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    internal class Trajets
    {
            int noTrajet;
            string heureDepart;
            string heureArrivee;
            string villeDepart;
            string villeArrivee;
            string date;
            string arret;
            string vehicule;
            int noApp;

            public int NoTrajet { get => noTrajet; set => noTrajet = value; }
            public string HeureDepart { get => heureDepart; set => heureDepart = value; }
            public string HeureArrivee { get => heureArrivee; set => heureArrivee = value; }
            public string VilleDepart { get => villeDepart; set => villeDepart = value; }
            public string VilleArrivee { get => villeArrivee; set => villeArrivee = value; }
            public string Date { get => date; set => date = value; }
            public string Arret { get => arret; set => arret = value; }
            public string Vehicule { get => vehicule; set => vehicule = value; }
            public int NoApp { get => noApp; set => noApp = value; }

            public override string ToString()
            {
                return noTrajet + "\n"
                    + heureDepart + "\n"
                    + heureArrivee + "\n"
                    + villeDepart + "\n"
                    + villeArrivee + "\n"
                    + date + "\n"
                    + vehicule + "\n"
                    + noApp;
            }
        }
}
