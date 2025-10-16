namespace media_intervallo
{
    internal class Program
    {
        static double mediaIntervallo(int n1, int n2)
        {
            int z = 0, s = 0;
            double m = 0;
            while (n1 <= n2)
            {

                if (n1 % 2 == 0)
                {
                    n1++;
                }
                else
                {
                    z++;
                    s = s + n1;
                    m = s / z;
                    n1 = n1 + 2;
                }
            }
            Console.WriteLine(m + " questa e la media");
            return m;

        }
        static int fattoriale(int a)
        {
            int mol = 1;
            for (int i = 1; i >= 1; i--)
            {
                mol = mol * i;
            }
            Console.WriteLine(mol + " questo e il fattoriale");
            return mol;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("dammi l'inizio del l'intervallo");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dammi la fine del l'intervallo");
            int n2 = Convert.ToInt32(Console.ReadLine());
            mediaIntervallo(n1, n2);
            Console.WriteLine("dammi un numero");
            int a = Convert.ToInt32(Console.ReadLine());
            fattoriale(a);


        }
    }
}
