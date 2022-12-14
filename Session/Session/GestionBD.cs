using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    internal class GestionBD
    {
        private MySqlConnection con;
        ObservableCollection<SPT> tableSPT;
        ObservableCollection<Trajets> tableTrajet;
        static GestionBD gestionBD = null;

        public GestionBD()
        {
            //this.con = new MySqlConnection("Server=cours.ceget3r.info;Database=session;Uid=2140149;Pwd=2140149;");
            this.con = new MySqlConnection("Server=localhost;Database=final;Uid=root;Pwd=root;");
            tableSPT = new ObservableCollection<SPT>();
            tableTrajet = new ObservableCollection<Trajets>();
        }

        public static GestionBD getInstance()
        {
            if (gestionBD == null)
                gestionBD = new GestionBD();

            return gestionBD;
        }



        //Afficher les données de la table spt

        public ObservableCollection<SPT> getSPT()
        {
            tableSPT.Clear();

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "Select * from spt";

            con.Open();
            MySqlDataReader r = commande.ExecuteReader();

            while (r.Read())
            {

                SPT c = new SPT()
                {
                    NoApp = r.GetInt32("noApp"),
                    PourcentageSPT = r.GetDouble("pourcentageSPT")
                };
                tableSPT.Add(c);
            }
            r.Close();
            con.Close();

            return tableSPT;
        }


        //Afficher les données de la table trajet

        public ObservableCollection<Trajets> getTrajet()
        {
            tableTrajet.Clear();

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "Select * from trajet";

            con.Open();
            MySqlDataReader r = commande.ExecuteReader();

            while (r.Read())
            {

                Trajets c = new Trajets()
                {
                    NoTrajet = r.GetInt32("noTrajet"),
                    HeureDepart = r.GetString("heureDepart"),
                    HeureArrivee = r.GetString("heureArrivee"),
                    VilleDepart = r.GetString("villeDepart"),
                    VilleArrivee = r.GetString("villeArrivee"),
                    Date = r.GetString("date"),
                    Arret = r.GetString("arret"),
                    Vehicule = r.GetString("vehicule"),
                    NoApp = r.GetInt32("noApp")
                };
                tableTrajet.Add(c);
            }
            r.Close();
            con.Close();

            return tableTrajet;
        }
    }
}
