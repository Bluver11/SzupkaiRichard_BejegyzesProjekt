using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SzupkaiRichard_BejegyzesProjekt
{
    class Program
    {
        static List<Bejegyzes> bejegyzes = new List<Bejegyzes>();

        static void Main(string[] args)
        {
            Bejegyzes b1 = new Bejegyzes("Pista", "Nagyon szeretem a kakaót");
            Bejegyzes b2 = new Bejegyzes("János", "Én a tejet is szeretem");
            bejegyzes.Add(b1);
            bejegyzes.Add(b2);

            Feladat1();
            FajlBeolvasas("bejegyzesek.csv");
        }
       private static void Feladat1()
        {
          
            Console.WriteLine("Kérek szépen egy darabszámot:");
            int darab = int.Parse(Console.ReadLine());
            

            if(darab<0)
            {
                Console.WriteLine("Kérlek természetes számot adj meg.");
            }
            else
            {
                Console.WriteLine("Kérlek add meg a bejegyzéseket:");
                while (darab==0)
                {



                    darab--;

                }
            }

        }
        private static void FajlBeolvasas(string fajlnev)
        {
            using (var fileReader = new StreamReader(fajlnev))
            {
                string adatok = "";
                fileReader.ReadLine();
                while (!fileReader.EndOfStream) 
                { 
                string[] bejegyzesek = adatok.Split(';');
                string nev = bejegyzesek[0];
                string tartalom = bejegyzesek[1];
                adatok = fileReader.ReadLine();
                Bejegyzes b = new Bejegyzes(nev,tartalom);
                    bejegyzes.Add(b);
                }
            }
            
            
        }
    
    
    }

}
