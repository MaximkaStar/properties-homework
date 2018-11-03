using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            int rate;
            WriteLine("Please, enter a rate of solid: ");
            int.TryParse(ReadLine(), out rate);
  
            Random randomizer = new Random();
            Solid solid = new Solid();
            int maxRateOfRandom = 100;
            for(int i = 0; i < rate; i++)
            {
                solid[i] = randomizer.Next(maxRateOfRandom);
                WriteLine("{0}", solid[i]);
            }
            ReadLine();
        }
    }
}
