using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogueLikeGame
{
    public partial class DeveloperSettings : Form
    {
        readonly GlobalSettings allSettings;
        readonly Items allItems;
        public DeveloperSettings(Items items, GlobalSettings globalSettings)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            nudArmorDropChance.Value = globalSettings.armorDropChance;
            nudCharacterArmorMultiplier.Value = globalSettings.characterArmorMultiplier;
            nudEnemyDifficultyMultiplier.Value = globalSettings.enemyDifficultyMultiplier;
            nudPotionsDropChance.Value = globalSettings.potionDropChance;
            nudWeaponDropChance.Value = globalSettings.weaponDropChance;
            nudCharacterDamageMultiplier.Value = globalSettings.characterDamageMultiplier;
            nudWrongAnswer.Value = globalSettings.damageOnWrongAnswer;
            nudTreasureChestOpen.Value = globalSettings.damageOnFailedOpen;
            tbxSoundSource.Text = globalSettings.soundSource;
            nudElderBossCounter.Value = globalSettings.elderDragonAction;
            nudBehemothCounter.Value = globalSettings.behemothAction;
            nudLifeReaperCounter.Value = globalSettings.lifeReaperAction;
            nudTimer.Value = globalSettings.timerInterval;

            this.allSettings = globalSettings;
            this.allItems = items;

            foreach (Mobs a in allItems.allMobs)
            {
                lbxMobs.Items.Add(a.Type);
            }

            foreach(Characters b in allItems.allCharacters)
            {
                lbxCharacters.Items.Add(b.CharacterName);
            }
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            allSettings.SaveNewSettings((int)nudEnemyDifficultyMultiplier.Value, (int)nudCharacterArmorMultiplier.Value,
                (int)nudCharacterDamageMultiplier.Value, tbxSoundSource.Text, (int)nudWeaponDropChance.Value,
                (int)nudArmorDropChance.Value, (int)nudPotionsDropChance.Value, (int)nudElderBossCounter.Value, 
                (int)nudBehemothCounter.Value, (int)nudLifeReaperCounter.Value, (int)nudTimer.Value);
            XmlSerialization.SerializeObject(allSettings);    //<--
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(lbxMobs.SelectedIndex != -1)
            {
                int index = lbxMobs.SelectedIndex;
                Mobs mob = allItems.allMobs[index];
                mob.AbilityChance = (int)nudMobAbchance.Value;
                mob.Damage = (double)nudMobDamage.Value;
                mob.EvadeChance = (int)nudMobEvChance.Value;
                mob.MaxHealth = (double)nudMobMaxHealth.Value;
                mob.Health = mob.MaxHealth;
                mob.SpawnChance = (int)nudMobSpawnCh.Value;
                XmlSerialization.SerializeObject(allItems);
            }
        }

        private void LbxMobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxMobs.SelectedIndex != -1)
            {
                int index = lbxMobs.SelectedIndex;
                Mobs mob = allItems.allMobs[index];

                nudMobAbchance.Value = mob.AbilityChance;
                nudMobDamage.Value = (decimal)mob.Damage;
                nudMobEvChance.Value = mob.EvadeChance;
                nudMobMaxHealth.Value = (decimal)mob.MaxHealth;
                nudMobSpawnCh.Value = mob.SpawnChance;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(lbxCharacters.SelectedIndex != -1)
            {
                int index = lbxCharacters.SelectedIndex;
                Characters ch = allItems.allCharacters[index];
                ch.AbilityCooldown = (int)nudCharacterAbCd.Value;
                ch.Armor = (int)nudCharacterArmor.Value;
                ch.Damage = (double)nudCharacterDamage.Value;
                ch.EvadeChance = (int)nudCharacterEvChance.Value;
                ch.MaxHealth = (int)nudCharacterMaxHealth.Value;
                ch.SecondChance = (int)nudCharacterSecondChance.Value;
                ch.UpdateArmor(tbxCharacterStartArmor.Text, allItems);
                ch.UpdateWeapon(tbxCharacterStartWeapon.Text, allItems);
                XmlSerialization.SerializeObject(allItems);
            }
        }

        private void LbxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxCharacters.SelectedIndex != -1)
            {
                int index = lbxCharacters.SelectedIndex;
                Characters ch = allItems.allCharacters[index];

                nudCharacterAbCd.Value = ch.AbilityCooldown;
                nudCharacterArmor.Value = ch.Armor;
                nudCharacterDamage.Value = (decimal)ch.Damage;
                nudCharacterEvChance.Value = ch.EvadeChance;
                nudCharacterMaxHealth.Value = ch.MaxHealth;
                nudCharacterSecondChance.Value = ch.SecondChance;

                tbxCharacterStartArmor.Text = ch.StartArmor.ArmorName;
                tbxCharacterStartWeapon.Text = ch.StartWeapon.WeaponName;
            }
        }

        int switcher = 0;
        private void BtnSaveItem_Click(object sender, EventArgs e)
        {
            if(switcher != 0 && lbxItems.SelectedIndex != -1)
            {
                int index = lbxItems.SelectedIndex;
                switch(switcher)
                {
                    case 1:
                        Weapons wep = allItems.allWeapons[index];
                        wep.DamageBase = (double)nudItemDamArm.Value;
                        wep.DropChance = (int)nudItemDropChance.Value;
                        wep.WeaponName = tbxItemName.Text;
                        wep.CriticalDamage = (int)nudCritEvade.Value;
                        XmlSerialization.SerializeObject(allItems);
                        break;
                    case 2:
                        Armor arm = allItems.allArmor[index];
                        arm.ArmorName = tbxItemName.Text;
                        arm.ItemArmor = (int)nudItemDamArm.Value;
                        arm.EvadeChance = (int)nudCritEvade.Value;
                        arm.DropChance = (int)nudItemDropChance.Value;
                        XmlSerialization.SerializeObject(allItems);
                        break;
                    case 3:
                        Potions pot = allItems.allPotions[index];
                        pot.PotionName = tbxItemName.Text;
                        pot.Damage = (int)nudItemDamArm.Value;
                        pot.DropChance = (int)nudItemDropChance.Value;
                        pot.IsHealthPotion = cbxIsHealthPot.Checked;
                        XmlSerialization.SerializeObject(allItems);
                        break;
                }
            }
        }

        private void ClearItems()
        {
            tbxItemName.Text = string.Empty;
            nudItemDamArm.Value = 0;
            nudItemDropChance.Value = 0;
            nudCritEvade.Value = 0;
            cbxIsHealthPot.Checked = false;
        }
        private void LbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxItems.SelectedIndex != -1)
            {
                int index = lbxItems.SelectedIndex;
                switch(switcher)
                {
                    case 1:
                        Weapons wep = allItems.allWeapons[index];
                        tbxItemName.Text = wep.WeaponName;
                        nudItemDamArm.Value = (decimal)wep.DamageBase;
                        nudItemDropChance.Value = wep.DropChance;
                        nudCritEvade.Value = wep.CriticalDamage;
                        break;
                    case 2:
                        Armor arm = allItems.allArmor[index];
                        tbxItemName.Text = arm.ArmorName;
                        nudItemDamArm.Value = arm.ItemArmor;
                        nudItemDropChance.Value = arm.DropChance;
                        nudCritEvade.Value = arm.EvadeChance;
                        break;
                    case 3:
                        Potions pot = allItems.allPotions[index];
                        tbxItemName.Text = pot.PotionName;
                        nudItemDamArm.Value = (decimal)pot.Damage;
                        nudItemDropChance.Value = pot.DropChance;
                        cbxIsHealthPot.Checked = pot.IsHealthPotion;
                        break;
                }
            }
        }

        private void BtnWeapons_Click(object sender, EventArgs e)
        {
            label21.Enabled = true;
            nudCritEvade.Enabled = true;
            label25.Enabled = false;
            cbxIsHealthPot.Enabled = false;
            switcher = 1;
            ClearItems();
            lbxItems.Items.Clear();
            foreach (Weapons a in allItems.allWeapons)
            {
                lbxItems.Items.Add(a.WeaponName);
            }
        }

        private void BtnArmor_Click(object sender, EventArgs e)
        {
            label21.Enabled = true;
            nudCritEvade.Enabled = true;
            label25.Enabled = false;
            cbxIsHealthPot.Enabled = false;
            switcher = 2;
            ClearItems();
            lbxItems.Items.Clear();
            foreach (Armor a in allItems.allArmor)
            {
                lbxItems.Items.Add(a.ArmorName);
            }
        }

        private void BtnPotions_Click(object sender, EventArgs e)
        {
            label21.Enabled = false;
            nudCritEvade.Enabled = false;
            label25.Enabled = true;
            cbxIsHealthPot.Enabled = true;
            switcher = 3;
            ClearItems();
            lbxItems.Items.Clear();
            foreach (Potions a in allItems.allPotions)
            {
                lbxItems.Items.Add(a.PotionName);
            }
        }
        bool restart = true;
        private void DeveloperSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (restart)
            {
                restart = false;
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if(File.Exists(Directory.GetCurrentDirectory() + @"\CurrentGlobalSettings.xml"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\CurrentGlobalSettings.xml");
            }
            if(File.Exists(Directory.GetCurrentDirectory() + @"\CurrentItems.xml"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\CurrentItems.xml");
            }
            restart = false;
            Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        private void BtnResetSave_Click(object sender, EventArgs e)
        {
            if(File.Exists(Directory.GetCurrentDirectory() + @"\CurrentUserSettings.xml"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\CurrentUserSettings.xml");
            }
        }
    }
}
