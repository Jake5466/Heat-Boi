using System;
using System.Security.Cryptography.X509Certificates;

namespace heat
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = 1;
            double t = .1;
            double k = 1;
            double n = 10;
            double m = 50;
            double dx = l / n;
            double dt = t / m;
            double a = (k * dt) / (dx * dx);
            double[] x = new double[12];
            double[] f = new double[12];
            double[] ff = new double[12];
            f[11] = 0;
            ff[11] = 0;
            ff[0] = 0;
            for (int i = 0; i <= n+1; i++)
            {x[i] = (i) * dx;
                Console.WriteLine(x[i]);
            }
            for (int o = 0; o <= n+1; o++)
            {
                f[o] =Math.Abs(Math.Sin(3.14159*(x[o])));
                Console.WriteLine(f[o]);
            }
            for (int u = 1; u <= m; u++)
            {
                for (int p = 1; p <= n; p++)
                {
                    ff[p] = f[p] + a * (f[p + 1] - 2 * f[p] + f[p - 1]);
                    Console.WriteLine(ff[p - 1]);
                    ff[0] = 0;
                    ff[11] = 0;
                }
                ff = f;
            }
            for(int y = 0;y <=11; y++)
            { Console.WriteLine(ff[y]); }
            Console.WriteLine("Heat Solver Done");
            Console.ReadLine();
        }
        
    }
}
