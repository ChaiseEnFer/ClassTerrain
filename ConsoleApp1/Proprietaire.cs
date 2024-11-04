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
        List<string> Biens;

        public string ToString()
        {
            string toString = String.Format($"Nom : {Nom}\n");
            toString += String.Format($"Prénom : {Prenom}");
            toString += String.Format($"liste des Biens {Biens}\n");

            if (Biens == null) { toString += String.Format("Aucun Biens\n"); }
            return toString;
        }
    }
}
