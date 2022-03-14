using System;

namespace HWS_Generics_Lesson20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeroesTable<Knight> ht = new HeroesTable<Knight>(4);
            Knight k1 = new Knight();
            Knight k2 = new Knight();
            ht.SetHero(k1,0);
            ht.SetHero(k2, 1);
            Knight k3 = ht[10];

            HeroesTable<Sword> ht1 = new HeroesTable<Sword>(4);
            Sword s1 = new Sword();
            Sword s2 = new Sword();
            ht1.SetHero(s1, 0);
            ht1.SetHero(s2, 1);
            Sword s3 = ht1[10];

            //HeroesTable<Book> ht2 = new HeroesTable<Book>(4);

        }
    }
}
