using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    internal class Chauffeur
    {
        int idC;
        string nom;
        string prenom;
        string courriel;
        string motDePasse;
        string noTelephone;
        double revenus;
        string immatriculation;
        int noApp;

        public int IdC { get => idC; set => idC = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Courriel { get => courriel; set => courriel = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }
        public string NoTelephone { get => noTelephone; set => noTelephone = value; }
        public double Revenus { get => revenus; set => revenus = value; }
        public string Immatriculation { get => immatriculation; set => immatriculation = value; }
        public int NoApp { get => noApp; set => noApp = value; }

        public override string ToString()
        {
            return idC + "\n"
                + nom + "\n"
                + prenom + "\n"
                + courriel + "\n"
                + motDePasse + "\n"
                + noTelephone + "\n"
                + revenus + "\n"
                + immatriculation + "\n"
                + noApp;
        }
    }
}
