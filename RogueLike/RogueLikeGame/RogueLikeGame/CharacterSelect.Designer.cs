namespace RogueLikeGame
{
    partial class CharacterSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSelect));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGhost = new System.Windows.Forms.Button();
            this.btnGodKnight = new System.Windows.Forms.Button();
            this.btnBerserker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 421);
            this.label1.TabIndex = 0;
            this.label1.Text = "\rBerserker\r\rRelentless bounty hunter spreading savagery and bloodshed wherever he" +
    " goes\r\rSpecial Ability:\rDeal 3 times more damage for one turn\r\rCooldown: 5 turns" +
    "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(386, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 421);
            this.label2.TabIndex = 1;
            this.label2.Text = "\rGhost\r\rThe trapped soul of an adventurer that stepped through the Gates of Hell " +
    "and was slain by theHarbringer\r\rSpecial Ability:\rVanish from the fight\r\rCooldown" +
    ": 8 turns";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(748, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 421);
            this.label3.TabIndex = 2;
            this.label3.Text = "\rGodKnight\r\rProtector of the divine, \rbanished for his trechery\ragainst the gods " +
    "themselves\r\rSpecial Ability:\rActivates \"Second chance\" on death\r\rCooldown: 8 tur" +
    "ns";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGhost
            // 
            this.btnGhost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhost.Location = new System.Drawing.Point(428, 451);
            this.btnGhost.Margin = new System.Windows.Forms.Padding(4);
            this.btnGhost.Name = "btnGhost";
            this.btnGhost.Size = new System.Drawing.Size(273, 73);
            this.btnGhost.TabIndex = 4;
            this.btnGhost.Text = "Choose character";
            this.btnGhost.UseVisualStyleBackColor = true;
            this.btnGhost.Click += new System.EventHandler(this.BtnGhost_Click);
            // 
            // btnGodKnight
            // 
            this.btnGodKnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGodKnight.Location = new System.Drawing.Point(794, 451);
            this.btnGodKnight.Margin = new System.Windows.Forms.Padding(4);
            this.btnGodKnight.Name = "btnGodKnight";
            this.btnGodKnight.Size = new System.Drawing.Size(273, 73);
            this.btnGodKnight.TabIndex = 5;
            this.btnGodKnight.Text = "Choose character";
            this.btnGodKnight.UseVisualStyleBackColor = true;
            this.btnGodKnight.Click += new System.EventHandler(this.BtnGodKnight_Click);
            // 
            // btnBerserker
            // 
            this.btnBerserker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBerserker.Location = new System.Drawing.Point(67, 451);
            this.btnBerserker.Margin = new System.Windows.Forms.Padding(4);
            this.btnBerserker.Name = "btnBerserker";
            this.btnBerserker.Size = new System.Drawing.Size(273, 73);
            this.btnBerserker.TabIndex = 6;
            this.btnBerserker.Text = "Choose character";
            this.btnBerserker.UseVisualStyleBackColor = true;
            this.btnBerserker.Click += new System.EventHandler(this.BtnBerserker_Click);
            // 
            // CharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RogueLikeGame.Properties.Resources.mainbd3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 554);
            this.Controls.Add(this.btnBerserker);
            this.Controls.Add(this.btnGodKnight);
            this.Controls.Add(this.btnGhost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CharacterSelect";
            this.Text = "CharacterSelect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CharacterSelect_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGhost;
        private System.Windows.Forms.Button btnGodKnight;
        private System.Windows.Forms.Button btnBerserker;
    }
}