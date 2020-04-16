using lv1analiza.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv1analiza
{
    //1 i 2.zad 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DiceRoller roller = new DiceRoller();
    //        Die[] myDie = new Die[20];

    //        for(int i = 0; i < 20; i++)
    //        {
    //            Random randomSides = new Random();
    //            Random randomRollValue = new Random();
    //            myDie[i] = new Die(randomSides.Next(1, 6), randomRollValue.Next(1, 6));
    //            roller.AddDie(myDie[i]);
    //        }

    //        roller.RollAllDice();
    //        List<int> rollingresults = roller.GetRollingResults();
    //        foreach(int value in rollingresults)
    //        {
    //            Console.WriteLine(value);
    //        }
            
    //        Console.ReadLine();
    //    }
    //}

    //3.zad
    class Program
    {
        static void Main(string[] args)
        {
            DiceRoller roller = new DiceRoller();
            Die[] myDie = new Die[20];

            for (int i = 0; i < 20; i++)
            {
                Random randomSides = new Random();
                myDie[i] = new Die(randomSides.Next(1, 6));
                roller.AddDie(myDie[i]);
            }

            roller.RollAllDice();
            List<int> rollingresults = roller.GetRollingResults();
            foreach (int value in rollingresults)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}
