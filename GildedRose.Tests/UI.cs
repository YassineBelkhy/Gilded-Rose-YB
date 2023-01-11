using System;
using GildedRose;
using GildedRose.Items;
using GildedRose.Tests;

namespace GildedRose
{
    internal class NewBaseType
    {
        void Main()
        {

            Console.WriteLine("1-afficher les articles");
            Console.WriteLine("2-afficher le solde du magasin");
            Console.WriteLine("3-lancer une mise à jour des articles");
            Console.WriteLine("4-Vendre un article ");

            Console.Write("Choose");

            int option = int.(Console.ReadLine());
            int result = 0;

            Console.Clear();

            switch (option)
            {
                case 1:
                    result = DisplayInventory();

                case 2:
                    result = DisplayBalance();

                case 3:
                    result = UpdateQuality();

                case 4:
                    result = SellItem(String type, int quality);
                    


            }

            Console.Clear();
        }

        
    }

    class UI : NewBaseType
    {
  Static
    }
}