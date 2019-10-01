using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antik_Prov
{
    class Book
    {
        //allt som ska kommer användas inom denna klass
        //pris
        public int price;
        //namn på olika böcker
        private List<string> name = new List<string>() { "yeetus", "Deletus", "Holy", "Tomeire", "Grimoire" };
        //olika kategorier
        private List<string> category = new List<string>() { "book", "old book", "Holy book", "Tome", "Grimoire" };
        //sällsynhet
        private int rarity;
        //den riktga värde
        private int actualValue;
        //förbannelse?
        private bool cursed;
        //en random generator
        private Random generator = new Random();
        //vilken egenskaper boken har
        public Book()
        {
            actualValue = generator.Next(101);

            rarity = generator.Next(6);

            //vet inte hur man random ut från en lista och få det fungera
            Console.WriteLine(name.Count);

            Console.WriteLine(category.Count);
        }
        //den här kommer visa spelaren vilka egenskaper boken har
        public void PrintInfo()
        {
            Console.WriteLine(actualValue);

            Console.WriteLine(rarity);

            Console.WriteLine(name.Count);

            Console.WriteLine(category.Count);
        }
        //räkna ut priset, som jag inte vet hur man gör än, ej klar
        public int Evaluate()
        {
         float price = Math.Abs(actualValue * rarity);


        }
        //Returnerar om boken är cursed eler inte, ej klar
        public bool IsCursed()
        {

        }
    }
}
