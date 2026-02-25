namespace GLS_CLI1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("GLS.txt");
            List<AutoAdatok> autoLista = new List<AutoAdatok>();
            foreach (var item in adatok)
            {
                autoLista.Add(new AutoAdatok(item));
            }

            Console.WriteLine($"Az autó használatban töltött napjainak száma: {autoLista.Count()}");

            HashSet<string> soforok = new HashSet<string>();
            foreach (var item in autoLista)
            {
                soforok.Add(item.sofNev);
            }
            Console.WriteLine($"Különböző sofőrok száma: {soforok.Count()}");

            int km = autoLista.Sum(x => x.napiKilometer);
            Console.WriteLine($"Az összes megtett kilométer: {km} km");
        }
    }
}
