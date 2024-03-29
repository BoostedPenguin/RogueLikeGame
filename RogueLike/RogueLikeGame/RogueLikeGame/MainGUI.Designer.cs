﻿namespace RogueLikeGame
{
    partial class MainGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.btnOptionA = new System.Windows.Forms.Button();
            this.btnOptionB = new System.Windows.Forms.Button();
            this.btnOptionC = new System.Windows.Forms.Button();
            this.tbxRiddleAnswer = new System.Windows.Forms.TextBox();
            this.timerAutoAttack = new System.Windows.Forms.Timer(this.components);
            this.lblNarrative = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMusic = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gpxItems = new System.Windows.Forms.GroupBox();
            this.lblAAInfo = new System.Windows.Forms.Label();
            this.lblAbilityCD = new System.Windows.Forms.Label();
            this.btnAA = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnFlee = new System.Windows.Forms.Button();
            this.lblBuff = new System.Windows.Forms.Label();
            this.lbxCurrentItems = new System.Windows.Forms.ListBox();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.btnAbility = new System.Windows.Forms.Button();
            this.lblPoisonPot = new System.Windows.Forms.Label();
            this.lblDebuff = new System.Windows.Forms.Label();
            this.lblHealthPot = new System.Windows.Forms.Label();
            this.btnHealthPot = new System.Windows.Forms.Button();
            this.btnPoisonPot = new System.Windows.Forms.Button();
            this.gpxFight = new System.Windows.Forms.GroupBox();
            this.lbxCombatLog = new System.Windows.Forms.ListBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.prbEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.lblMobHealth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPlayerStatistics = new System.Windows.Forms.Label();
            this.lblMobStats = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpxItems.SuspendLayout();
            this.gpxFight.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOptionA
            // 
            this.btnOptionA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOptionA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnOptionA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnOptionA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnOptionA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionA.ForeColor = System.Drawing.Color.White;
            this.btnOptionA.Location = new System.Drawing.Point(153, 140);
            this.btnOptionA.Name = "btnOptionA";
            this.btnOptionA.Size = new System.Drawing.Size(94, 31);
            this.btnOptionA.TabIndex = 1;
            this.btnOptionA.Text = "button1";
            this.btnOptionA.UseVisualStyleBackColor = false;
            this.btnOptionA.EnabledChanged += new System.EventHandler(this.btnOptionA_EnabledChanged);
            this.btnOptionA.Click += new System.EventHandler(this.BtnOptionA_Click);
            // 
            // btnOptionB
            // 
            this.btnOptionB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOptionB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnOptionB.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnOptionB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnOptionB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnOptionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionB.ForeColor = System.Drawing.Color.White;
            this.btnOptionB.Location = new System.Drawing.Point(287, 140);
            this.btnOptionB.Name = "btnOptionB";
            this.btnOptionB.Size = new System.Drawing.Size(94, 31);
            this.btnOptionB.TabIndex = 2;
            this.btnOptionB.Text = "button2";
            this.btnOptionB.UseVisualStyleBackColor = false;
            this.btnOptionB.EnabledChanged += new System.EventHandler(this.btnOptionA_EnabledChanged);
            this.btnOptionB.Click += new System.EventHandler(this.BtnOptionB_Click);
            // 
            // btnOptionC
            // 
            this.btnOptionC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnOptionC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnOptionC.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnOptionC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnOptionC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnOptionC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionC.ForeColor = System.Drawing.Color.White;
            this.btnOptionC.Location = new System.Drawing.Point(424, 140);
            this.btnOptionC.Name = "btnOptionC";
            this.btnOptionC.Size = new System.Drawing.Size(94, 31);
            this.btnOptionC.TabIndex = 3;
            this.btnOptionC.Text = "button3";
            this.btnOptionC.UseVisualStyleBackColor = false;
            this.btnOptionC.EnabledChanged += new System.EventHandler(this.btnOptionA_EnabledChanged);
            this.btnOptionC.Click += new System.EventHandler(this.BtnOptionC_Click);
            // 
            // tbxRiddleAnswer
            // 
            this.tbxRiddleAnswer.Location = new System.Drawing.Point(153, 177);
            this.tbxRiddleAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRiddleAnswer.Multiline = true;
            this.tbxRiddleAnswer.Name = "tbxRiddleAnswer";
            this.tbxRiddleAnswer.Size = new System.Drawing.Size(95, 93);
            this.tbxRiddleAnswer.TabIndex = 21;
            this.tbxRiddleAnswer.Visible = false;
            this.tbxRiddleAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxRiddleAnswer_KeyDown);
            // 
            // timerAutoAttack
            // 
            this.timerAutoAttack.Interval = 300;
            this.timerAutoAttack.Tick += new System.EventHandler(this.timerAutoAttack_Tick);
            // 
            // lblNarrative
            // 
            this.lblNarrative.BackColor = System.Drawing.Color.White;
            this.lblNarrative.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNarrative.Location = new System.Drawing.Point(132, 11);
            this.lblNarrative.Name = "lblNarrative";
            this.lblNarrative.Size = new System.Drawing.Size(414, 126);
            this.lblNarrative.TabIndex = 23;
            this.lblNarrative.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lblNarrative);
            this.panel3.Controls.Add(this.btnOptionA);
            this.panel3.Controls.Add(this.btnOptionB);
            this.panel3.Controls.Add(this.tbxRiddleAnswer);
            this.panel3.Controls.Add(this.btnOptionC);
            this.panel3.Controls.Add(this.btnMusic);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 293);
            this.panel3.TabIndex = 25;
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.Color.White;
            this.btnMusic.BackgroundImage = global::RogueLikeGame.Properties.Resources.musicEnable;
            this.btnMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMusic.FlatAppearance.BorderSize = 2;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMusic.Location = new System.Drawing.Point(27, 11);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(46, 46);
            this.btnMusic.TabIndex = 20;
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.BtnMusic_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RogueLikeGame.Properties.Resources.bdfight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.gpxItems);
            this.panel1.Controls.Add(this.gpxFight);
            this.panel1.Location = new System.Drawing.Point(0, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 347);
            this.panel1.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1239, 5);
            this.panel4.TabIndex = 26;
            // 
            // gpxItems
            // 
            this.gpxItems.BackColor = System.Drawing.SystemColors.Control;
            this.gpxItems.Controls.Add(this.lblAAInfo);
            this.gpxItems.Controls.Add(this.lblAbilityCD);
            this.gpxItems.Controls.Add(this.btnAA);
            this.gpxItems.Controls.Add(this.btnAttack);
            this.gpxItems.Controls.Add(this.btnFlee);
            this.gpxItems.Controls.Add(this.lblBuff);
            this.gpxItems.Controls.Add(this.lbxCurrentItems);
            this.gpxItems.Controls.Add(this.btnUseItem);
            this.gpxItems.Controls.Add(this.btnAbility);
            this.gpxItems.Controls.Add(this.lblPoisonPot);
            this.gpxItems.Controls.Add(this.lblDebuff);
            this.gpxItems.Controls.Add(this.lblHealthPot);
            this.gpxItems.Controls.Add(this.btnHealthPot);
            this.gpxItems.Controls.Add(this.btnPoisonPot);
            this.gpxItems.Enabled = false;
            this.gpxItems.Location = new System.Drawing.Point(12, 12);
            this.gpxItems.Margin = new System.Windows.Forms.Padding(2);
            this.gpxItems.Name = "gpxItems";
            this.gpxItems.Padding = new System.Windows.Forms.Padding(2);
            this.gpxItems.Size = new System.Drawing.Size(651, 308);
            this.gpxItems.TabIndex = 12;
            this.gpxItems.TabStop = false;
            this.gpxItems.Text = "gpxItems";
            // 
            // lblAAInfo
            // 
            this.lblAAInfo.AutoSize = true;
            this.lblAAInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAAInfo.Location = new System.Drawing.Point(5, 201);
            this.lblAAInfo.Name = "lblAAInfo";
            this.lblAAInfo.Size = new System.Drawing.Size(141, 13);
            this.lblAAInfo.TabIndex = 25;
            this.lblAAInfo.Text = "Disabled if under 25% health";
            // 
            // lblAbilityCD
            // 
            this.lblAbilityCD.AutoSize = true;
            this.lblAbilityCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAbilityCD.Location = new System.Drawing.Point(540, 120);
            this.lblAbilityCD.Name = "lblAbilityCD";
            this.lblAbilityCD.Size = new System.Drawing.Size(68, 16);
            this.lblAbilityCD.TabIndex = 24;
            this.lblAbilityCD.Text = "Rounds: 0";
            // 
            // btnAA
            // 
            this.btnAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(169)))));
            this.btnAA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAA.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAA.ForeColor = System.Drawing.Color.White;
            this.btnAA.Location = new System.Drawing.Point(8, 133);
            this.btnAA.Name = "btnAA";
            this.btnAA.Size = new System.Drawing.Size(114, 58);
            this.btnAA.TabIndex = 23;
            this.btnAA.Text = "Auto Attack";
            this.btnAA.UseVisualStyleBackColor = false;
            this.btnAA.Visible = false;
            this.btnAA.EnabledChanged += new System.EventHandler(this.btnOptionA_EnabledChanged);
            this.btnAA.Click += new System.EventHandler(this.btnAA_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(169)))));
            this.btnAttack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAttack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAttack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAttack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.ForeColor = System.Drawing.Color.White;
            this.btnAttack.Location = new System.Drawing.Point(8, 31);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(114, 58);
            this.btnAttack.TabIndex = 22;
            this.btnAttack.Text = "Turn / Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.EnabledChanged += new System.EventHandler(this.btnOptionA_EnabledChanged);
            this.btnAttack.Click += new System.EventHandler(this.BtnAttack_Click);
            // 
            // btnFlee
            // 
            this.btnFlee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(169)))));
            this.btnFlee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnFlee.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnFlee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnFlee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnFlee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlee.ForeColor = System.Drawing.Color.White;
            this.btnFlee.Location = new System.Drawing.Point(440, 150);
            this.btnFlee.Name = "btnFlee";
            this.btnFlee.Size = new System.Drawing.Size(94, 31);
            this.btnFlee.TabIndex = 21;
            this.btnFlee.Text = "Flee Fight";
            this.btnFlee.UseVisualStyleBackColor = false;
            this.btnFlee.Visible = false;
            this.btnFlee.EnabledChanged += new System.EventHandler(this.btnOptionA_EnabledChanged);
            this.btnFlee.Click += new System.EventHandler(this.BtnFlee_Click);
            // 
            // lblBuff
            // 
            this.lblBuff.AutoSize = true;
            this.lblBuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBuff.Location = new System.Drawing.Point(5, 281);
            this.lblBuff.Name = "lblBuff";
            this.lblBuff.Size = new System.Drawing.Size(149, 16);
            this.lblBuff.TabIndex = 19;
            this.lblBuff.Text = "Buff rounds remaining: 0";
            // 
            // lbxCurrentItems
            // 
            this.lbxCurrentItems.FormattingEnabled = true;
            this.lbxCurrentItems.Location = new System.Drawing.Point(146, 18);
            this.lbxCurrentItems.Name = "lbxCurrentItems";
            this.lbxCurrentItems.Size = new System.Drawing.Size(288, 173);
            this.lbxCurrentItems.TabIndex = 5;
            // 
            // btnUseItem
            // 
            this.btnUseItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(169)))));
            this.btnUseItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnUseItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnUseItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnUseItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnUseItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseItem.ForeColor = System.Drawing.Color.White;
            this.btnUseItem.Location = new System.Drawing.Point(440, 40);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(115, 49);
            this.btnUseItem.TabIndex = 6;
            this.btnUseItem.Text = "Use Item";
            this.btnUseItem.UseVisualStyleBackColor = false;
            this.btnUseItem.EnabledChanged += new System.EventHandler(this.btnOptionA_EnabledChanged);
            this.btnUseItem.Click += new System.EventHandler(this.BtnUseItem_Click);
            // 
            // btnAbility
            // 
            this.btnAbility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(169)))));
            this.btnAbility.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAbility.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAbility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAbility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAbility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbility.ForeColor = System.Drawing.Color.White;
            this.btnAbility.Location = new System.Drawing.Point(440, 113);
            this.btnAbility.Name = "btnAbility";
            this.btnAbility.Size = new System.Drawing.Size(94, 31);
            this.btnAbility.TabIndex = 12;
            this.btnAbility.Text = "Use Ability";
            this.btnAbility.UseVisualStyleBackColor = false;
            this.btnAbility.Visible = false;
            this.btnAbility.EnabledChanged += new System.EventHandler(this.btnOptionA_EnabledChanged);
            this.btnAbility.Click += new System.EventHandler(this.BtnAbility_Click);
            // 
            // lblPoisonPot
            // 
            this.lblPoisonPot.AutoSize = true;
            this.lblPoisonPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoisonPot.Location = new System.Drawing.Point(319, 199);
            this.lblPoisonPot.Name = "lblPoisonPot";
            this.lblPoisonPot.Size = new System.Drawing.Size(66, 13);
            this.lblPoisonPot.TabIndex = 17;
            this.lblPoisonPot.Text = "Poison Pots:";
            // 
            // lblDebuff
            // 
            this.lblDebuff.AutoSize = true;
            this.lblDebuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDebuff.Location = new System.Drawing.Point(5, 253);
            this.lblDebuff.Name = "lblDebuff";
            this.lblDebuff.Size = new System.Drawing.Size(166, 16);
            this.lblDebuff.TabIndex = 13;
            this.lblDebuff.Text = "Debuff rounds remaining: 0";
            // 
            // lblHealthPot
            // 
            this.lblHealthPot.AutoSize = true;
            this.lblHealthPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHealthPot.Location = new System.Drawing.Point(168, 199);
            this.lblHealthPot.Name = "lblHealthPot";
            this.lblHealthPot.Size = new System.Drawing.Size(65, 13);
            this.lblHealthPot.TabIndex = 16;
            this.lblHealthPot.Text = "Health Pots:";
            // 
            // btnHealthPot
            // 
            this.btnHealthPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(169)))));
            this.btnHealthPot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnHealthPot.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnHealthPot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnHealthPot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnHealthPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealthPot.ForeColor = System.Drawing.Color.White;
            this.btnHealthPot.Location = new System.Drawing.Point(180, 216);
            this.btnHealthPot.Name = "btnHealthPot";
            this.btnHealthPot.Size = new System.Drawing.Size(79, 27);
            this.btnHealthPot.TabIndex = 14;
            this.btnHealthPot.Text = "Use Potion";
            this.btnHealthPot.UseVisualStyleBackColor = false;
            this.btnHealthPot.EnabledChanged += new System.EventHandler(this.btnOptionA_EnabledChanged);
            this.btnHealthPot.Click += new System.EventHandler(this.BtnHealthPot_Click);
            // 
            // btnPoisonPot
            // 
            this.btnPoisonPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(169)))));
            this.btnPoisonPot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnPoisonPot.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnPoisonPot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnPoisonPot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnPoisonPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoisonPot.ForeColor = System.Drawing.Color.White;
            this.btnPoisonPot.Location = new System.Drawing.Point(340, 216);
            this.btnPoisonPot.Name = "btnPoisonPot";
            this.btnPoisonPot.Size = new System.Drawing.Size(80, 27);
            this.btnPoisonPot.TabIndex = 15;
            this.btnPoisonPot.Text = "Use Potion";
            this.btnPoisonPot.UseVisualStyleBackColor = false;
            this.btnPoisonPot.EnabledChanged += new System.EventHandler(this.btnOptionA_EnabledChanged);
            this.btnPoisonPot.Click += new System.EventHandler(this.BtnPoisonPot_Click);
            // 
            // gpxFight
            // 
            this.gpxFight.BackColor = System.Drawing.SystemColors.Control;
            this.gpxFight.Controls.Add(this.lbxCombatLog);
            this.gpxFight.Controls.Add(this.lblTurn);
            this.gpxFight.Controls.Add(this.prbEnemyHealth);
            this.gpxFight.Controls.Add(this.lblMobHealth);
            this.gpxFight.Enabled = false;
            this.gpxFight.Location = new System.Drawing.Point(692, 12);
            this.gpxFight.Margin = new System.Windows.Forms.Padding(2);
            this.gpxFight.Name = "gpxFight";
            this.gpxFight.Padding = new System.Windows.Forms.Padding(2);
            this.gpxFight.Size = new System.Drawing.Size(535, 308);
            this.gpxFight.TabIndex = 19;
            this.gpxFight.TabStop = false;
            this.gpxFight.Text = "gpxFight";
            // 
            // lbxCombatLog
            // 
            this.lbxCombatLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCombatLog.FormattingEnabled = true;
            this.lbxCombatLog.HorizontalScrollbar = true;
            this.lbxCombatLog.ItemHeight = 16;
            this.lbxCombatLog.Location = new System.Drawing.Point(25, 18);
            this.lbxCombatLog.Name = "lbxCombatLog";
            this.lbxCombatLog.Size = new System.Drawing.Size(487, 196);
            this.lbxCombatLog.TabIndex = 4;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(394, 272);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(70, 25);
            this.lblTurn.TabIndex = 20;
            this.lblTurn.Text = "label1";
            this.lblTurn.Visible = false;
            // 
            // prbEnemyHealth
            // 
            this.prbEnemyHealth.Location = new System.Drawing.Point(26, 246);
            this.prbEnemyHealth.Name = "prbEnemyHealth";
            this.prbEnemyHealth.Size = new System.Drawing.Size(486, 23);
            this.prbEnemyHealth.TabIndex = 10;
            // 
            // lblMobHealth
            // 
            this.lblMobHealth.AutoSize = true;
            this.lblMobHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobHealth.Location = new System.Drawing.Point(99, 272);
            this.lblMobHealth.Name = "lblMobHealth";
            this.lblMobHealth.Size = new System.Drawing.Size(74, 25);
            this.lblMobHealth.TabIndex = 11;
            this.lblMobHealth.Text = "Health";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RogueLikeGame.Properties.Resources.statbd1;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lblPlayerStatistics);
            this.panel2.Controls.Add(this.lblMobStats);
            this.panel2.Location = new System.Drawing.Point(675, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 296);
            this.panel2.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 298);
            this.panel5.TabIndex = 27;
            // 
            // lblPlayerStatistics
            // 
            this.lblPlayerStatistics.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayerStatistics.ForeColor = System.Drawing.Color.White;
            this.lblPlayerStatistics.Location = new System.Drawing.Point(37, 42);
            this.lblPlayerStatistics.Name = "lblPlayerStatistics";
            this.lblPlayerStatistics.Size = new System.Drawing.Size(215, 228);
            this.lblPlayerStatistics.TabIndex = 7;
            this.lblPlayerStatistics.Text = "label1";
            this.lblPlayerStatistics.Visible = false;
            // 
            // lblMobStats
            // 
            this.lblMobStats.BackColor = System.Drawing.Color.Transparent;
            this.lblMobStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMobStats.ForeColor = System.Drawing.Color.White;
            this.lblMobStats.Location = new System.Drawing.Point(276, 42);
            this.lblMobStats.Name = "lblMobStats";
            this.lblMobStats.Size = new System.Drawing.Size(276, 228);
            this.lblMobStats.TabIndex = 23;
            this.lblMobStats.Text = "label1";
            this.lblMobStats.Visible = false;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGUI_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gpxItems.ResumeLayout(false);
            this.gpxItems.PerformLayout();
            this.gpxFight.ResumeLayout(false);
            this.gpxFight.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOptionA;
        private System.Windows.Forms.Button btnOptionB;
        private System.Windows.Forms.Button btnOptionC;
        private System.Windows.Forms.ListBox lbxCurrentItems;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.Button btnAbility;
        private System.Windows.Forms.Label lblDebuff;
        private System.Windows.Forms.Button btnHealthPot;
        private System.Windows.Forms.Button btnPoisonPot;
        private System.Windows.Forms.Label lblHealthPot;
        private System.Windows.Forms.Label lblPoisonPot;
        private System.Windows.Forms.GroupBox gpxItems;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Label lblBuff;
        private System.Windows.Forms.Button btnFlee;
        private System.Windows.Forms.TextBox tbxRiddleAnswer;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnAA;
        private System.Windows.Forms.Timer timerAutoAttack;
        private System.Windows.Forms.Label lblAbilityCD;
        private System.Windows.Forms.Label lblNarrative;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMobStats;
        private System.Windows.Forms.Label lblPlayerStatistics;
        private System.Windows.Forms.GroupBox gpxFight;
        private System.Windows.Forms.ListBox lbxCombatLog;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.ProgressBar prbEnemyHealth;
        private System.Windows.Forms.Label lblMobHealth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAAInfo;
    }
}