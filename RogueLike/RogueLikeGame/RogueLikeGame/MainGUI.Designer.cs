namespace RogueLikeGame
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
            this.lbxCurrentItems = new System.Windows.Forms.ListBox();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.btnAbility = new System.Windows.Forms.Button();
            this.lblDebuff = new System.Windows.Forms.Label();
            this.btnHealthPot = new System.Windows.Forms.Button();
            this.btnPoisonPot = new System.Windows.Forms.Button();
            this.lblHealthPot = new System.Windows.Forms.Label();
            this.lblPoisonPot = new System.Windows.Forms.Label();
            this.gpxItems = new System.Windows.Forms.GroupBox();
            this.lblAbilityCD = new System.Windows.Forms.Label();
            this.btnAA = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnFlee = new System.Windows.Forms.Button();
            this.lblBuff = new System.Windows.Forms.Label();
            this.btnMusic = new System.Windows.Forms.Button();
            this.tbxRiddleAnswer = new System.Windows.Forms.TextBox();
            this.timerAutoAttack = new System.Windows.Forms.Timer(this.components);
            this.lblNarrative = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMobHealth = new System.Windows.Forms.Label();
            this.prbEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lbxCombatLog = new System.Windows.Forms.ListBox();
            this.gpxFight = new System.Windows.Forms.GroupBox();
            this.lblPlayerStatistics = new System.Windows.Forms.Label();
            this.lblMobStats = new System.Windows.Forms.Label();
            this.gpxItems.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpxFight.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOptionA
            // 
            this.btnOptionA.Location = new System.Drawing.Point(131, 155);
            this.btnOptionA.Name = "btnOptionA";
            this.btnOptionA.Size = new System.Drawing.Size(94, 31);
            this.btnOptionA.TabIndex = 1;
            this.btnOptionA.Text = "button1";
            this.btnOptionA.UseVisualStyleBackColor = true;
            this.btnOptionA.Click += new System.EventHandler(this.BtnOptionA_Click);
            // 
            // btnOptionB
            // 
            this.btnOptionB.Location = new System.Drawing.Point(265, 155);
            this.btnOptionB.Name = "btnOptionB";
            this.btnOptionB.Size = new System.Drawing.Size(94, 31);
            this.btnOptionB.TabIndex = 2;
            this.btnOptionB.Text = "button2";
            this.btnOptionB.UseVisualStyleBackColor = true;
            this.btnOptionB.Click += new System.EventHandler(this.BtnOptionB_Click);
            // 
            // btnOptionC
            // 
            this.btnOptionC.Location = new System.Drawing.Point(402, 155);
            this.btnOptionC.Name = "btnOptionC";
            this.btnOptionC.Size = new System.Drawing.Size(94, 31);
            this.btnOptionC.TabIndex = 3;
            this.btnOptionC.Text = "button3";
            this.btnOptionC.UseVisualStyleBackColor = true;
            this.btnOptionC.Click += new System.EventHandler(this.BtnOptionC_Click);
            // 
            // lbxCurrentItems
            // 
            this.lbxCurrentItems.FormattingEnabled = true;
            this.lbxCurrentItems.Location = new System.Drawing.Point(213, 18);
            this.lbxCurrentItems.Name = "lbxCurrentItems";
            this.lbxCurrentItems.Size = new System.Drawing.Size(288, 173);
            this.lbxCurrentItems.TabIndex = 5;
            // 
            // btnUseItem
            // 
            this.btnUseItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnUseItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnUseItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnUseItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnUseItem.Location = new System.Drawing.Point(139, 93);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(68, 31);
            this.btnUseItem.TabIndex = 6;
            this.btnUseItem.Text = "Use";
            this.btnUseItem.UseVisualStyleBackColor = true;
            this.btnUseItem.Click += new System.EventHandler(this.BtnUseItem_Click);
            // 
            // btnAbility
            // 
            this.btnAbility.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAbility.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAbility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAbility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAbility.Location = new System.Drawing.Point(113, 130);
            this.btnAbility.Name = "btnAbility";
            this.btnAbility.Size = new System.Drawing.Size(94, 31);
            this.btnAbility.TabIndex = 12;
            this.btnAbility.Text = "Use Ability";
            this.btnAbility.UseVisualStyleBackColor = true;
            this.btnAbility.Visible = false;
            this.btnAbility.Click += new System.EventHandler(this.BtnAbility_Click);
            // 
            // lblDebuff
            // 
            this.lblDebuff.AutoSize = true;
            this.lblDebuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDebuff.Location = new System.Drawing.Point(10, 33);
            this.lblDebuff.Name = "lblDebuff";
            this.lblDebuff.Size = new System.Drawing.Size(166, 16);
            this.lblDebuff.TabIndex = 13;
            this.lblDebuff.Text = "Debuff rounds remaining: 0";
            // 
            // btnHealthPot
            // 
            this.btnHealthPot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnHealthPot.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnHealthPot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnHealthPot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnHealthPot.Location = new System.Drawing.Point(247, 216);
            this.btnHealthPot.Name = "btnHealthPot";
            this.btnHealthPot.Size = new System.Drawing.Size(70, 24);
            this.btnHealthPot.TabIndex = 14;
            this.btnHealthPot.Text = "Use Potion";
            this.btnHealthPot.UseVisualStyleBackColor = true;
            this.btnHealthPot.Click += new System.EventHandler(this.BtnHealthPot_Click);
            // 
            // btnPoisonPot
            // 
            this.btnPoisonPot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnPoisonPot.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnPoisonPot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnPoisonPot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnPoisonPot.Location = new System.Drawing.Point(399, 219);
            this.btnPoisonPot.Name = "btnPoisonPot";
            this.btnPoisonPot.Size = new System.Drawing.Size(70, 24);
            this.btnPoisonPot.TabIndex = 15;
            this.btnPoisonPot.Text = "Use Potion";
            this.btnPoisonPot.UseVisualStyleBackColor = true;
            this.btnPoisonPot.Click += new System.EventHandler(this.BtnPoisonPot_Click);
            // 
            // lblHealthPot
            // 
            this.lblHealthPot.AutoSize = true;
            this.lblHealthPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHealthPot.Location = new System.Drawing.Point(235, 199);
            this.lblHealthPot.Name = "lblHealthPot";
            this.lblHealthPot.Size = new System.Drawing.Size(65, 13);
            this.lblHealthPot.TabIndex = 16;
            this.lblHealthPot.Text = "Health Pots:";
            // 
            // lblPoisonPot
            // 
            this.lblPoisonPot.AutoSize = true;
            this.lblPoisonPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoisonPot.Location = new System.Drawing.Point(386, 199);
            this.lblPoisonPot.Name = "lblPoisonPot";
            this.lblPoisonPot.Size = new System.Drawing.Size(66, 13);
            this.lblPoisonPot.TabIndex = 17;
            this.lblPoisonPot.Text = "Poison Pots:";
            // 
            // gpxItems
            // 
            this.gpxItems.BackColor = System.Drawing.SystemColors.Control;
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
            // lblAbilityCD
            // 
            this.lblAbilityCD.AutoSize = true;
            this.lblAbilityCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAbilityCD.Location = new System.Drawing.Point(5, 137);
            this.lblAbilityCD.Name = "lblAbilityCD";
            this.lblAbilityCD.Size = new System.Drawing.Size(68, 16);
            this.lblAbilityCD.TabIndex = 24;
            this.lblAbilityCD.Text = "Rounds: 0";
            // 
            // btnAA
            // 
            this.btnAA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAA.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAA.Location = new System.Drawing.Point(517, 133);
            this.btnAA.Name = "btnAA";
            this.btnAA.Size = new System.Drawing.Size(114, 58);
            this.btnAA.TabIndex = 23;
            this.btnAA.Text = "Auto Attack";
            this.btnAA.UseVisualStyleBackColor = true;
            this.btnAA.Visible = false;
            this.btnAA.Click += new System.EventHandler(this.btnAA_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAttack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAttack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAttack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnAttack.Location = new System.Drawing.Point(517, 18);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(114, 58);
            this.btnAttack.TabIndex = 22;
            this.btnAttack.Text = "Turn / Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.BtnAttack_Click);
            // 
            // btnFlee
            // 
            this.btnFlee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnFlee.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnFlee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnFlee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnFlee.Location = new System.Drawing.Point(113, 167);
            this.btnFlee.Name = "btnFlee";
            this.btnFlee.Size = new System.Drawing.Size(94, 31);
            this.btnFlee.TabIndex = 21;
            this.btnFlee.Text = "Flee Fight";
            this.btnFlee.UseVisualStyleBackColor = true;
            this.btnFlee.Visible = false;
            this.btnFlee.Click += new System.EventHandler(this.BtnFlee_Click);
            // 
            // lblBuff
            // 
            this.lblBuff.AutoSize = true;
            this.lblBuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBuff.Location = new System.Drawing.Point(10, 62);
            this.lblBuff.Name = "lblBuff";
            this.lblBuff.Size = new System.Drawing.Size(149, 16);
            this.lblBuff.TabIndex = 19;
            this.lblBuff.Text = "Buff rounds remaining: 0";
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.Color.Orchid;
            this.btnMusic.BackgroundImage = global::RogueLikeGame.Properties.Resources.musicEnable;
            this.btnMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMusic.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnMusic.FlatAppearance.BorderSize = 2;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMusic.Location = new System.Drawing.Point(12, 26);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(57, 55);
            this.btnMusic.TabIndex = 20;
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.BtnMusic_Click);
            // 
            // tbxRiddleAnswer
            // 
            this.tbxRiddleAnswer.Location = new System.Drawing.Point(131, 192);
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
            this.lblNarrative.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNarrative.Location = new System.Drawing.Point(110, 26);
            this.lblNarrative.Name = "lblNarrative";
            this.lblNarrative.Size = new System.Drawing.Size(414, 126);
            this.lblNarrative.TabIndex = 23;
            this.lblNarrative.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.gpxItems);
            this.panel1.Controls.Add(this.gpxFight);
            this.panel1.Location = new System.Drawing.Point(0, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 336);
            this.panel1.TabIndex = 22;
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
            // prbEnemyHealth
            // 
            this.prbEnemyHealth.Location = new System.Drawing.Point(26, 246);
            this.prbEnemyHealth.Name = "prbEnemyHealth";
            this.prbEnemyHealth.Size = new System.Drawing.Size(486, 23);
            this.prbEnemyHealth.TabIndex = 10;
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
            // lblPlayerStatistics
            // 
            this.lblPlayerStatistics.AutoSize = true;
            this.lblPlayerStatistics.BackColor = System.Drawing.Color.Black;
            this.lblPlayerStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayerStatistics.ForeColor = System.Drawing.Color.White;
            this.lblPlayerStatistics.Location = new System.Drawing.Point(603, 39);
            this.lblPlayerStatistics.Name = "lblPlayerStatistics";
            this.lblPlayerStatistics.Size = new System.Drawing.Size(70, 25);
            this.lblPlayerStatistics.TabIndex = 7;
            this.lblPlayerStatistics.Text = "label1";
            this.lblPlayerStatistics.Visible = false;
            // 
            // lblMobStats
            // 
            this.lblMobStats.AutoSize = true;
            this.lblMobStats.BackColor = System.Drawing.Color.Black;
            this.lblMobStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMobStats.ForeColor = System.Drawing.Color.White;
            this.lblMobStats.Location = new System.Drawing.Point(936, 39);
            this.lblMobStats.Name = "lblMobStats";
            this.lblMobStats.Size = new System.Drawing.Size(70, 25);
            this.lblMobStats.TabIndex = 23;
            this.lblMobStats.Text = "label1";
            this.lblMobStats.Visible = false;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RogueLikeGame.Properties.Resources.colorlessbd1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 634);
            this.Controls.Add(this.lblMobStats);
            this.Controls.Add(this.lblNarrative);
            this.Controls.Add(this.lblPlayerStatistics);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxRiddleAnswer);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnOptionC);
            this.Controls.Add(this.btnOptionB);
            this.Controls.Add(this.btnOptionA);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGUI_FormClosing);
            this.gpxItems.ResumeLayout(false);
            this.gpxItems.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gpxFight.ResumeLayout(false);
            this.gpxFight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}