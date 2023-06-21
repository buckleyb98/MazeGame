using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Maze
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Room> Rooms = new List<Room>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();

        // Items
        public const int ITEM_ID_SWORD = 1;
        public const int ITEM_ID_HEALING_POTION = 2;
        public const int ITEM_ID_MAZE_KEY = 3;
        public const int ITEM_ID_GOLD = 4;
        public const int ITEM_ID_DIAMOND = 5;

        // Rooms
        public const int ROOM_ID_ENTRANCE = 1;
        public const int ROOM_ID_EXIT = 2;
        public const int ROOM_ID_BOSS_ROOM = 3;
        public const int ROOM_ID_ROOM = 4;

        // Monsters
        public const int MONSTER_ID_GOBLIN = 1;
        public const int MONSTER_ID_TROLL = 2;
        public const int MONSTER_ID_DRAGON = 3;

        // Quests
        public const int QUEST_ID_ESCAPE_MAZE = 1;

        static Maze()
        {
            PopulateItems();
            PopulateRooms();
            PopulateMonsters();
            PopulateQuests();
        }

        public static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_SWORD, "Sword", "Swords", 0, 5));

            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 3));

            Items.Add(new Item(ITEM_ID_MAZE_KEY, "Maze key", "Maze keys"));

            // Will create 'Treasure' class for these items
            //Items.Add(new Item(ITEM_ID_GOLD, "Gold", "Gold"));
            //Items.Add(new Item(ITEM_ID_DIAMOND, "Diamond", "Diamonds"));
        }

        public static void PopulateRooms()
        {
            Room entrance = new Room(ROOM_ID_ENTRANCE, "Maze Entrance", "The first room of the Maze. It is dark and quiet.");

            Room room = new Room(ROOM_ID_ROOM, "Basic Room", "A room like any other in the maze. What will you find?");
            
            Room exit = new Room(ROOM_ID_EXIT, "Maze Exit", "The final room of the Maze. Congratulations for completing the Maze.");
            
            Room bossRoom = new Room(ROOM_ID_BOSS_ROOM, "Boss Room", "A loud growl and a puff of smoke as you enter the room. A Dragon lies here."); 
        }

        public static void PopulateMonsters()
        {
            Monster goblin = new Monster(MONSTER_ID_GOBLIN, "Goblin", 2, 5, 5, 5);

            Monster troll = new Monster(MONSTER_ID_TROLL, "Troll", 5, 10, 8, 8);

            Monster dragon = new Monster(MONSTER_ID_DRAGON, "Dragon", 8, 20, 15, 15);
        }

        public static void PopulateQuests()
        {
            Quest escapeMaze = new Quest(QUEST_ID_ESCAPE_MAZE, 
                "Escape the Maze", 
                "You are trapped in a Maze and must find a way out. Find the Key and the Exit Room.", 50);
        }
    }
}
