namespace TP01Module02
{
    internal class Carre : Forme
    {
        public int Longueur { get; set; }

        public void Texte()
        {
            System.Console.WriteLine($"Carré de coté={Longueur}");
        }

        public void Aire()
        {
            double aire = Longueur * Longueur;
            System.Console.WriteLine($"Aire = {aire}");
        }

        public void Perimetre()
        {
            double perimetre = 4 * Longueur;
            System.Console.WriteLine($"Périmètre = {perimetre}");
        }


    }
}