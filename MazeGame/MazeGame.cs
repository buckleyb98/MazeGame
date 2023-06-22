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
        private Monster _currentMonster;
        private Room _currentRoom;

        public MazeGame()
        {
            InitializeComponent();

            rtbMessages.AppendText("Messages:" + Environment.NewLine + Environment.NewLine);
            rtbRoom.AppendText("Room:" + Environment.NewLine + Environment.NewLine);

            rtbMessages.AppendText("Random Number: " + RandomNumberGenerator.NumberBetween(1, 10));

            // Player Object
            _player = new Player(5, 10, 0);
            _player.Inventory.Add(new InventoryItem(Maze.ItemByID(Maze.ITEM_ID_SWORD), 1));
            _player.Inventory.Add(new InventoryItem(Maze.ItemByID(Maze.ITEM_ID_HEALING_POTION), 1));
          //_player.Inventory.Add(new InventoryItem(Maze.ItemByID(Maze.ITEM_ID_MAZE_KEY), 1));

            _player.Quests.Add(new QuestLog(Maze.QuestByID(Maze.QUEST_ID_ESCAPE_MAZE), false));

            MoveTo(Maze.RoomByID(Maze.ROOM_ID_ENTRANCE));

            lblHealthPoints.Text = _player.CurrentHealthPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblTime.Text = "00:00";
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
            if (!_player.HasRequiredEntryItem(newRoom))
            {
                rtbMessages.AppendText("You require a " + newRoom.EntryItemRequired.Name + " to enter this room." 
                    + Environment.NewLine + Environment.NewLine);
                return;
            }

            _player.CurrentRoom = newRoom;

            btnNorth.Visible = (newRoom.RoomToNorth != null);
            btnEast.Visible = (newRoom.RoomToEast != null);
            btnSouth.Visible = (newRoom.RoomToSouth != null);
            btnWest.Visible = (newRoom.RoomToWest != null);

            rtbRoom.AppendText(newRoom.Name + Environment.NewLine);
            rtbRoom.AppendText(newRoom.Description + Environment.NewLine + Environment.NewLine);

            if (newRoom.IsQuestHere != null)
            {
                bool playerAlreadyHasQuest = _player.HasThisQuest(newRoom.IsQuestHere);
                bool playerAlreadyCompletedQuest = _player.CompletedThisQuest(newRoom.IsQuestHere);


                if (playerAlreadyHasQuest)
                {
                    if (!playerAlreadyCompletedQuest)
                    {
                        bool playerHasAllQuestItems = _player.HasAllQuestItems(newRoom.IsQuestHere);
                    }
                }
            }

            UpdateUIInventoryLog();
            UpdateUIQuestLog();
            UpdateUIWeapons();
            UpdateUIPotions();
        }

        private void UpdateUIInventoryLog()
        {
            dgvInventory.RowHeadersVisible = false;

            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Inventory";
            dgvInventory.Columns[0].Width = 185;
            dgvInventory.Columns[1].Name = "Quantity";

            dgvInventory.Rows.Clear();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    dgvInventory.Rows.Add(new[] { inventoryItem.Details.Name, inventoryItem.Quantity.ToString() });
                }
            }
        }

        private void UpdateUIQuestLog()
        {
            dgvQuests.RowHeadersVisible = false;

            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Quest";
            dgvQuests.Columns[0].Width = 185;
            dgvQuests.Columns[1].Name = "Completed?";

            dgvQuests.Rows.Clear();

            foreach (QuestLog questLog in _player.Quests)
            {
                dgvQuests.Rows.Add(new[] { questLog.Details.Name, questLog.IsCompleted.ToString() });
            }
        }

        private void UpdateUIWeapons()
        {
            List<Weapon> weapons = new List<Weapon>();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is Weapon)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        weapons.Add((Weapon)inventoryItem.Details);
                    }
                }
            }

            if (weapons.Count == 0)
            {
                cboWeapons.Visible = false;
                btnUseWeapon.Visible = false;
            }
            else
            {
                cboWeapons.DataSource = weapons;
                cboWeapons.DisplayMember = "Name";
                cboWeapons.ValueMember = "ID";

                cboWeapons.SelectedIndex = 0;
            }
        }

        private void UpdateUIPotions()
        {
            List<Potion> potions = new List<Potion>();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is Potion)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        potions.Add((Potion)inventoryItem.Details);
                    }
                }
            }

            if (potions.Count == 0)
            {
                cboPotions.Visible = false;
                btnUsePotion.Visible = false;
            }
            else
            {
                cboPotions.DataSource = potions;
                cboPotions.DisplayMember = "Name";
                cboPotions.ValueMember = "ID";

                cboPotions.SelectedIndex = 0;
            }
        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;

            int playerDamage = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);

            _currentMonster.CurrentHealthPoints -= playerDamage;

            rtbMessages.AppendText("You dealt " + playerDamage.ToString() + " damage to " + _currentMonster.Name + "." + Environment.NewLine);

            if (_currentMonster.CurrentHealthPoints <= 0)
            {
                rtbMessages.AppendText(_currentMonster.Name + " defeated!" + Environment.NewLine);

                _player.Gold += _currentMonster.RewardGold;
                rtbMessages.AppendText("You receive " + _currentMonster.RewardGold.ToString() + " gold" + Environment.NewLine);

                List<InventoryItem> lootedItems = new List<InventoryItem>();

                foreach (LootItem lootItem in _currentMonster.LootItems)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropChance)
                    {
                        lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }
                }

                foreach (InventoryItem inventoryItem in lootedItems)
                {
                    _player.AddItemToInventory(inventoryItem.Details);

                    if (inventoryItem.Quantity == 1)
                    {
                        rtbMessages.AppendText("You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine);
                    }
                    else
                    {
                        rtbMessages.AppendText("You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.NamePlural + Environment.NewLine);
                    }
                }

                lblHealthPoints.Text = _player.CurrentHealthPoints.ToString();
                lblGold.Text = _player.Gold.ToString();
                UpdateUIInventoryLog();
                UpdateUIWeapons();
                UpdateUIPotions();

                rtbMessages.Text += Environment.NewLine;

                MoveTo(_player.CurrentRoom);
            }
            else
            {
                int monsterDamage = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

                rtbMessages.AppendText("The " + _currentMonster.Name + " dealt " + monsterDamage.ToString() + " damage to you.");

                _player.CurrentHealthPoints -= monsterDamage;

                lblHealthPoints.Text = _player.CurrentHealthPoints.ToString();

                if (_player.CurrentHealthPoints <= 0)
                {
                    rtbMessages.AppendText("The " + _currentMonster.Name + " has defeated you. Game Over.");

                    MoveTo(Maze.RoomByID(Maze.ROOM_ID_ENTRANCE));
                }
            }
        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            Potion potion = (Potion)cboPotions.SelectedItem;

            _player.CurrentHealthPoints = (_player.CurrentHealthPoints + potion.HealAmount);

            if (_player.CurrentHealthPoints > _player.TotalHealthPoints)
            {
                _player.CurrentHealthPoints = _player.TotalHealthPoints;
            }

            foreach (InventoryItem ii in _player.Inventory)
            {
                if (ii.Details.ID == potion.ID)
                {
                    ii.Quantity--;
                    break;
                }
            }

            rtbMessages.AppendText("You drink a " + potion.Name + ", healing for " + potion.HealAmount + "." + Environment.NewLine);

            int monsterDamage = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

            rtbMessages.AppendText("The " + _currentMonster.Name + " dealt " + monsterDamage.ToString() + " damage to you.");

            _player.CurrentHealthPoints -= monsterDamage;

            lblHealthPoints.Text = _player.CurrentHealthPoints.ToString();

            if (_player.CurrentHealthPoints <= 0)
            {
                rtbMessages.AppendText("The " + _currentMonster.Name + " has defeated you. Game Over.");

                MoveTo(Maze.RoomByID(Maze.ROOM_ID_ENTRANCE));
            }

            lblHealthPoints.Text = _player.CurrentHealthPoints.ToString();
            UpdateUIInventoryLog();
            UpdateUIPotions();
        }
    }
}