using System;
using System.Collections.Generic;
using System.Text;

namespace Simkezelo
{
    public class Kartyakezelo
    {
        private List<KartyaSim> kartyalista;
        public Kartyakezelo()
        {
            kartyalista = new List<KartyaSim>();
        }

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
            Console.WriteLine("Az ön sorszáma: " + ks.sorszam);
            Console.WriteLine("Az ön egyenlege: " + ks.egyenleg);
            Console.WriteLine("Az ön PIN kódja: " + ks.pin[0]+ ks.pin[1]+ ks.pin[2]+ ks.pin[3]);

        }

        public void aktivalas()
        {
            KartyaSim ks=new KartyaSim();
            Console.WriteLine("Add meg a kártyád sorszámát!");
            int sorszam = int.Parse(Console.ReadLine());
            int i = 0;
            //ez csak egy megjegyzés

           
                while (i < 3 && ks.a == false)
                {
                    
                    Console.WriteLine("Add meg a PIN kódot a kártya aktiválásához!");
                    int[] pbe = new int[4];
                    for (int j = 0; j < pbe.Length; j++)
                    {
                        int rekord = int.Parse(Console.ReadLine());
                        pbe[j] = rekord;
                    }
                    if (pbe == ks.pin)
                    {
                        ks.a = true;
                        Console.WriteLine("Pin jelszó aktiválása sikeres");
                    }


                }
            

        }
    }
}
