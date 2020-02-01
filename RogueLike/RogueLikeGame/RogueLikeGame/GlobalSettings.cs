using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace RogueLikeGame
{
    public class GlobalSettings
    {
        public int enemyDifficultyMultiplier = 1;    //Enemy dmg is calculated:   x * multiplier = dmg
        public int characterArmorMultiplier = 1;     //Character armor is calculated: (base + items) * multiplier = amount blocked 
                                                            //Ex: dragon deals 20 dmg, you have 10 armor = 10 dmg received
        public int characterDamageMultiplier = 1;    //Character damage is calculated: (base * items) * multiplier = amount dealt
        //   //Score of user, name of user
        public bool OnPlayerDeath = false;

        #region MusicSettings

        public string soundSource = Directory.GetCurrentDirectory() + @"\HumbleMatch.wav";
        public bool SoundToggle(bool musicOn)
        {
            SoundPlayer sound = new SoundPlayer(soundSource); //Find a way to dispose
            if(musicOn)
            {
                sound.Stop();
                return false;
            }
            else
            {
                sound.PlayLooping();
                return true;
            }
        }

        public void ChangeSoundImage(Button btn, bool musicOn)
        {
            if(musicOn)
            {
                btn.BackgroundImage = RogueLikeGame.Properties.Resources.musicDisable;
            }
            else
            {
                btn.BackgroundImage = RogueLikeGame.Properties.Resources.musicEnable;
            }
        }
        #endregion

        public void SaveNewSettings(int enemyDifficultyMultiplier, int characterArmorMultiplier, int characterDamageMultiplier, string soundSource, int weaponDropChance, int armorDropChance, int PoisonDropChance)
        {
            this.enemyDifficultyMultiplier = enemyDifficultyMultiplier;
            this.characterArmorMultiplier = characterArmorMultiplier;
            this.characterDamageMultiplier = characterDamageMultiplier;
            this.soundSource = soundSource;
            this.weaponDropChance = weaponDropChance;
            this.armorDropChance = armorDropChance;
            this.potionDropChance = PoisonDropChance;
            this.totalChance = this.potionDropChance;
        }

        //One step to the other is the amount of % you have for that item to drop ex: from 0-20 = weaponDropchance, from 20-40 armordropchance
        public int weaponDropChance = 33;
        public int armorDropChance = 66;
        public int potionDropChance = 99;

        public int totalChance = 99; //PotionDropChance has the MAX % Of which you will receive an item

        public int damageOnWrongAnswer = 40;
        public int damageOnFailedOpen = 20;

        public void OnApplicationExit(FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialog = MessageBox.Show($"Are you sure you want to exit? {Environment.NewLine}", "Warning", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
