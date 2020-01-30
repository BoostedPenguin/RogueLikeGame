using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RogueLikeGame
{
    public partial class DeveloperSettings : Form
    {
        GlobalSettings allSettings;
        Items allItems;
        public DeveloperSettings(Items items, GlobalSettings globalSettings)
        {
            InitializeComponent();
            nudArmorDropChance.Value = globalSettings.armorDropChance;
            nudCharacterArmorMultiplier.Value = globalSettings.characterArmorMultiplier;
            nudEnemyDifficultyMultiplier.Value = globalSettings.enemyDifficultyMultiplier;
            nudPotionsDropChance.Value = globalSettings.potionDropChance;
            nudWeaponDropChance.Value = globalSettings.weaponDropChance;
            nudCharacterDamageMultiplier.Value = globalSettings.characterDamageMultiplier;
            tbxSoundSource.Text = globalSettings.soundSource;

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
                (int)nudArmorDropChance.Value, (int)nudPotionsDropChance.Value);
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
                ch.SecondChance = (int)nudCharacterEvChance.Value;
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
    }
}
