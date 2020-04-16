using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv1analiza.components
{
    //3.zad
    //class DiceRoller
    //{
    //    private List<Die> dice;
    //    private List<int> resultForEachRoll;
    //    private Logger logger;

    //    public DiceRoller()
    //    {
    //        this.dice = new List<Die>();
    //        this.resultForEachRoll = new List<int>();
    //        this.logger = new Logger("Console", null);
    //    }

    //    public void AddDie(Die die)
    //    {
    //        dice.Add(die);
    //    }

    //    public void RollAllDice()
    //    {
    //        this.resultForEachRoll.Clear();
    //        foreach(Die die in dice)
    //        {
    //            this.resultForEachRoll.Add(die.rollDie());
    //        }
    //    }

    //    public List<int> GetRollingResults()
    //    {
    //        return resultForEachRoll;
    //    }

    //    public int DiceCount
    //    {
    //        get { return dice.Count; }
    //    }

    //    public void LogRollingResults()
    //    {
    //        foreach (int result in this.resultForEachRoll)
    //        {
    //            logger.Log(result.ToString());
    //        }
    //    }
    //}

    //4.zad
    //class DiceRoller
    //{
    //    private List<Die> dice;
    //    private List<int> resultForEachRoll;
    //    private ILogger logger;

    //    public DiceRoller()
    //    {
    //        this.dice = new List<Die>();
    //        this.resultForEachRoll = new List<int>();
    //        this.logger = null;
    //    }

    //    public void AddDie(Die die)
    //    {
    //        dice.Add(die);
    //    }

    //    public void RollAllDice()
    //    {
    //        this.resultForEachRoll.Clear();
    //        foreach (Die die in dice)
    //        {
    //            this.resultForEachRoll.Add(die.rollDie());
    //        }
    //    }

    //    public List<int> GetRollingResults()
    //    {
    //        return resultForEachRoll;
    //    }

    //    public int DiceCount
    //    {
    //        get { return dice.Count; }
    //    }

    //    public void SetLogger(ILogger iLogger)
    //    {
    //        this.logger = iLogger;
    //    }

    //    public void LogRollingResults()
    //    {
    //        foreach (int result in this.resultForEachRoll)
    //        {
    //            logger.Log(result.ToString());
    //        }
    //    }
    //}

    class DiceRoller : ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        private ILogger logger;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            this.logger = null;
        }

        public void AddDie(Die die)
        {
            dice.Add(die);
        }

        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.rollDie());
            }
        }

        public List<int> GetRollingResults()
        {
            return resultForEachRoll;
        }

        public int DiceCount
        {
            get { return dice.Count; }
        }

        public void SetLogger(ILogger iLogger)
        {
            this.logger = iLogger;
        } 

        public string GetStringRepresentation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (int result in this.resultForEachRoll)
            {
                stringBuilder.Append(result.ToString()).Append("\n");
            }
            return stringBuilder.ToString();
        }
    }
}
