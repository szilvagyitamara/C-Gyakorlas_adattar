using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*rjunk programot, mely a testsúly és a testmagasság alapján meghatározza a testtömegindexet, és kiírja, hogy milyen testsúly osztályba tartozik az adott illető. a testtömeg osztályokat meghatározhatjuk tetszőlegesen,
            de alapul vehetünk létező osztályozásokat is.*/
            Console.Write("Testtömeg[kg]:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Testmagasság[cm]:");
            double h = double.Parse(Console.ReadLine());
            h = h / 100;
            double tti = m / Math.Pow(h,2);
            Console.WriteLine("Testtömegindex: {0}",tti);
            Console.Write("Testsúlyosztály:");
            if (tti < 16) Console.WriteLine("Súlyos soványság");
            else if (tti < 17) Console.WriteLine("Mérsékelt soványság");
            else if (tti < 18.5) Console.WriteLine("Enyhe soványság");
            else if (tti < 25) Console.WriteLine("Normális testsúly");
            else if (tti < 30) Console.WriteLine("Túlsúlyos");
            else Console.WriteLine("Elhizás");
            Console.ReadLine();
        }
    }
}
