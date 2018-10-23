using System;
using System.IO;
using System.Text;

namespace GarysStuff
{
    class Program
    {
        private const string itemsString = "items";
        private const string fileName = "gary.txt";

        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 150; i++)
            {
                var rand = new Random();
                int number = rand.Next(1, 1500);

                Console.Write($"{number.ToString()} {itemsString}");

                stringBuilder.Append($"{number.ToString()} {itemsString} {Environment.NewLine}");

            }

            using(var strm = new StreamWriter(fileName))
            {
                strm.WriteLine(stringBuilder.ToString());
            }
        }
    }
}
