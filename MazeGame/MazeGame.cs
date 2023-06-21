using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace MazeGame
{
    public partial class MazeGame : Form
    {
        private Player _player;
        private Monster _monster;

        public MazeGame()
        {
            InitializeComponent();

            // Player Object
            _player = new Player(10, 10, 0);
            MoveTo(Maze.RoomByID(Maze.ROOM_ID_ENTRANCE));
            _player.Inventory.Add(new InventoryItem(Maze.ItemByID(Maze.ITEM_ID_SWORD), 1));

            lblHealthPoints.Text = _player.CurrentHealthPoints.ToString();
            lblGold.Text = _player.Gold.ToString();

            // Room Object
            Room room = new Room(1, "Start", "This is the start of the maze", null, null, null);
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentRoom.RoomToNorth);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentRoom.RoomToEast);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentRoom.RoomToSouth);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentRoom.RoomToWest);
        }

        private void MoveTo(Room newRoom)
        {
            _player.CurrentRoom = newRoom;
        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }


    }
}