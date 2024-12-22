namespace Set3Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu un numar n: ");
            int n = int.Parse(Console.ReadLine());

            bool[] prim = CiurulErastosten(n);
            Console.WriteLine($"Numerele prime pana la {n} sunt: ");
            for(int i = 2; i < n; i++)
            {
                if(prim[i])
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        static bool[] CiurulErastosten(int n)
        {
            bool[] prim = new bool[n+1];

            for(int i = 2; i <= n; i++)
            {
                prim[i] = true;
            }
            for(int p = 2; p*p <= n; p++)
            {
                if (prim[p])
                {
                    for(int multiplu = p*p; multiplu <= n; multiplu += p)
                    {
                        prim[multiplu] = false;
                    }
                }
            }
            return prim;    
        }
    }
}
