namespace RogueLikeGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnLoadLastSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 321);
            this.label1.TabIndex = 0;
            this.label1.Text = "\rWelcome to the world of Hellsgate.\r\rPlease enter your name:";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(91, 362);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(327, 43);
            this.tbxName.TabIndex = 1;
            this.tbxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxName_KeyDown);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(13, 434);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(185, 71);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
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
            this.btnMusic.Location = new System.Drawing.Point(454, 13);
            this.btnMusic.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(65, 56);
            this.btnMusic.TabIndex = 3;
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.BtnMusic_Click);
            // 
            // btnLoadLastSave
            // 
            this.btnLoadLastSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadLastSave.Location = new System.Drawing.Point(302, 434);
            this.btnLoadLastSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadLastSave.Name = "btnLoadLastSave";
            this.btnLoadLastSave.Size = new System.Drawing.Size(185, 71);
            this.btnLoadLastSave.TabIndex = 4;
            this.btnLoadLastSave.Text = "Load Game";
            this.btnLoadLastSave.UseVisualStyleBackColor = true;
            this.btnLoadLastSave.Click += new System.EventHandler(this.BtnLoadLastSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 554);
            this.Controls.Add(this.btnLoadLastSave);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnLoadLastSave;
    }
}

