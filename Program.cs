namespace Ucenik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> Ucenici = new List<Ucenik>();
            int n;

            Console.Write("Unesi broj ucenika: ");
            n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Ucenik u = new Ucenik();
                Ucenici.Add(u);
            }

            Ucenik Max = Ucenici[0];
            foreach (Ucenik u in Ucenici)
            {
                if (u.Prosjek() > Max.Prosjek())
                    Max = u;
            }

            Console.Write("Najbolji ucenik: ");
            Max.Ispis();
        }
    }
}