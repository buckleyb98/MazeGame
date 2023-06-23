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
        public const int ROOM_ID_ROOM = 2;
        public const int ROOM_ID_ROOM_ONE = 3;
        public const int ROOM_ID_ROOM_TWO = 4;
        public const int ROOM_ID_ROOM_THREE = 5;
        public const int ROOM_ID_BEFORE_BOSS_ROOM = 6;
        public const int ROOM_ID_BOSS_ROOM = 7;
        public const int ROOM_ID_EXIT = 8;


        // Monsters
        public const int MONSTER_ID_GOBLIN = 1;
        public const int MONSTER_ID_TROLL = 2;
        public const int MONSTER_ID_DRAGON = 3;

        // Quests
        public const int QUEST_ID_ESCAPE_MAZE = 1;

        static Maze()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateRooms();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_SWORD, "Sword", "Swords", 0, 5));

            Items.Add(new Potion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 3));

            Items.Add(new Item(ITEM_ID_MAZE_KEY, "Maze key", "Maze keys"));

            // Will create 'Treasure' class for these items
            Items.Add(new Item(ITEM_ID_GOLD, "Gold", "Gold"));
            Items.Add(new Item(ITEM_ID_DIAMOND, "Diamond", "Diamonds"));
        }

        private static void PopulateMonsters()
        {
            Monster goblin = new Monster(MONSTER_ID_GOBLIN, "Goblin", 2, 5, 5, 5);
            goblin.LootItems.Add(new LootItem(ItemByID(ITEM_ID_HEALING_POTION), 50));

            Monster troll = new Monster(MONSTER_ID_TROLL, "Troll", 5, 10, 8, 8);
            troll.LootItems.Add(new LootItem(ItemByID(ITEM_ID_DIAMOND), 10));

            Monster dragon = new Monster(MONSTER_ID_DRAGON, "Dragon", 8, 20, 15, 15);
            dragon.LootItems.Add(new LootItem(ItemByID(ITEM_ID_MAZE_KEY), 100));

            Monsters.Add(goblin);
            Monsters.Add(troll);
            Monsters.Add(dragon);
        }

        private static void PopulateQuests()
        {
            Quest escapeMaze = new Quest(QUEST_ID_ESCAPE_MAZE,
                "Escape the Maze",
                "You are trapped in a Maze and must find a way out. Find the Key and the Exit Room.", 50);
            escapeMaze.QuestItem.Add(new QuestItem(ItemByID(ITEM_ID_MAZE_KEY), 1));

            Quests.Add(escapeMaze);
        }

        private static void PopulateRooms()
        {
            Room entrance = new Room(ROOM_ID_ENTRANCE, "Maze Entrance", "The first room of the Maze. It is dark and quiet.",
                null, null, null);

            Room room = new Room(ROOM_ID_ROOM, "Green Room", "A room like any other in the maze. What will you find?", 
                null, QuestByID(QUEST_ID_ESCAPE_MAZE), MonsterByID(MONSTER_ID_GOBLIN));

            Room roomOne = new Room(ROOM_ID_ROOM_ONE, "Blue Room", "A room like any other in the maze. What will you find?",
                null, null, null);

            Room roomTwo = new Room(ROOM_ID_ROOM_TWO, "Red Room", "A room like any other in the maze. What will you find?", 
                null, null, MonsterByID(MONSTER_ID_TROLL));

            Room roomThree = new Room(ROOM_ID_ROOM_THREE, "Yellow Room", "A room like any other in the maze. What will you find?",
                null, null, null);

            Room beforeBossRoom = new Room(ROOM_ID_BEFORE_BOSS_ROOM, "Near Boss Room", "You hear a low rumble and smell smoke... something is close.",
                null, null, null);

            Room bossRoom = new Room(ROOM_ID_BOSS_ROOM, "Boss Room", "A red Dragon stands tall in the middle of the room. Good luck!",
                null, null, MonsterByID(MONSTER_ID_DRAGON));

            Room exit = new Room(ROOM_ID_EXIT, "Maze Exit", "The final room of the Maze. Congratulations for completing the Maze.", 
                ItemByID(ITEM_ID_MAZE_KEY), QuestByID(QUEST_ID_ESCAPE_MAZE), null);

            entrance.RoomToNorth = room;
            entrance.RoomToEast = roomOne;
            entrance.RoomToWest = roomTwo;

            room.RoomToNorth = roomThree;
            room.RoomToEast = room;
            room.RoomToSouth = entrance;
            room.RoomToWest = roomOne;

            roomOne.RoomToNorth = roomTwo;
            roomOne.RoomToEast = room;
            roomOne.RoomToSouth = roomThree;
            roomOne.RoomToWest = entrance;

            roomTwo.RoomToNorth = room;
            roomTwo.RoomToEast = entrance;
            roomTwo.RoomToSouth = roomOne;
            roomTwo.RoomToWest = roomThree;

            roomThree.RoomToNorth = roomOne;
            roomThree.RoomToEast = roomTwo;
            roomThree.RoomToSouth = room;
            roomThree.RoomToWest = beforeBossRoom;

            beforeBossRoom.RoomToNorth = bossRoom;
            beforeBossRoom.RoomToEast = entrance;
            beforeBossRoom.RoomToSouth = room;
            beforeBossRoom.RoomToWest = room;

            bossRoom.RoomToNorth = exit;
            bossRoom.RoomToSouth = beforeBossRoom;

            Rooms.Add(entrance);
            Rooms.Add(room);
            Rooms.Add(roomOne);
            Rooms.Add(roomTwo);
            Rooms.Add(roomThree);
            Rooms.Add(beforeBossRoom);
            Rooms.Add(bossRoom);
            Rooms.Add(exit);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Room RoomByID(int id)
        {
            foreach (Room room in Rooms)
            {
                if (room.ID == id)
                {
                    return room;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }
    }
}
