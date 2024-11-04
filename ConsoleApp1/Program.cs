using System;

namespace ExemplePOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Terrain UnTerrain = new Terrain("11 Rue des Chartreux, 69001 Lyon", 58f, 4, false);
            Terrain UnAutreTerrain = new Terrain("4 place Saint Louis, 22100 Dinan", 86.5f, 5, true);
            Terrain UnDernierTerrain = new Terrain("26 Boulevard Claude Lorrin, 40100 Dax", 25.2f, 2, false);

            Terrain[] CatalogueTerrains = new Terrain[] { UnTerrain, UnAutreTerrain, UnDernierTerrain };

            foreach (Terrain M in CatalogueTerrains)
            {
                Console.WriteLine(M);
            }
        }
    }
}