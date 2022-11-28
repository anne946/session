using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    internal class Passager
    {

        int idP;
        string nom;
        string prenom;
        string courriel;
        string motDePasse;
        string noTelephone;
        int noTrajet;
        int prix;
        string immatriculation;

        public int IdP { get => idP; set => idP = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Courriel { get => courriel; set => courriel = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }
        public string NoTelephone { get => noTelephone; set => noTelephone = value; }
        public int NoTrajet { get => noTrajet; set => noTrajet = value; }
        public int Prix { get => prix; set => prix = value; }
        public string Immatriculation { get => immatriculation; set => immatriculation = value; }

        public override string ToString()
        {
            return idP + "\n"
                + nom + "\n"
                + prenom + "\n"
                + courriel + "\n"
                + motDePasse + "\n"
                + noTelephone + "\n"
                + noTrajet + "\n"
                + prix + "\n"
                + immatriculation;
        }
    }
}
