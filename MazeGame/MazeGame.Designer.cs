namespace MazeGame
{
    partial class MazeGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHealthLabel = new System.Windows.Forms.Label();
            this.lblGoldLabel = new System.Windows.Forms.Label();
            this.lblHealthPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblTimeLabel = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblActionLabel = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.rtbRoom = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHealthLabel
            // 
            this.lblHealthLabel.AutoSize = true;
            this.lblHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblHealthLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHealthLabel.ForeColor = System.Drawing.Color.Black;
            this.lblHealthLabel.Location = new System.Drawing.Point(18, 9);
            this.lblHealthLabel.Name = "lblHealthLabel";
            this.lblHealthLabel.Size = new System.Drawing.Size(54, 19);
            this.lblHealthLabel.TabIndex = 0;
            this.lblHealthLabel.Text = "HP    :";
            this.lblHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGoldLabel
            // 
            this.lblGoldLabel.AutoSize = true;
            this.lblGoldLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGoldLabel.Location = new System.Drawing.Point(18, 29);
            this.lblGoldLabel.Name = "lblGoldLabel";
            this.lblGoldLabel.Size = new System.Drawing.Size(51, 19);
            this.lblGoldLabel.TabIndex = 1;
            this.lblGoldLabel.Text = "Gold :";
            this.lblGoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHealthPoints
            // 
            this.lblHealthPoints.AutoSize = true;
            this.lblHealthPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblHealthPoints.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHealthPoints.ForeColor = System.Drawing.Color.Black;
            this.lblHealthPoints.Location = new System.Drawing.Point(81, 9);
            this.lblHealthPoints.Name = "lblHealthPoints";
            this.lblHealthPoints.Size = new System.Drawing.Size(21, 19);
            this.lblHealthPoints.TabIndex = 2;
            this.lblHealthPoints.Text = "...";
            this.lblHealthPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGold.Location = new System.Drawing.Point(81, 29);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(21, 19);
            this.lblGold.TabIndex = 3;
            this.lblGold.Text = "...";
            this.lblGold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeLabel
            // 
            this.lblTimeLabel.AutoSize = true;
            this.lblTimeLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeLabel.Location = new System.Drawing.Point(18, 49);
            this.lblTimeLabel.Name = "lblTimeLabel";
            this.lblTimeLabel.Size = new System.Drawing.Size(56, 19);
            this.lblTimeLabel.TabIndex = 4;
            this.lblTimeLabel.Text = "Time :";
            this.lblTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(81, 49);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(21, 19);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "...";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActionLabel
            // 
            this.lblActionLabel.AutoSize = true;
            this.lblActionLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActionLabel.ForeColor = System.Drawing.Color.Black;
            this.lblActionLabel.Location = new System.Drawing.Point(694, 535);
            this.lblActionLabel.Name = "lblActionLabel";
            this.lblActionLabel.Size = new System.Drawing.Size(63, 19);
            this.lblActionLabel.TabIndex = 6;
            this.lblActionLabel.Text = "Actions";
            // 
            // cboWeapons
            // 
            this.cboWeapons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboWeapons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboWeapons.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboWeapons.ForeColor = System.Drawing.Color.Black;
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(519, 559);
            this.cboWeapons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(151, 27);
            this.cboWeapons.Sorted = true;
            this.cboWeapons.TabIndex = 7;
            // 
            // cboPotions
            // 
            this.cboPotions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboPotions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPotions.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboPotions.ForeColor = System.Drawing.Color.Black;
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(519, 593);
            this.cboPotions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(151, 27);
            this.cboPotions.Sorted = true;
            this.cboPotions.TabIndex = 8;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUseWeapon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUseWeapon.FlatAppearance.BorderSize = 2;
            this.btnUseWeapon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUseWeapon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUseWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseWeapon.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUseWeapon.ForeColor = System.Drawing.Color.Black;
            this.btnUseWeapon.Location = new System.Drawing.Point(676, 558);
            this.btnUseWeapon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(94, 29);
            this.btnUseWeapon.TabIndex = 9;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = false;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUsePotion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUsePotion.FlatAppearance.BorderSize = 2;
            this.btnUsePotion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUsePotion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUsePotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsePotion.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsePotion.ForeColor = System.Drawing.Color.Black;
            this.btnUsePotion.Location = new System.Drawing.Point(676, 593);
            this.btnUsePotion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(94, 29);
            this.btnUsePotion.TabIndex = 10;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.UseVisualStyleBackColor = false;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNorth.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNorth.FlatAppearance.BorderSize = 2;
            this.btnNorth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnNorth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNorth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNorth.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNorth.ForeColor = System.Drawing.Color.Black;
            this.btnNorth.Location = new System.Drawing.Point(550, 355);
            this.btnNorth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(94, 29);
            this.btnNorth.TabIndex = 11;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = false;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSouth.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSouth.FlatAppearance.BorderSize = 2;
            this.btnSouth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSouth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSouth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSouth.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSouth.ForeColor = System.Drawing.Color.Black;
            this.btnSouth.Location = new System.Drawing.Point(550, 420);
            this.btnSouth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(94, 29);
            this.btnSouth.TabIndex = 12;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = false;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnWest.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWest.FlatAppearance.BorderSize = 2;
            this.btnWest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnWest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWest.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWest.ForeColor = System.Drawing.Color.Black;
            this.btnWest.Location = new System.Drawing.Point(440, 385);
            this.btnWest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(94, 29);
            this.btnWest.TabIndex = 13;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = false;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEast.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEast.FlatAppearance.BorderSize = 2;
            this.btnEast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEast.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEast.ForeColor = System.Drawing.Color.Black;
            this.btnEast.Location = new System.Drawing.Point(658, 385);
            this.btnEast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(94, 29);
            this.btnEast.TabIndex = 14;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = false;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // rtbRoom
            // 
            this.rtbRoom.BackColor = System.Drawing.Color.DimGray;
            this.rtbRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbRoom.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbRoom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtbRoom.Location = new System.Drawing.Point(440, 88);
            this.rtbRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbRoom.Name = "rtbRoom";
            this.rtbRoom.ReadOnly = true;
            this.rtbRoom.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbRoom.Size = new System.Drawing.Size(312, 189);
            this.rtbRoom.TabIndex = 15;
            this.rtbRoom.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AccessibleName = "";
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.GridColor = System.Drawing.Color.Black;
            this.dgvInventory.Location = new System.Drawing.Point(18, 88);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 51;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvInventory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvInventory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SaddleBrown;
            this.dgvInventory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvInventory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInventory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            this.dgvInventory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInventory.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowTemplate.Height = 29;
            this.dgvInventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInventory.ShowEditingIcon = false;
            this.dgvInventory.Size = new System.Drawing.Size(312, 189);
            this.dgvInventory.TabIndex = 17;
            this.dgvInventory.TabStop = false;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeColumns = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvQuests.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvQuests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Garamond", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuests.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.EnableHeadersVisualStyles = false;
            this.dgvQuests.GridColor = System.Drawing.Color.Black;
            this.dgvQuests.Location = new System.Drawing.Point(18, 284);
            this.dgvQuests.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.RowHeadersWidth = 51;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuests.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvQuests.RowTemplate.Height = 29;
            this.dgvQuests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvQuests.ShowEditingIcon = false;
            this.dgvQuests.Size = new System.Drawing.Size(312, 113);
            this.dgvQuests.TabIndex = 18;
            this.dgvQuests.TabStop = false;
            // 
            // rtbMessages
            // 
            this.rtbMessages.BackColor = System.Drawing.Color.DimGray;
            this.rtbMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessages.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbMessages.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtbMessages.Location = new System.Drawing.Point(18, 421);
            this.rtbMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMessages.Size = new System.Drawing.Size(312, 200);
            this.rtbMessages.TabIndex = 16;
            this.rtbMessages.Text = "";
            // 
            // MazeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbRoom);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.lblActionLabel);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimeLabel);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHealthPoints);
            this.Controls.Add(this.lblGoldLabel);
            this.Controls.Add(this.lblHealthLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MazeGame";
            this.Text = "MazeGame";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHealthLabel;
        private System.Windows.Forms.Label lblGoldLabel;
        private System.Windows.Forms.Label lblHealthPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblTimeLabel;
        private System.Windows.Forms.Label lblTime;
        private Label lblActionLabel;
        private ComboBox cboWeapons;
        private ComboBox cboPotions;
        private Button btnUseWeapon;
        private Button btnUsePotion;
        private Button btnNorth;
        private Button btnSouth;
        private Button btnWest;
        private Button btnEast;
        private RichTextBox rtbRoom;
        private DataGridView dgvInventory;
        private DataGridView dgvQuests;
        private RichTextBox rtbMessages;
    }
}

