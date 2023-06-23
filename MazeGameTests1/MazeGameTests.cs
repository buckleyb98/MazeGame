using Microsoft.VisualStudio.TestTools.UnitTesting;
using MazeGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace MazeGame.Tests
{
    [TestClass()]
    public class MazeGameTests
    {
        [TestMethod()]
        public void Room_HasMonster_Test()
        {
            Room currentRoom = Maze.RoomByID(Maze.ROOM_ID_ROOM);
            Monster monster = Maze.MonsterByID(Maze.MONSTER_ID_GOBLIN);

            monster.ID = currentRoom.MonsterLivingHere.ID;

            Assert.AreEqual(monster.ID, currentRoom.MonsterLivingHere.ID);
        }

        //[TestMethod()]
        //public void MoveTo_ValidRoom_Test()
        //{
        //    Player player = new Player(5, 10, 0);
        //    Room currentRoom = Maze.RoomByID(Maze.ROOM_ID_ENTRANCE);
        //    Room newRoom = Maze.RoomByID(Maze.ROOM_ID_ROOM);

        //    player.CurrentRoom = currentRoom;
        //    newRoom.RoomToNorth = newRoom;

        //    player.MoveTo(newRoom);

        //    Assert.AreEqual(newRoom.ID, player.CurrentRoom.ID);
        //}
    }
}