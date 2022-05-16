using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varosok
{
    class Varosnevek
    {
        public Varosnevek()
        {

        }

        public void getVarosnevek()
        {
            // bekérjük hány városnevet akar elmenteni majd létrehozzuk a listát
            int szam = 0;
            while (szam == 0)
            {
                szam = Convert.ToInt32(Console.ReadLine());
            }

            List<string> cities = new List<string>(szam);

            //hozzáadjuk a listához az bekért városneveket
            for (int i = 0; i < szam; i++)
            {
                string varosnev = Console.ReadLine();
                cities.Insert(i, varosnev);
            }

            //kiírjuk a városneveket
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            //városnév keresés
            string keresett = Console.ReadLine();
            for (int i = 0; i < cities.Count; i++)
            {
                if (cities[i].Contains(keresett))
                    Console.WriteLine("Igen van benne");
                else
                {
                    Console.WriteLine("Nincs ilyen elem a listában.");
                }
            }

            //városnév törlés, ha nincs akkor hozzáadás 
            string torlesrekeresett = Console.ReadLine();
            for (int i = 0; i < cities.Count; i++)
            {
                if (cities[i].Contains(keresett))
                    cities.RemoveAt(i);
                else
                {
                    cities.Insert(i, torlesrekeresett);
                }
            }

            //utolsó elem törlése
            cities.RemoveAt(szam - 1);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Varosnevek varosnevek = new Varosnevek();
            varosnevek.getVarosnevek();

            Console.ReadKey();
        }
    }
}
