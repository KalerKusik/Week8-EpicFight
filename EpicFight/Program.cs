using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villain = PickVillain();
            Console.WriteLine($"{hero} will fight {villain}");

            string heroWeapon = PickWeapon();
            string villainWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}. {villain} picked {villainWeapon}.");
        }

        private static string PickHero()
        {
            string[] superHeroes = { "Epic Games", "LinusTechTips", "Obama", "The Rock", "toemad"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeroes.Length);

            return superHeroes[randomIndex];
        }

        private static string PickVillain()
        {
            string[] superVillains = { "Apple", "Your Mom", "John Xina", "A Nuclear Warhead", "Steven"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superVillains.Length);

            return superVillains[randomIndex];
        }

        private static string PickWeapon()
        {
            string[] weapon = { "Cheese", "AmogOS", "A Your Mom Joke", "360 Noscope", "Crack Cocaine" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, weapon.Length);

            return weapon[randomIndex];
        }

    }
}
