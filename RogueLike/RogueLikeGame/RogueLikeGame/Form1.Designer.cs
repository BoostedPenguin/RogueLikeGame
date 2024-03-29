﻿namespace RogueLikeGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLoadLastSave = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnScores = new System.Windows.Forms.Button();
            this.lbxScores = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWrongUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, -28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 258);
            this.label1.TabIndex = 0;
            this.label1.Text = "\rWelcome to the world of Hellsgate.\r\rPlease enter your name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(76, 301);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(246, 36);
            this.tbxName.TabIndex = 1;
            this.tbxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxName_KeyDown);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(10, 379);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 58);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnLoadLastSave
            // 
            this.btnLoadLastSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLoadLastSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnLoadLastSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnLoadLastSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnLoadLastSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadLastSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadLastSave.ForeColor = System.Drawing.Color.White;
            this.btnLoadLastSave.Location = new System.Drawing.Point(249, 379);
            this.btnLoadLastSave.Name = "btnLoadLastSave";
            this.btnLoadLastSave.Size = new System.Drawing.Size(139, 58);
            this.btnLoadLastSave.TabIndex = 4;
            this.btnLoadLastSave.Text = "Load Game";
            this.btnLoadLastSave.UseVisualStyleBackColor = false;
            this.btnLoadLastSave.Click += new System.EventHandler(this.BtnLoadLastSave_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(10, 11);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(80, 30);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnScores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnScores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnScores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(31)))), ((int)(((byte)(3)))));
            this.btnScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnScores.ForeColor = System.Drawing.Color.White;
            this.btnScores.Location = new System.Drawing.Point(309, 11);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(80, 30);
            this.btnScores.TabIndex = 6;
            this.btnScores.Text = "Scores";
            this.btnScores.UseVisualStyleBackColor = false;
            this.btnScores.Click += new System.EventHandler(this.BtnScores_Click);
            // 
            // lbxScores
            // 
            this.lbxScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxScores.FormattingEnabled = true;
            this.lbxScores.ItemHeight = 20;
            this.lbxScores.Location = new System.Drawing.Point(13, 10);
            this.lbxScores.Margin = new System.Windows.Forms.Padding(2);
            this.lbxScores.Name = "lbxScores";
            this.lbxScores.Size = new System.Drawing.Size(353, 364);
            this.lbxScores.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbxScores);
            this.panel1.Location = new System.Drawing.Point(10, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 392);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(70, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 226);
            this.panel2.TabIndex = 8;
            // 
            // lblWrongUsername
            // 
            this.lblWrongUsername.AutoSize = true;
            this.lblWrongUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblWrongUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongUsername.ForeColor = System.Drawing.Color.White;
            this.lblWrongUsername.Location = new System.Drawing.Point(70, 340);
            this.lblWrongUsername.Name = "lblWrongUsername";
            this.lblWrongUsername.Size = new System.Drawing.Size(0, 20);
            this.lblWrongUsername.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RogueLikeGame.Properties.Resources.mainbd22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(399, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLoadLastSave);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblWrongUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RogueLikeGame";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLoadLastSave;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.ListBox lbxScores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblWrongUsername;
    }
}

