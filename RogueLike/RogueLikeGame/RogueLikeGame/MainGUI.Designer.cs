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
            this.tbxNarrative = new System.Windows.Forms.TextBox();
            this.btnOptionA = new System.Windows.Forms.Button();
            this.btnOptionB = new System.Windows.Forms.Button();
            this.btnOptionC = new System.Windows.Forms.Button();
            this.lbxCombatLog = new System.Windows.Forms.ListBox();
            this.lbxCurrentItems = new System.Windows.Forms.ListBox();
            this.btnUseItem = new System.Windows.Forms.Button();
            this.lblPlayerStatistics = new System.Windows.Forms.Label();
            this.lbxOptionC = new System.Windows.Forms.ListBox();
            this.lblCurrentPotion = new System.Windows.Forms.Label();
            this.prbEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.lblMobHealth = new System.Windows.Forms.Label();
            this.btnAbility = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblDebuff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxNarrative
            // 
            this.tbxNarrative.Location = new System.Drawing.Point(80, 15);
            this.tbxNarrative.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNarrative.Multiline = true;
            this.tbxNarrative.Name = "tbxNarrative";
            this.tbxNarrative.Size = new System.Drawing.Size(548, 155);
            this.tbxNarrative.TabIndex = 0;
            // 
            // btnOptionA
            // 
            this.btnOptionA.Location = new System.Drawing.Point(113, 192);
            this.btnOptionA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOptionA.Name = "btnOptionA";
            this.btnOptionA.Size = new System.Drawing.Size(125, 38);
            this.btnOptionA.TabIndex = 1;
            this.btnOptionA.Text = "button1";
            this.btnOptionA.UseVisualStyleBackColor = true;
            this.btnOptionA.Click += new System.EventHandler(this.btnOptionA_Click);
            // 
            // btnOptionB
            // 
            this.btnOptionB.Location = new System.Drawing.Point(292, 192);
            this.btnOptionB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOptionB.Name = "btnOptionB";
            this.btnOptionB.Size = new System.Drawing.Size(125, 38);
            this.btnOptionB.TabIndex = 2;
            this.btnOptionB.Text = "button2";
            this.btnOptionB.UseVisualStyleBackColor = true;
            this.btnOptionB.Click += new System.EventHandler(this.btnOptionB_Click);
            // 
            // btnOptionC
            // 
            this.btnOptionC.Location = new System.Drawing.Point(475, 192);
            this.btnOptionC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOptionC.Name = "btnOptionC";
            this.btnOptionC.Size = new System.Drawing.Size(125, 38);
            this.btnOptionC.TabIndex = 3;
            this.btnOptionC.Text = "button3";
            this.btnOptionC.UseVisualStyleBackColor = true;
            this.btnOptionC.Click += new System.EventHandler(this.btnOptionC_Click);
            // 
            // lbxCombatLog
            // 
            this.lbxCombatLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCombatLog.FormattingEnabled = true;
            this.lbxCombatLog.ItemHeight = 20;
            this.lbxCombatLog.Location = new System.Drawing.Point(723, 238);
            this.lbxCombatLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxCombatLog.Name = "lbxCombatLog";
            this.lbxCombatLog.Size = new System.Drawing.Size(591, 284);
            this.lbxCombatLog.TabIndex = 4;
            // 
            // lbxCurrentItems
            // 
            this.lbxCurrentItems.FormattingEnabled = true;
            this.lbxCurrentItems.ItemHeight = 16;
            this.lbxCurrentItems.Location = new System.Drawing.Point(931, 15);
            this.lbxCurrentItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxCurrentItems.Name = "lbxCurrentItems";
            this.lbxCurrentItems.Size = new System.Drawing.Size(383, 212);
            this.lbxCurrentItems.TabIndex = 5;
            // 
            // btnUseItem
            // 
            this.btnUseItem.Location = new System.Drawing.Point(832, 98);
            this.btnUseItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUseItem.Name = "btnUseItem";
            this.btnUseItem.Size = new System.Drawing.Size(91, 38);
            this.btnUseItem.TabIndex = 6;
            this.btnUseItem.Text = "button4";
            this.btnUseItem.UseVisualStyleBackColor = true;
            this.btnUseItem.Click += new System.EventHandler(this.btnUseItem_Click);
            // 
            // lblPlayerStatistics
            // 
            this.lblPlayerStatistics.AutoSize = true;
            this.lblPlayerStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStatistics.Location = new System.Drawing.Point(16, 588);
            this.lblPlayerStatistics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerStatistics.Name = "lblPlayerStatistics";
            this.lblPlayerStatistics.Size = new System.Drawing.Size(86, 31);
            this.lblPlayerStatistics.TabIndex = 7;
            this.lblPlayerStatistics.Text = "label1";
            // 
            // lbxOptionC
            // 
            this.lbxOptionC.FormattingEnabled = true;
            this.lbxOptionC.ItemHeight = 16;
            this.lbxOptionC.Location = new System.Drawing.Point(443, 238);
            this.lbxOptionC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxOptionC.Name = "lbxOptionC";
            this.lbxOptionC.Size = new System.Drawing.Size(185, 196);
            this.lbxOptionC.TabIndex = 8;
            // 
            // lblCurrentPotion
            // 
            this.lblCurrentPotion.AutoSize = true;
            this.lblCurrentPotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPotion.Location = new System.Drawing.Point(16, 516);
            this.lblCurrentPotion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentPotion.Name = "lblCurrentPotion";
            this.lblCurrentPotion.Size = new System.Drawing.Size(86, 31);
            this.lblCurrentPotion.TabIndex = 9;
            this.lblCurrentPotion.Text = "label2";
            // 
            // prbEnemyHealth
            // 
            this.prbEnemyHealth.Location = new System.Drawing.Point(723, 554);
            this.prbEnemyHealth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prbEnemyHealth.Name = "prbEnemyHealth";
            this.prbEnemyHealth.Size = new System.Drawing.Size(592, 28);
            this.prbEnemyHealth.TabIndex = 10;
            // 
            // lblMobHealth
            // 
            this.lblMobHealth.AutoSize = true;
            this.lblMobHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobHealth.Location = new System.Drawing.Point(924, 588);
            this.lblMobHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMobHealth.Name = "lblMobHealth";
            this.lblMobHealth.Size = new System.Drawing.Size(93, 31);
            this.lblMobHealth.TabIndex = 11;
            this.lblMobHealth.Text = "Health";
            // 
            // btnAbility
            // 
            this.btnAbility.Location = new System.Drawing.Point(49, 298);
            this.btnAbility.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbility.Name = "btnAbility";
            this.btnAbility.Size = new System.Drawing.Size(125, 38);
            this.btnAbility.TabIndex = 12;
            this.btnAbility.Text = "Use Ability";
            this.btnAbility.UseVisualStyleBackColor = true;
            this.btnAbility.Click += new System.EventHandler(this.btnAbility_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // lblDebuff
            // 
            this.lblDebuff.AutoSize = true;
            this.lblDebuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDebuff.Location = new System.Drawing.Point(636, 44);
            this.lblDebuff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebuff.Name = "lblDebuff";
            this.lblDebuff.Size = new System.Drawing.Size(246, 25);
            this.lblDebuff.TabIndex = 13;
            this.lblDebuff.Text = "Debuff rounds remaining: 0";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 630);
            this.Controls.Add(this.lblDebuff);
            this.Controls.Add(this.btnAbility);
            this.Controls.Add(this.lblMobHealth);
            this.Controls.Add(this.prbEnemyHealth);
            this.Controls.Add(this.lblCurrentPotion);
            this.Controls.Add(this.lbxOptionC);
            this.Controls.Add(this.lblPlayerStatistics);
            this.Controls.Add(this.btnUseItem);
            this.Controls.Add(this.lbxCurrentItems);
            this.Controls.Add(this.lbxCombatLog);
            this.Controls.Add(this.btnOptionC);
            this.Controls.Add(this.btnOptionB);
            this.Controls.Add(this.btnOptionA);
            this.Controls.Add(this.tbxNarrative);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGUI_FormClosing);
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
        private System.Windows.Forms.ListBox lbxOptionC;
        private System.Windows.Forms.Label lblCurrentPotion;
        private System.Windows.Forms.ProgressBar prbEnemyHealth;
        private System.Windows.Forms.Label lblMobHealth;
        private System.Windows.Forms.Button btnAbility;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Label lblDebuff;
    }
}