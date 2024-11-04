using ExemplePOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Piece
    {
        int Superficie;
        string Nom;

        public Piece(int superficie, string nom)
        {
            Superficie = superficie;
            Nom = nom;
        }
        public override string ToString()
        {
            string toString = String.Format($"Nom : {this.Nom}\n");
            toString += String.Format($"Superficie : {this.Superficie}\n");
            return toString;
        }
    }
}
