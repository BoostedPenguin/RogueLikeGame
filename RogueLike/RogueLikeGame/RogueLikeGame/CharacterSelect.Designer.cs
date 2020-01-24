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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtBerserker = new System.Windows.Forms.RadioButton();
            this.rbtGhost = new System.Windows.Forms.RadioButton();
            this.rbtGodKnight = new System.Windows.Forms.RadioButton();
            this.btnChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 11);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(739, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 421);
            this.label3.TabIndex = 2;
            this.label3.Text = "\rGodKnight\r\rProtector of the divine, \rbanished for his trechery\ragainst the gods " +
    "themselves\r\rSpecial Ability:\rActivates \"Second chance\" on death\r\rCooldown: 8 tur" +
    "ns";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbtBerserker
            // 
            this.rbtBerserker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBerserker.Location = new System.Drawing.Point(184, 436);
            this.rbtBerserker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtBerserker.Name = "rbtBerserker";
            this.rbtBerserker.Size = new System.Drawing.Size(19, 16);
            this.rbtBerserker.TabIndex = 1;
            this.rbtBerserker.TabStop = true;
            this.rbtBerserker.UseVisualStyleBackColor = true;
            // 
            // rbtGhost
            // 
            this.rbtGhost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGhost.Location = new System.Drawing.Point(551, 436);
            this.rbtGhost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtGhost.Name = "rbtGhost";
            this.rbtGhost.Size = new System.Drawing.Size(19, 16);
            this.rbtGhost.TabIndex = 2;
            this.rbtGhost.TabStop = true;
            this.rbtGhost.UseVisualStyleBackColor = true;
            // 
            // rbtGodKnight
            // 
            this.rbtGodKnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGodKnight.Location = new System.Drawing.Point(917, 436);
            this.rbtGodKnight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtGodKnight.Name = "rbtGodKnight";
            this.rbtGodKnight.Size = new System.Drawing.Size(19, 16);
            this.rbtGodKnight.TabIndex = 3;
            this.rbtGodKnight.TabStop = true;
            this.rbtGodKnight.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(425, 466);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(273, 73);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Choose character";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // CharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 554);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.rbtGodKnight);
            this.Controls.Add(this.rbtGhost);
            this.Controls.Add(this.rbtBerserker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CharacterSelect";
            this.Text = "CharacterSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtBerserker;
        private System.Windows.Forms.RadioButton rbtGhost;
        private System.Windows.Forms.RadioButton rbtGodKnight;
        private System.Windows.Forms.Button btnChoose;
    }
}