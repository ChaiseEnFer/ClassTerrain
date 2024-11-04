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
        List<Bien> Biens;

        public Proprietaire(string nom, string prenom, List<Bien> biens)
        {
            Nom = nom;
            Prenom = prenom;
            Biens = biens;
        }
        public override string ToString()
        {
            string toString = String.Format($"Nom : {this.Nom}\n");
            toString += String.Format($"Prénom : {this.Prenom}");
            toString += String.Format($"liste des Biens {this.Biens}\n");

            if (Biens == null || Biens.Count == 0) { toString += String.Format("Aucun Biens\n"); }
            return toString;
        }
    }
}
