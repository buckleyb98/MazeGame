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

        public MazeGame()
        {
            InitializeComponent();

            _player = new Player();
            _player.CurrentHealthPoints = 10;
            _player.TotalHealthPoints = 10;
            _player.Score = 0;

            lblHealthPoints.Text = _player.CurrentHealthPoints.ToString();
            lblScore.Text = _player.Score.ToString();
        }

        private void MazeGame_Load(object sender, EventArgs e)
        {

        }
    }
}