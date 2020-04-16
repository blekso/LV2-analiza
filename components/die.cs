using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv1analiza.components
{
    //1.zad
    //class Die
    //{
    //    private int numberOfSides;

    //    public Die(int iNumberOfSides)
    //    {
    //        this.numberOfSides = iNumberOfSides;
    //    }

    //    public int rollDie()
    //    {
    //        Random rand = new Random();
    //        return (rand.Next(1, this.numberOfSides));
    //    }
    //}

    //2.zad
    //class Die
    //{
    //    private int numberOfSides;
    //    private int rolledValue;

    //    public Die(int iNumberOfSides, int iRolledValue)
    //    {
    //        this.numberOfSides = iNumberOfSides;
    //        this.rolledValue = iRolledValue;
    //    }

    //    public int rollDie()
    //    {
    //        return rolledValue;
    //    }
    //}

    class Die
    {
        private int numberOfSides;
        private RandomGenerator rolledValue;

        public Die(int iNumberOfSides)
        {
            this.numberOfSides = iNumberOfSides;
            this.rolledValue = RandomGenerator.GetInstance();
        }

        public int rollDie()
        {
            return rolledValue.NextInt(1,6);
        }
        public int NumberOfSides
        {
            get { return this.numberOfSides; }
        }
    }
}
