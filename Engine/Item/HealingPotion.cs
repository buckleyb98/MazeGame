﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int HealAmount { get; set; }

        public HealingPotion(int id, string name, string namePlural, int healAmount) : base(id, name, namePlural)
        {
            HealAmount = healAmount;
        }
    }
}