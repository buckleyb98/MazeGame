using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item EntryItemRequired { get; set; }
        public Quest IsQuestHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Room RoomToNorth { get; set; }
        public Room RoomToSouth { get; set; }
        public Room RoomToEast { get; set; }
        public Room RoomToWest { get; set; }

        public List<LootItem> LootItems { get; set; }

        public Room(int id, string name, string description, 
            Item entryItemRequired = null, Quest isQuestHere = null, Monster monsterLivingHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            EntryItemRequired = entryItemRequired;
            IsQuestHere = isQuestHere;
            MonsterLivingHere = monsterLivingHere;

            LootItems = new List<LootItem>();
        }
    }
}