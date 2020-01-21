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
    public partial class MainGUI : Form
    {
        CharacterSelect character; //<- Pass this if nessesary 
        Form1 userForm;            //Pass this in order to close the app on exit

        UserSettings user;         //Should ALWAYS be passed
        Mobs currentMob;           //TEMPORARY store of the current MOB that you're fighting | PASS WHEN NEEDED


        int choice = 0; //1 firstbutton 2secondbutton 3thirdbutton
        int roundCounter = 0; //Stores the rounds that have passed since the fight started
        bool ability = false; //False = ability on cd, True = ability available
        public MainGUI(UserSettings user, CharacterSelect character, Form1 form)
        {
            InitializeComponent();
            this.user = user;
            this.character = character;
            this.userForm = form;
            StartNarrative();
        }
        //START 0F INTRO CONCEPT



        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            ContinueNarrative();
            ContinueNarrative2();
            FirstChoiceNarrative();
        }

        private void StartNarrative()
        {
            tbxNarrative.Text = TextNarrative.Prologue;
            btnOptionA.Text = "Continue";
            btnOptionB.Visible = true;
        }

        private void ContinueNarrative()
        {
            if (choice == 1)
            {
                tbxNarrative.Text = TextNarrative.FirstSceneBD;
                btnOptionA.Text = "Continue";
            }      
        }

        private void ContinueNarrative2()
        {
            if (choice == 2)
            {
                tbxNarrative.Text = TextNarrative.FirstSceneBD2;
                btnOptionA.Text = "Continue";
            }
        }

        private void FirstChoiceNarrative()
        {
            if (choice == 3)
            {
                tbxNarrative.Text = TextNarrative.FirstChoiceNarrative;
                btnOptionA.Text = "Continue";
            }
        }

        private void btnOptionA_Click(object sender, EventArgs e)
        {
            choice++;
        }


        //END OF INTRO CONCEPT
        private void btnOptionB_Click(object sender, EventArgs e)
        {
            //Temporary experimental works | CHANGE LATER
            StartFight();
            UpdatePlayerStatistics();
            UpdateItemsList();
        }

        private void UpdateItemsList() //Repopulates the items listbox > Adds all new items you've received
        {
            lbxCurrentItems.Items.Clear();
            lbxCurrentItems.Items.Add("All weapons:");
            foreach(Weapons a in user.weapons)
            {
                if (user.currentWeapon.WeaponName.Contains(a.WeaponName)) //If this item is currently equipped by the user
                {
                    lbxCurrentItems.Items.Add($"(+){a.WeaponName}\t{a.DamageBase} damage, {a.CriticalDamage}% Critical chance");
                }
                else //If it ain't
                {
                    lbxCurrentItems.Items.Add($"{a.WeaponName}\t{a.DamageBase} damage, {a.CriticalDamage}% Critical chance");
                }
            }
            lbxCurrentItems.Items.Add("");
            lbxCurrentItems.Items.Add("All armor:");
            foreach (Armor b in user.armor)
            {
                if (user.currentArmor.ArmorName.Contains(b.ArmorName))  //If this item is currently equipped by the user
                {
                    lbxCurrentItems.Items.Add($"(+){b.ArmorName}\t{b.ItemArmor} block, {b.EvadeChance}% EvadeChance");
                }
                else
                {
                    lbxCurrentItems.Items.Add($"{b.ArmorName}\t{b.ItemArmor} block, {b.EvadeChance}% EvadeChance");
                }
            }
        }
        private void UpdatePlayerStatistics() //Update the bottom player statistics
        {
            lblPlayerStatistics.Text = $"Health: {user.currentHealth}/{user.maxHealth}  Damage: {user.TotalDamageWithoutCrit()}  Armor: {user.TotalArmor()}";
            lblCurrentPotion.Text = $"Health Potions: {user.AmountPotions(true)} Poison Potions: {user.AmountPotions(false)} ";
        }
        private void StartFight()           //The fight mechanics
        {
            currentMob = Items.ReturnNewMob(MobTypes.SPIDER);                   //Creates a CONST spider as enemy | Change in future with random
            if (currentMob.health > 0 && roundCounter == 0)                     //On start of fight - Check if it's the first round
            {
                lbxCombatLog.Items.Clear();
                UpdateProgressbar();                                            //Update progressbar based on enemy MAX HEALTH
                roundCounter++;
                lbxCombatLog.Items.Add(MobFight.TBStartFight(currentMob, user)); //On start of fight events
                UpdateAbilityButton();                                           //Checks if you're ability is on CD;
                lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
            }
            else if(currentMob.health > 0 && roundCounter != 0)                                //Actual fight <- if it ain't the first round
            {
                lbxCombatLog.Items.Add(MobFight.OnPlayerHit(roundCounter, user, currentMob, ability)); //On player hit
                lbxCombatLog.Items.Add(MobFight.OnEnemyHit(user, currentMob));                         //On enemy hit
                UpdateProgressbar();
                lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                roundCounter++;
                if (user.currentHealth <= 0) //On Player death 
                {
                    OnPlayerDeath();
                }
                if (currentMob.health <= 0) //On Mob Death
                {
                    OnEnemyDeath();
                }
                UpdateAbilityButton();
            }
        }


        private void OnPlayerDeath()        //If the user dies
        {
            GlobalSettings.startGame = false;
            DialogResult dialog = MessageBox.Show($"You died! {Environment.NewLine} Do you want to restart?", "Game over", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes) //If yes, restart the game, if no - close application
            {
                userForm.Show();
                this.Dispose();             //Removes this form from the memory
            }
            else
            {
                userForm.Close();
            }
        }
        private void OnEnemyDeath()     //If the enemy dies
        {
            MessageBox.Show(MobFight.DeathOfEnemy(roundCounter, user, currentMob)); //Calls event of enemy death
            roundCounter = 0;
            Items.RepopulateTheLists();         //Repopulates the item OBJECTS because the enemy stats have CHANGED < replace with only mob repopulate?
        }

        private void UpdateProgressbar()    //Updates enemy healthbar
        {
            if (roundCounter == 0)          //On first round
            {
                lblMobHealth.Text = $"{currentMob.type.ToString()}: {currentMob.maxHealth}/{currentMob.maxHealth}";
                prbEnemyHealth.Maximum = currentMob.maxHealth;
                prbEnemyHealth.Value = currentMob.maxHealth;
            }
            else
            {
                if(currentMob.health > 0)           //If enemy is still alive
                {
                    prbEnemyHealth.Value = currentMob.health;
                    lblMobHealth.Text = $"{currentMob.type.ToString()}: {currentMob.health}/{currentMob.maxHealth}";
                }
                else                               //If enemy ain't
                {
                    prbEnemyHealth.Value = 0;
                    lblMobHealth.Text = $"{currentMob.type.ToString()}: 0/{currentMob.maxHealth}";
                }
            }
        }


        private void btnAbility_Click(object sender, EventArgs e) //On ability button click
        {
            ability = true;
            btnAbility.Enabled = false;
            StartFight();
            ability = false;
            UpdatePlayerStatistics();
            UpdateItemsList();
        }

        private void UpdateAbilityButton() //Checks if the ability is off cooldown
        {
            if (user.currentAbilityCooldown >= user.abilityCooldown)
            {
                btnAbility.Enabled = true;
            }
        }

        private void btnUseItem_Click(object sender, EventArgs e) //On use item button | Equippes the selected ITEM
        {
            if (lbxCurrentItems.SelectedItem != null)
            {
                string s = lbxCurrentItems.SelectedItem.ToString();
                foreach (Weapons wep in user.weapons)
                {
                    if (s.Contains(wep.WeaponName))
                    {
                        user.currentWeapon = wep;
                    }
                }
                UpdateItemsList();
                UpdatePlayerStatistics();
            }
        }

        private void btnOptionC_Click(object sender, EventArgs e)
        {

        }

        private void MainGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalSettings.OnApplicationExit(e);
        }
    }
}
