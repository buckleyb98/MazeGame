using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
        public int TotalHealthPoints { get; set; }
        public int CurrentHealthPoints { get; set; }

        public LivingCreature(int currentHealthPoints, int totalHealthPoints)
        {
            CurrentHealthPoints = currentHealthPoints;
            TotalHealthPoints = totalHealthPoints;
        }
    }
}