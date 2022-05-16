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
            Console.WriteLine("Hány városnevet szeretne?");
            int szam = 0;
            while (szam == 0)
            {
                szam = Convert.ToInt32(Console.ReadLine());
            }

            List<string> cities = new List<string>(szam);

            //hozzáadjuk a listához az bekért városneveket
            Console.WriteLine("Írja be a városok nevét!");
            for (int i = 0; i < szam; i++)
            {
                string varosnev = Console.ReadLine();
                cities.Insert(i, varosnev);
            }

            //kiírjuk a városneveket
            Console.WriteLine("A beírt városok neve:");
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine(cities[i]);
            }

            //városnév keresés
            Console.WriteLine("Most írjon be egy városnevet amire szeretne keresni,hogy szerepel-e a listán");
            string keresett = Console.ReadLine();
            for (int i = 0; i < cities.Count; i++)
            {
                if (cities[i].Contains(keresett))
                    Console.WriteLine("Igen van benne");
                else
                {
                    if (i == szam - 1)
                    {
                        Console.WriteLine("Nincs ilyen elem a listában.");
                    }
                    
                }
            }

            //városnév törlés, ha nincs akkor hozzáadás 
            Console.WriteLine("Írja be a törölni kívánt város nevét, illetve ha új várost szeretne hozzáadni akkor azt.");
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
