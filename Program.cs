using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci_kontrola_toka_programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prvi zadatak

            Console.WriteLine("Upisi te jednu recenicu");
            string recenica = Console.ReadLine();
            if(recenica.Length > 5) {
                string recenica2 = recenica.Substring(2, recenica.Length-4);
                Console.WriteLine(recenica2);
            }
            else
            {
                Console.WriteLine(recenica);
            }
            Console.ReadKey();

            //Drugi zadatak

            int x, y, z;
            Console.WriteLine("Upisi te duljinu stranica 2 katete te hipotenuze: ");
            x = Convert.ToInt16(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            if(x == 0 || y == 0 || z == 0)
            {
                Console.WriteLine("Jedan ili vise upisa je 0 ");
            }
            else
            {
                if(x*x + y*y == z * z)
                {
                    Console.WriteLine("Trokut je pravokutan");
                }
                else
                {
                    Console.WriteLine("Trokut nije pravokutan");
                }
            }

            Console.ReadKey();

            //treci zadatak

            Console.WriteLine("Upisi te broj:");
            int broj = Convert.ToInt32(Console.ReadLine());
            if(broj % 4 == 0)
            {
                if(broj % 6 == 0)
                {
                    Console.WriteLine("Broj je djeljiv sa 4 i sa 6");
                }
                else
                {
                    Console.WriteLine("Broj je dijeljiv s 4");
                }
            }
            else if(broj % 6 == 0)
            {
                Console.WriteLine("Broj je dijeljiv s 6");
            }
            else
            {
                Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6");
            }
            
            Console.ReadKey();

            //Cetvrti zadatak

            Console.WriteLine("Upisi te cijenu sa i bez pdvom (decimalni brojevi se pisu zarezom):");
            double pdv = Convert.ToDouble(Console.ReadLine()), ne_pdv = Convert.ToDouble(Console.ReadLine());
            double postotak = (pdv - ne_pdv) / ne_pdv * 100;
            Console.WriteLine("Iznos PDV-a je: " + postotak + "%");

            Console.ReadKey();

        }
    }
}
