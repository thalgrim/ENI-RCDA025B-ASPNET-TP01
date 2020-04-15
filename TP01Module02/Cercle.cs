using System;

namespace TP01Module02
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public void Texte()
        {
            System.Console.WriteLine($"Cercle de rayon {Rayon}");
        }

        public void Aire() 
        {
            double aire = Rayon * Rayon * Math.PI;
            System.Console.WriteLine($"Aire = {aire}");
        }

        public void Perimetre() 
        {
            double perimetre = 2 * Math.PI * Rayon;
            System.Console.WriteLine($"Périmètre = {perimetre}");
        }

             

    }
}