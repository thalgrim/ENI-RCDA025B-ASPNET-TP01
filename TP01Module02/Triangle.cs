using System;

namespace TP01Module02
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public void Texte()
        {
            System.Console.WriteLine($"Triangle de coté A={A} B={B} C={C}");
        }

        public void Aire()
        {
            double p = A + B + C / 2;
            double aire = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            System.Console.WriteLine($"Aire = {aire}");
        }

        public void Perimetre()
        {
            double perimetre = A + B + C;
            System.Console.WriteLine($"Périmètre = {perimetre}");
        }

      
    }
}