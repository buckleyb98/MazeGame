using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardGold { get; set; }

        public List<LootItem> LootItems { get; set; }

        public Monster(int id, string name, int maximumDamage, int rewardGold, int currentHealthPoints, int totalHealthPoints)
            : base(currentHealthPoints, totalHealthPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardGold = rewardGold;

            // Add Monster Inventory
            LootItems = new List<LootItem>();
        }
    }
}