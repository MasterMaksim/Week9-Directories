using System;
using System.IO;

namespace shoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\admin\samples";
            string newDirectory = @"shoppingList";
            string fileName = @"myShoppingList.txt";

            Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
            File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
        }
    }
}
