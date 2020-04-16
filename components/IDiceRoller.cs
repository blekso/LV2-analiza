﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv1analiza.components
{
    interface IDiceRoller
    {
        void InsertDie(Die die);
        void RemoveAllDice();
        void RollAllDice();
    }
}
