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
        private Room _room;

        public MazeGame()
        {
            InitializeComponent();

            // Player Object
            _player = new Player(10, 10, 0);

            lblHealthPoints.Text = _player.CurrentHealthPoints.ToString();
            lblGold.Text = _player.Gold.ToString();

            // Room Object
            _room = new Room(1, "Start", "This is the start of the maze");
        }

        private void MazeGame_Load(object sender, EventArgs e)
        {

        }
    }
}