using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }
        public Room CurrentRoom { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<QuestLog> Quests { get; set; }

        public Player(int currentHealthPoints, int totalHealthPoints, int gold)
            : base(currentHealthPoints, totalHealthPoints)
        {
            Gold = gold;

            Inventory = new List<InventoryItem>();
            Quests = new List<QuestLog>();
        }
    }
}