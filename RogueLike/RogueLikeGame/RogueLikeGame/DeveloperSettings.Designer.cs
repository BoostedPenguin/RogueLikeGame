namespace RogueLikeGame
{
    partial class DeveloperSettings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabCharacter = new System.Windows.Forms.TabPage();
            this.tabMob = new System.Windows.Forms.TabPage();
            this.tabPlayerSettings = new System.Windows.Forms.TabPage();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabCharacter);
            this.tabControl1.Controls.Add(this.tabMob);
            this.tabControl1.Controls.Add(this.tabPlayerSettings);
            this.tabControl1.Controls.Add(this.tabItems);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(790, 425);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General Settings";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabCharacter
            // 
            this.tabCharacter.Location = new System.Drawing.Point(4, 25);
            this.tabCharacter.Name = "tabCharacter";
            this.tabCharacter.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharacter.Size = new System.Drawing.Size(790, 425);
            this.tabCharacter.TabIndex = 1;
            this.tabCharacter.Text = "Character Settings";
            this.tabCharacter.UseVisualStyleBackColor = true;
            // 
            // tabMob
            // 
            this.tabMob.Location = new System.Drawing.Point(4, 25);
            this.tabMob.Name = "tabMob";
            this.tabMob.Size = new System.Drawing.Size(790, 425);
            this.tabMob.TabIndex = 2;
            this.tabMob.Text = "Mob Settings";
            this.tabMob.UseVisualStyleBackColor = true;
            // 
            // tabPlayerSettings
            // 
            this.tabPlayerSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPlayerSettings.Name = "tabPlayerSettings";
            this.tabPlayerSettings.Size = new System.Drawing.Size(790, 425);
            this.tabPlayerSettings.TabIndex = 3;
            this.tabPlayerSettings.Text = "Player save settings";
            this.tabPlayerSettings.UseVisualStyleBackColor = true;
            // 
            // tabItems
            // 
            this.tabItems.Location = new System.Drawing.Point(4, 25);
            this.tabItems.Name = "tabItems";
            this.tabItems.Size = new System.Drawing.Size(790, 425);
            this.tabItems.TabIndex = 4;
            this.tabItems.Text = "Items settings";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // DeveloperSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "DeveloperSettings";
            this.Text = "DeveloperSettings";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabCharacter;
        private System.Windows.Forms.TabPage tabMob;
        private System.Windows.Forms.TabPage tabPlayerSettings;
        private System.Windows.Forms.TabPage tabItems;
    }
}