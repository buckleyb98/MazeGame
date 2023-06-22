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

        public bool HasRequiredEntryItem(Room room)
        {
            if (room.EntryItemRequired == null)
            {
                return true;
            }

            foreach (InventoryItem ii in Inventory)
            {
                if (ii.Details.ID == room.EntryItemRequired.ID)
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasThisQuest(Quest quest)
        {
            foreach (QuestLog questLog in Quests)
            {
                if (questLog.Details.ID == quest.ID)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CompletedThisQuest(Quest quest)
        {
            foreach (QuestLog questLog in Quests)
            {
                if (questLog.Details.ID == quest.ID)
                {
                    return questLog.IsCompleted;
                }
            }

            return false;
        }

        public bool HasAllQuestItems(Quest quest)
        {
            foreach (QuestItem qi in quest.QuestItem)
            {
                bool itemFoundInInventory = false;

                foreach (InventoryItem ii in Inventory)
                {
                    if (ii.Details.ID == qi.Details.ID)
                    {
                        itemFoundInInventory = true;

                        if (ii.Quantity < qi.Quantity)
                        {
                            return false;
                        }
                    }
                }

                if (!itemFoundInInventory)
                {
                    return false;
                }
            }

            return true;
        }
    }
}