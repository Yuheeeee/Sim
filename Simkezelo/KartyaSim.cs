using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Simkezelo
{
    public class KartyaSim

    {
        public bool a = false;
        public int sorszam;
        public string pin;
       

        public int egyenleg;
        public Kapcsolatok[] kapcsolatok = new Kapcsolatok[20];
        public int[] kartyak=new int[3];

        public void pinkezelo()
        {
            
            
        }

        public void adatfeltoltes(int adat1,int adat2,int adat3)
        {
            int i=0;
            kartyak[i] = new int();
            kartyak[0] = adat1;
            kartyak[1] = adat2;
            kartyak[2] = adat3;





        }

        public int Sorszam()
        {
            int sorszam1;
            Console.WriteLine("A kártya sorszáma: ");
            sorszam1 = int.Parse(Console.ReadLine());
            sorszam = sorszam1;
            return sorszam1;
        }

        public int Egyenleg ()
        {
            int egyenleg1;
            Console.WriteLine("Mennyivel töltsük fel az egyenleged?");
            //egyenleg1 = int.Parse(Console.ReadLine());
            egyenleg1 = int.Parse(Console.ReadLine());
            egyenleg += egyenleg1;
            return egyenleg1;
        }

        public void PIN()
        {
            int[] pinKod = new int[4];
            Random rnd = new Random();
            for (int i = 0; i<pinKod.Length; i++)
            {
                pinKod[i]=rnd.Next(0, 9);
                
            }

            
            foreach (var i in pinKod)
            {
                pin += i;
            }
            
            
            
    }
        

    }
}
