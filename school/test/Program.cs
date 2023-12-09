namespace SnailRace1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rennschnecke w = new Rennschnecke("Hildegard", "Weinbergschnecke", new Random().Next(5, 11));
            Rennschnecke n = new Rennschnecke("Herbert", "Nacktschnecke", new Random().Next(5, 11));
            Rennschnecke z = new Rennschnecke("Hubert", "Zimtschnecke", new Random().Next(5, 11));
            Rennen spielberg = new Rennen("Spielbergring", 8, 100);

            spielberg.AddRennschnecke(w);
            spielberg.AddRennschnecke(n);
            spielberg.AddRennschnecke(z);

            Console.WriteLine(spielberg);

            //spielberg.RemoveRennschnecke("Herbert");
            //Console.WriteLine(spielberg);

            //Console.WriteLine(w.ToString());
            //w.Krieche();
            //Console.WriteLine(w);

            spielberg.Durchfuehren();

            Console.WriteLine(spielberg);

            Console.WriteLine("Gewinner: " + spielberg.ErmittleGewinner());
        }
    }
}