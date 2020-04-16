using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv1analiza.components
{

    //6.zad
    //class FlexibleDiceRoller : IRoll, IDiceManager
    //{
    //    private List<Die> dice;
    //    private List<int> resultForEachRoll;
    //    public FlexibleDiceRoller()
    //    {
    //        this.dice = new List<Die>();
    //        this.resultForEachRoll = new List<int>();
    //    }
    //    public void InsertDie(Die die)
    //    {
    //        dice.Add(die);
    //    }
    //    public void RemoveAllDice()
    //    {
    //        this.dice.Clear();
    //        this.resultForEachRoll.Clear();
    //    }
    //    public void RollAllDice()
    //    {
    //        this.resultForEachRoll.Clear();
    //        foreach (Die die in dice)
    //        {
    //            this.resultForEachRoll.Add(die.rollDie());
    //        }
    //    }
    //}

    class FlexibleDiceRoller : IRoll, IDiceManager
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }
        public void InsertDie(Die die)
        {
            dice.Add(die);
        }
        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }
        public void RemoveDiceWithSides(int sides)
        {
            for (int i = 0; i < dice.Count; i++)
            {
                if (dice[i].NumberOfSides == sides)
                {
                    dice.RemoveAt(i);

                    --i;
                }
            }
        }
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.rollDie());
            }
        }
    }
}
