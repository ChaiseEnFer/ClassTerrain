using ExemplePOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Proprietaire
    {
        string Nom;
        string Prenom;
        Bien[] Biens = new Bien[0];

        public Proprietaire(string nom, string prenom, Bien[] biens)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Biens = biens;
        }

        private string ListeBien()
        {
            string listeBien = "";
            foreach (Bien b in this.Biens)
            {
                listeBien += String.Format($"{(b.GetType().Name == "Maison" ? "Une" : "Un")}{b.GetType().Name} {b.Adresse}\n");

            }
            return listeBien;
        }

        public override string ToString()
        {
            string toString = String.Format($"Nom : {this.Nom}\n");
            toString += ListeBien();

            if (Biens == null || Biens.Length == 0) { toString += String.Format("Aucun Biens\n"); }
            return toString;
        }
    }
}
