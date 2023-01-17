using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Simkezelo
{
    public class Kartyakezelo
    {
        

        public List<int[]> simlista=new List<int[]>();
        

        public void menu ()
        {

            int menupont = 0;
            do
            {
                Console.WriteLine("1: Sim kártya létrehozása");
                Console.WriteLine("2: Aktiválás PIN");
                Console.WriteLine("3: Aktiválás PUK");
                Console.WriteLine("4: Egyenleg lekérdezés");
                Console.WriteLine("5: Kilépés");
                Console.WriteLine("Választott menüpont száma");
                menupont = int.Parse(Console.ReadLine());
                switch (menupont)
                {
                    case 1:
                        ujKartya();
                        
                        break;
                    case 2:
                        aktivalas();
                        break;
                    

                }
            } while (menupont!=5);
        }
        private void ujKartya()
        {
            Console.WriteLine("Itt lesz a kártyahozzáadás");
            KartyaSim ks = new KartyaSim();
            
            ks.Sorszam();
            ks.Egyenleg();
            ks.PIN();
            ks.adatfeltoltes(ks.sorszam, ks.egyenleg, Convert.ToInt32(ks.pin));
            simlista.Add(ks.kartyak);
            Console.WriteLine("Az Ön sorszáma: " + ks.kartyak[0] +"\n"+"Az Ön egyenlege: " + ks.kartyak[1] +"\n"+"Az Ön PIN kódja: " + ks.kartyak[2]);

            /*int[] abc = simlista[0];
            for (int i = 0; i < abc.Length; i++)
            {
                Console.WriteLine(abc[i]);
            }*/
            System.Console.WriteLine(simlista[0].GetLength(0));
        }

        public void aktivalas()
        {
            KartyaSim ks=new KartyaSim();

            int i = 0;
            while (i<3 || ks.a==false)

            {
                
                Console.WriteLine("Add meg a kártyád sorszámát!");
                int sorszam = int.Parse(Console.ReadLine());
                Console.WriteLine("Add meg a kártyád PIN kódját!");
                int bepin = int.Parse(Console.ReadLine());
                for (int j = 0; j < simlista[j].Length; j++)
                {
                    if ((sorszam == simlista[j][0]) && (bepin == simlista[j][2]))
                    {
                        ks.a = true;
                        Console.WriteLine("PIN aktiválás sikeres \nÜgyi vagy! :)");
                    }

                    else
                    {
                        
                        
                        Console.WriteLine("Az általad megadott valamely érték nem egyezik");

                    }


                
                }

                i++;

            }

        }
    }
}
