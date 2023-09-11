class Program
{
    static void Main()
    {

        //Prvi zadatak

        while (true)
        {
            Console.Write("Unesite broj ili 'x' za izlaz:");
            string unos = Console.ReadLine();

            if (unos.ToLower() == "x")
            {
                Console.WriteLine("Pritisnuli ste x za izlaz");
                break;
            }

            if (int.TryParse(unos, out int number))
            {
                int square = number * number;
                Console.WriteLine("Kvadrat broja " + number + " je " + square);
            }
            else
            {
                Console.WriteLine("Nije unet ispravan broj. Unesete broj ili 'x' za izlaz.");
            }
        }



        //Drugi zadatak




        {
            Console.Write("Unesite pozitivan broj n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                PrintFibonacciNumbers(n);
            }
            else
            {
                Console.WriteLine("Unesite ispravan pozitivan broj.");
            }
        }

        static void PrintFibonacciNumbers(int n)
        {
            int a = 0;
            int b = 1;

            Console.WriteLine("Prvih " + n + " brojeva u Fibonacci nizu:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine();
        }





        //Treci zadatak

        {
            Console.Write("Unesi broj n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                List<int> numbers = Enumerable.Range(1, 10).ToList();

                var deljiviBrojevi = numbers.Where(x => x % n == 0);

                Console.WriteLine($"Brojevi iz liste koji su deljivi sa {n}: {string.Join(", ", deljiviBrojevi)}");
            }
            else
            {
                Console.WriteLine("Nije unet validan broj.");
            }
        }

    }
}


//Cetvrti ,peti,sesti zadatak

public enum Pol
{
    Muski,
    Zenski
}

public class Osoba
{
    public string Ime { get; set; }
    public int Starost { get; set; }
    public Pol Pol { get; set; }

    public Osoba(string ime, int starost, Pol pol)
    {
        Ime = ime;
        Starost = starost;
        Pol = pol;
    }
}

class Zadatak456
{
    static void Main()
    {
        List<Osoba> osobe = new List<Osoba>
        {
            new Osoba("Marko", 30, Pol.Muski),
            new Osoba("Ana", 25, Pol.Zenski),
            new Osoba("Ivan", 27, Pol.Muski),
            new Osoba("Milica",40,Pol.Zenski)
        };

        List<Osoba> sortiraneOsobe = osobe.OrderByDescending(os => os.Starost).ToList();


        foreach (var osoba in sortiraneOsobe)
        {
            Console.WriteLine($"Ime: {osoba.Ime}, Starost: {osoba.Starost}, Pol: {osoba.Pol}");
        }

        var grupisaneOsobe = from osoba in osobe
                             group osoba by osoba.Pol into grupa
                             select new
                             {
                                 Pol = grupa.Key,
                                 Osobe = grupa.Select(o => new { Ime = o.Ime, Starost = o.Starost }).ToList()
                             };

        foreach (var grupa in grupisaneOsobe)
        {
            Console.WriteLine($"Pol: {grupa.Pol}");

            foreach (var osoba in grupa.Osobe)
            {
                Console.WriteLine($"Ime: {osoba.Ime}, Starost: {osoba.Starost}");
            }

            Console.WriteLine();
        }
    }
}
