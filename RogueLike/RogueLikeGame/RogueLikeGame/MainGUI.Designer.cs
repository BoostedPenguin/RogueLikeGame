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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.tbxNarrative = new System.Windows.Forms.TextBox();
            this.btnOptionA = new System.Windows.Forms.Button();
            this.btnOptionB = new System.Windows.Forms.Button();
            this.btnOptionC = new System.Windows.Forms.Button();
            this.lbxCombatLog = new System.Windows.Forms.ListBox();
            this.lbxCurrentItems = new System.Windows.Forms.ListBox();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.lblPlayerStatistics = new System.Windows.Forms.Label();
            this.prbEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.lblMobHealth = new System.Windows.Forms.Label();
            this.btnAbility = new System.Windows.Forms.Button();
            this.lblDebuff = new System.Windows.Forms.Label();
            this.btnHealthPot = new System.Windows.Forms.Button();
            this.btnPoisonPot = new System.Windows.Forms.Button();
            this.lblHealthPot = new System.Windows.Forms.Label();
            this.lblPoisonPot = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.gpxFight = new System.Windows.Forms.GroupBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.gpxItems = new System.Windows.Forms.GroupBox();
            this.btnFlee = new System.Windows.Forms.Button();
            this.lblBuff = new System.Windows.Forms.Label();
            this.btnMusic = new System.Windows.Forms.Button();
            this.tbxRiddleAnswer = new System.Windows.Forms.TextBox();
            this.gpxFight.SuspendLayout();
            this.gpxItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNarrative
            // 
            this.tbxNarrative.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNarrative.Location = new System.Drawing.Point(80, 15);
            this.tbxNarrative.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNarrative.Multiline = true;
            this.tbxNarrative.Name = "tbxNarrative";
            this.tbxNarrative.ReadOnly = true;
            this.tbxNarrative.Size = new System.Drawing.Size(548, 155);
            this.tbxNarrative.TabIndex = 0;
            // 
            // btnOptionA
            // 
            this.btnOptionA.Location = new System.Drawing.Point(113, 192);
            this.btnOptionA.Margin = new System.Windows.Forms.Padding(4);
            this.btnOptionA.Name = "btnOptionA";
            this.btnOptionA.Size = new System.Drawing.Size(125, 38);
            this.btnOptionA.TabIndex = 1;
            this.btnOptionA.Text = "button1";
            this.btnOptionA.UseVisualStyleBackColor = true;
            this.btnOptionA.Click += new System.EventHandler(this.BtnOptionA_Click);
            // 
            // btnOptionB
            // 
            this.btnOptionB.Location = new System.Drawing.Point(292, 192);
            this.btnOptionB.Margin = new System.Windows.Forms.Padding(4);
            this.btnOptionB.Name = "btnOptionB";
            this.btnOptionB.Size = new System.Drawing.Size(125, 38);
            this.btnOptionB.TabIndex = 2;
            this.btnOptionB.Text = "button2";
            this.btnOptionB.UseVisualStyleBackColor = true;
            this.btnOptionB.Click += new System.EventHandler(this.BtnOptionB_Click);
            // 
            // btnOptionC
            // 
            this.btnOptionC.Location = new System.Drawing.Point(475, 192);
            this.btnOptionC.Margin = new System.Windows.Forms.Padding(4);
            this.btnOptionC.Name = "btnOptionC";
            this.btnOptionC.Size = new System.Drawing.Size(125, 38);
            this.btnOptionC.TabIndex = 3;
            this.btnOptionC.Text = "button3";
            this.btnOptionC.UseVisualStyleBackColor = true;
            this.btnOptionC.Click += new System.EventHandler(this.BtnOptionC_Click);
            // 
            // lbxCombatLog
            // 
            this.lbxCombatLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCombatLog.FormattingEnabled = true;
            this.lbxCombatLog.HorizontalScrollbar = true;
            this.lbxCombatLog.ItemHeight = 20;
            this.lbxCombatLog.Location = new System.Drawing.Point(12, 22);
            this.lbxCombatLog.Margin = new System.Windows.Forms.Padding(4);
            this.lbxCombatLog.Name = "lbxCombatLog";
            this.lbxCombatLog.Size = new System.Drawing.Size(591, 284);
            this.lbxCombatLog.TabIndex = 4;
            // 
            // lbxCurrentItems
            // 
            this.lbxCurrentItems.FormattingEnabled = true;
            this.lbxCurrentItems.ItemHeight = 16;
            this.lbxCurrentItems.Location = new System.Drawing.Point(277, 22);
            this.lbxCurrentItems.Margin = new System.Windows.Forms.Padding(4);
            this.lbxCurrentItems.Name = "lbxCurrentItems";
            this.lbxCurrentItems.Size = new System.Drawing.Size(383, 212);
            this.lbxCurrentItems.TabIndex = 5;
            // 
            // btnUseItem
            // 
            this.btnUseItem.Location = new System.Drawing.Point(178, 105);
            this.btnUseItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(91, 38);
            this.btnUseItem.TabIndex = 6;
            this.btnUseItem.Text = "Use";
            this.btnUseItem.UseVisualStyleBackColor = true;
            this.btnUseItem.Click += new System.EventHandler(this.BtnUseItem_Click);
            // 
            // lblPlayerStatistics
            // 
            this.lblPlayerStatistics.AutoSize = true;
            this.lblPlayerStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStatistics.Location = new System.Drawing.Point(13, 658);
            this.lblPlayerStatistics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerStatistics.Name = "lblPlayerStatistics";
            this.lblPlayerStatistics.Size = new System.Drawing.Size(86, 31);
            this.lblPlayerStatistics.TabIndex = 7;
            this.lblPlayerStatistics.Text = "label1";
            // 
            // prbEnemyHealth
            // 
            this.prbEnemyHealth.Location = new System.Drawing.Point(12, 314);
            this.prbEnemyHealth.Margin = new System.Windows.Forms.Padding(4);
            this.prbEnemyHealth.Name = "prbEnemyHealth";
            this.prbEnemyHealth.Size = new System.Drawing.Size(592, 28);
            this.prbEnemyHealth.TabIndex = 10;
            // 
            // lblMobHealth
            // 
            this.lblMobHealth.AutoSize = true;
            this.lblMobHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobHealth.Location = new System.Drawing.Point(153, 348);
            this.lblMobHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMobHealth.Name = "lblMobHealth";
            this.lblMobHealth.Size = new System.Drawing.Size(93, 31);
            this.lblMobHealth.TabIndex = 11;
            this.lblMobHealth.Text = "Health";
            // 
            // btnAbility
            // 
            this.btnAbility.Location = new System.Drawing.Point(144, 160);
            this.btnAbility.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbility.Name = "btnAbility";
            this.btnAbility.Size = new System.Drawing.Size(125, 38);
            this.btnAbility.TabIndex = 12;
            this.btnAbility.Text = "Use Ability";
            this.btnAbility.UseVisualStyleBackColor = true;
            this.btnAbility.Click += new System.EventHandler(this.BtnAbility_Click);
            // 
            // lblDebuff
            // 
            this.lblDebuff.AutoSize = true;
            this.lblDebuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDebuff.Location = new System.Drawing.Point(7, 41);
            this.lblDebuff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebuff.Name = "lblDebuff";
            this.lblDebuff.Size = new System.Drawing.Size(246, 25);
            this.lblDebuff.TabIndex = 13;
            this.lblDebuff.Text = "Debuff rounds remaining: 0";
            // 
            // btnHealthPot
            // 
            this.btnHealthPot.Location = new System.Drawing.Point(316, 269);
            this.btnHealthPot.Margin = new System.Windows.Forms.Padding(4);
            this.btnHealthPot.Name = "btnHealthPot";
            this.btnHealthPot.Size = new System.Drawing.Size(72, 29);
            this.btnHealthPot.TabIndex = 14;
            this.btnHealthPot.Text = "button1";
            this.btnHealthPot.UseVisualStyleBackColor = true;
            this.btnHealthPot.Click += new System.EventHandler(this.BtnHealthPot_Click);
            // 
            // btnPoisonPot
            // 
            this.btnPoisonPot.Location = new System.Drawing.Point(526, 269);
            this.btnPoisonPot.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoisonPot.Name = "btnPoisonPot";
            this.btnPoisonPot.Size = new System.Drawing.Size(72, 29);
            this.btnPoisonPot.TabIndex = 15;
            this.btnPoisonPot.Text = "button2";
            this.btnPoisonPot.UseVisualStyleBackColor = true;
            this.btnPoisonPot.Click += new System.EventHandler(this.BtnPoisonPot_Click);
            // 
            // lblHealthPot
            // 
            this.lblHealthPot.AutoSize = true;
            this.lblHealthPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHealthPot.Location = new System.Drawing.Point(281, 245);
            this.lblHealthPot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHealthPot.Name = "lblHealthPot";
            this.lblHealthPot.Size = new System.Drawing.Size(85, 17);
            this.lblHealthPot.TabIndex = 16;
            this.lblHealthPot.Text = "Health Pots:";
            // 
            // lblPoisonPot
            // 
            this.lblPoisonPot.AutoSize = true;
            this.lblPoisonPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoisonPot.Location = new System.Drawing.Point(495, 245);
            this.lblPoisonPot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoisonPot.Name = "lblPoisonPot";
            this.lblPoisonPot.Size = new System.Drawing.Size(87, 17);
            this.lblPoisonPot.TabIndex = 17;
            this.lblPoisonPot.Text = "Poison Pots:";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(144, 252);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(4);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(125, 38);
            this.btnAttack.TabIndex = 18;
            this.btnAttack.Text = "Turn / Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.BtnAttack_Click);
            // 
            // gpxFight
            // 
            this.gpxFight.Controls.Add(this.lbxCombatLog);
            this.gpxFight.Controls.Add(this.prbEnemyHealth);
            this.gpxFight.Controls.Add(this.lblMobHealth);
            this.gpxFight.Location = new System.Drawing.Point(691, 310);
            this.gpxFight.Name = "gpxFight";
            this.gpxFight.Size = new System.Drawing.Size(628, 390);
            this.gpxFight.TabIndex = 19;
            this.gpxFight.TabStop = false;
            this.gpxFight.Text = "gpxFight";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(13, 425);
            this.lblTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(86, 31);
            this.lblTurn.TabIndex = 20;
            this.lblTurn.Text = "label1";
            // 
            // gpxItems
            // 
            this.gpxItems.Controls.Add(this.btnFlee);
            this.gpxItems.Controls.Add(this.lblBuff);
            this.gpxItems.Controls.Add(this.lbxCurrentItems);
            this.gpxItems.Controls.Add(this.btnUseItem);
            this.gpxItems.Controls.Add(this.btnAttack);
            this.gpxItems.Controls.Add(this.btnAbility);
            this.gpxItems.Controls.Add(this.lblPoisonPot);
            this.gpxItems.Controls.Add(this.lblDebuff);
            this.gpxItems.Controls.Add(this.lblHealthPot);
            this.gpxItems.Controls.Add(this.btnHealthPot);
            this.gpxItems.Controls.Add(this.btnPoisonPot);
            this.gpxItems.Location = new System.Drawing.Point(649, 2);
            this.gpxItems.Name = "gpxItems";
            this.gpxItems.Size = new System.Drawing.Size(670, 302);
            this.gpxItems.TabIndex = 12;
            this.gpxItems.TabStop = false;
            this.gpxItems.Text = "gpxItems";
            // 
            // btnFlee
            // 
            this.btnFlee.Location = new System.Drawing.Point(144, 206);
            this.btnFlee.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlee.Name = "btnFlee";
            this.btnFlee.Size = new System.Drawing.Size(125, 38);
            this.btnFlee.TabIndex = 21;
            this.btnFlee.Text = "Flee Fight";
            this.btnFlee.UseVisualStyleBackColor = true;
            this.btnFlee.Click += new System.EventHandler(this.BtnFlee_Click);
            // 
            // lblBuff
            // 
            this.lblBuff.AutoSize = true;
            this.lblBuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBuff.Location = new System.Drawing.Point(7, 76);
            this.lblBuff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuff.Name = "lblBuff";
            this.lblBuff.Size = new System.Drawing.Size(223, 25);
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
            this.btnMusic.Location = new System.Drawing.Point(7, 15);
            this.btnMusic.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(65, 56);
            this.btnMusic.TabIndex = 20;
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.BtnMusic_Click);
            // 
            // tbxRiddleAnswer
            // 
            this.tbxRiddleAnswer.Location = new System.Drawing.Point(113, 237);
            this.tbxRiddleAnswer.Multiline = true;
            this.tbxRiddleAnswer.Name = "tbxRiddleAnswer";
            this.tbxRiddleAnswer.Size = new System.Drawing.Size(125, 114);
            this.tbxRiddleAnswer.TabIndex = 21;
            this.tbxRiddleAnswer.Visible = false;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 716);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.tbxRiddleAnswer);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.gpxItems);
            this.Controls.Add(this.gpxFight);
            this.Controls.Add(this.lblPlayerStatistics);
            this.Controls.Add(this.btnOptionC);
            this.Controls.Add(this.btnOptionB);
            this.Controls.Add(this.btnOptionA);
            this.Controls.Add(this.tbxNarrative);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGUI_FormClosing);
            this.gpxFight.ResumeLayout(false);
            this.gpxFight.PerformLayout();
            this.gpxItems.ResumeLayout(false);
            this.gpxItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNarrative;
        private System.Windows.Forms.Button btnOptionA;
        private System.Windows.Forms.Button btnOptionB;
        private System.Windows.Forms.Button btnOptionC;
        private System.Windows.Forms.ListBox lbxCombatLog;
        private System.Windows.Forms.ListBox lbxCurrentItems;
        private System.Windows.Forms.Button btnUseItem;
        private System.Windows.Forms.Label lblPlayerStatistics;
        private System.Windows.Forms.ProgressBar prbEnemyHealth;
        private System.Windows.Forms.Label lblMobHealth;
        private System.Windows.Forms.Button btnAbility;
        private System.Windows.Forms.Label lblDebuff;
        private System.Windows.Forms.Button btnHealthPot;
        private System.Windows.Forms.Button btnPoisonPot;
        private System.Windows.Forms.Label lblHealthPot;
        private System.Windows.Forms.Label lblPoisonPot;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.GroupBox gpxFight;
        private System.Windows.Forms.GroupBox gpxItems;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Label lblBuff;
        private System.Windows.Forms.Button btnFlee;
        private System.Windows.Forms.TextBox tbxRiddleAnswer;
    }
}