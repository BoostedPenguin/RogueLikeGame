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
        bool userAttack = false; //If it's the users turn to attack
        public MainGUI(UserSettings user, CharacterSelect character, Form1 form)
        {
            InitializeComponent();
            this.user = user;
            this.character = character;
            this.userForm = form;
            StartNarrative();
        }

        #region IntroConcept

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
        #endregion
        private void btnOptionB_Click(object sender, EventArgs e)
        {
            //Temporary experimental works | CHANGE LATER
            if (roundCounter > 0)
            {
                userAttack = !userAttack;
            }
            StartFight();
            UpdatePlayerStatistics();
            UpdateItemsList();
        }

        private void UpdateItemsList() //Repopulates the items listbox > Adds all new items you've received
        {
            lbxCurrentItems.Items.Clear();
            lbxCurrentItems.Items.Add("All weapons:");
            foreach (Weapons a in user.weapons)
            {
                string wepOutput = $"{a.WeaponName}\t{a.DamageBase} damage, {a.CriticalDamage}% Critical chance";

                if (user.currentWeapon.WeaponName.Contains(a.WeaponName)) //If this item is currently equipped by the user
                {
                    lbxCurrentItems.Items.Add($"(+) {wepOutput}");
                }
                else //If it ain't
                {
                    lbxCurrentItems.Items.Add($"{wepOutput}");
                }
            }
            lbxCurrentItems.Items.Add("");
            lbxCurrentItems.Items.Add("All armor:");
            foreach (Armor b in user.armor)
            {
                string armOutput = $"{b.ArmorName}\t{b.ItemArmor} block, {b.EvadeChance}% EvadeChance";
                if (user.currentArmor.ArmorName.Contains(b.ArmorName))  //If this item is currently equipped by the user
                {
                    lbxCurrentItems.Items.Add($"(+) {armOutput}");
                }
                else
                {
                    lbxCurrentItems.Items.Add($"{armOutput}");
                }
            }
        }

        private void UpdatePlayerStatistics() //Update the bottom player statistics
        {
            lblPlayerStatistics.Text = $"Health: {user.currentHealth}/{user.maxHealth}  Damage: {user.TotalDamageWithoutCrit()}  Armor: {user.TotalArmor()}";
            lblHealthPot.Text = $"Health Potions: {user.AmountPotions(true)}";
            lblPoisonPot.Text = $"Poison Potions: {user.AmountPotions(false)}";
            if(MobFight.currentRoundOfDebuff > 0)
            {
                lblDebuff.Text = currentMob.debuffString;
            }
            else
            {
                lblDebuff.Text = $"";
            }
        }
        private void StartFight()           //The fight mechanics
        {
            if (roundCounter == 0)          //Create a new random enemy only on start of fight
            {
                currentMob = Items.ReturnNewMob(Randomizer.EnemyRandomizer());
                userAttack = false; //To ensure that the user will always hit first
            }

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
                if(userAttack)
                {
                    lbxCombatLog.Items.Add(MobFight.OnPlayerHit(roundCounter, user, currentMob, ability)); //On player hit
                }
                else
                {
                    lbxCombatLog.Items.Add(MobFight.OnEnemyHit(user, currentMob));                         //On enemy hit
                }
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
                    MobFight.currentRoundOfDebuff = 0; //Nulls debuffs on enemy death
                }
                UpdateAbilityButton();
                UpdatePlayerStatistics();
                DisableIO();
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
            UpdateProgressbar();
            roundCounter = 0;
            Items.RepopulateTheLists();         //Repopulates the item OBJECTS because the enemy stats have CHANGED < replace with only mob repopulate?
        }

        private void UpdateProgressbar()    //Updates enemy healthbar
        {
            if (roundCounter == 0)          //On first round
            {
                lblMobHealth.Text = $"{currentMob.type.ToString()}: {currentMob.maxHealth}/{currentMob.maxHealth}";
                prbEnemyHealth.Maximum = (int)currentMob.maxHealth;
                prbEnemyHealth.Value = (int)currentMob.maxHealth;
            }
            else
            {
                if(currentMob.health > 0)           //If enemy is still alive
                {
                    prbEnemyHealth.Value = (int)currentMob.health;
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
            btnAbility.Enabled = false;
            userAttack = !userAttack;
            ability = true;
            StartFight();
            ability = false;
            UpdatePlayerStatistics();
            UpdateItemsList();
        }

        private void UpdateAbilityButton() //Checks if the ability is off cooldown
        {
            if (user.currentAbilityCooldown >= user.abilityCooldown && !userAttack && roundCounter != 0)
            {
                btnAbility.Enabled = true;
            }
        }

        private void DisableIO()
        {
            if(!userAttack)
            {
                btnUseItem.Enabled = true;
                btnPoisonPot.Enabled = true;
                btnHealthPot.Enabled = true;
            }
            else
            {
                btnAbility.Enabled = false;
                btnUseItem.Enabled = false;
                btnPoisonPot.Enabled = false;
                btnHealthPot.Enabled = false;
            }
        }

        private void btnUseItem_Click(object sender, EventArgs e) //On use item button | Equippes the selected ITEM
        {
            if (lbxCurrentItems.SelectedItem != null)
            {
                string itemString = lbxCurrentItems.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(itemString) && !itemString.Contains("All weapons:") && !itemString.Contains("All armor:"))
                {
                    var checkingWeapon = user.weapons.FirstOrDefault(x => itemString.Contains(x.WeaponName));
                    if (checkingWeapon == null)
                    {
                        user.currentArmor = user.armor.FirstOrDefault(x => itemString.Contains(x.ArmorName));

                        userAttack = !userAttack;
                        lbxCombatLog.Items.Add($"{user.userName} equipped new gear");
                        btnUseItem.Enabled = false;
                        lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                    }
                    else
                    {
                        user.currentWeapon = checkingWeapon;

                        userAttack = !userAttack;
                        lbxCombatLog.Items.Add($"{user.userName} equipped new gear");
                        btnUseItem.Enabled = false;
                        lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                    }

                    UpdateItemsList();
                    UpdatePlayerStatistics();
                }
            }
        }

        private void btnOptionC_Click(object sender, EventArgs e)
        {

        }

        private void MainGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalSettings.OnApplicationExit(e);
        }

        private void BtnHealthPot_Click(object sender, EventArgs e)
        {
            SearchForPotion("Health Potion");
        }

        private void BtnPoisonPot_Click(object sender, EventArgs e)
        {
            SearchForPotion("Poison Potion");
        }

        private void SearchForPotion(string name)
        {
            if (!userAttack)
            {
                foreach (Potions a in user.potions)
                {
                    if (a.PotionName == name)
                    {
                        if (a.IsHealthPotion) //Health potion
                        {
                            lbxCombatLog.Items.Add(MobFight.PotionUse(a, user, currentMob));
                            userAttack = !userAttack;
                            lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                            break;
                        }
                        else //Poison potion
                        {
                            lbxCombatLog.Items.Add(MobFight.PotionUse(a, user, currentMob));
                            if (currentMob.health <= 0)
                            {
                                OnEnemyDeath();
                            }
                            userAttack = !userAttack;
                            lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                            break;
                        }
                    }
                }
                UpdatePlayerStatistics();
            }
        }
    }
}
