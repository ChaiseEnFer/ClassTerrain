using System;
using System.Text.RegularExpressions;

namespace ExemplePOO
{
    public class Terrain
    {
        public string Adresse;
        public float Superficie;
        public int NbCotesClotures;
        public bool Riviere;

        public Terrain(string adresse, float superficie, int nbPieces, bool jardin)
        {
            Adresse = adresse;
            Superficie = superficie;
            NbCotesClotures = nbPieces;
            Riviere = jardin;
        }

        public override string ToString()
        {
            string toString = String.Format("Adresse = {0}\n", this.Adresse);
            toString += String.Format("Superficie = {0}m²\n", this.Superficie);
            toString += String.Format("Nombre de pièces = {0}\n", this.NbCotesClotures);
            toString += String.Format("Présence d'un jardin = {0}\n", this.Riviere ? "Oui" : "Non");
            toString += String.Format("> VALEUR = {0}$", this.EvaluationValeur());

            return toString;
        }

        public float EvaluationValeur()
        {
            int facteur = 3000;

            if (this.Riviere) { facteur += 500; }
            if (this.NbCotesClotures > 3) { facteur += 200; }

            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.Adresse, @"\bLyon\b")) { facteur += 2000; }

            return this.Superficie * facteur;
        }

        public int CoutFinirCloture()
        {
            return 5;
        }

    }
}