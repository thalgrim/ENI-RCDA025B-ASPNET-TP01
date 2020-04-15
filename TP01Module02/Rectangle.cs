namespace TP01Module02
{
    internal class Rectangle : Forme
    {
        public int Largeur { get; set; }
        public int Longueur { get; set; }

        public void Texte()
        {
            System.Console.WriteLine($"Rectangle de longueur={Longueur} et largeur={Largeur}");
        }

        public void Aire()
        {
            double aire = Largeur * Longueur;
            System.Console.WriteLine($"Aire = {aire}");
        }

        public void Perimetre()
        {
            double perimetre = 2 * Longueur + 2 * Largeur;
            System.Console.WriteLine($"Périmètre = {perimetre}");
        }

      }
}