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
        Form1 userForm;            //Pass this in order to restart 
        UserSettings user;         //Should ALWAYS be passed
        Mobs currentMob;           //TEMPORARY store of the current MOB that you're fighting | PASS WHEN NEEDED


        int choice = 0; //1 firstbutton 2secondbutton 3thirdbutton
        bool ability = false; //False = ability on cd, True = ability available
        bool userAttack = false; //If it's the users turn to attack

        bool firstSequence = true;
        bool secondSequence = false;

        bool firstButtonPressed = false;
        bool secondButtonPressed = false;
        bool thirdButtonPressed = false;

        bool encounter = false;

        bool riddleSetup = false;

        bool treasureEncounter = false;
        bool mobEncounter = false;
        bool riddleEncounter = false;

        public MainGUI(UserSettings user, Form1 form)
        { 
            InitializeComponent();
            this.user = user;
            this.userForm = form;
            //this.Height = 285;
            //this.Width = 580;
            GlobalSettings.ChangeSoundImage(btnMusic);
            FirstSequence();
        }

        #region IntroConcept
        private void FirstSequence()
        {
            if (firstSequence)
            {
                switch (choice)
                {
                    case 0:
                        StartNarrative();
                        ResetButtons();
                        break;
                    case 1:
                        ContinueNarrative();
                        ResetButtons();
                        break;
                    case 2:
                        ContinueNarrative2();
                        UpdatePlayerStatistics();
                        ResetButtons();
                        break;
                    case 3:
                        FirstChoiceNarrative();
                        UpdateItemsList();
                        ResetButtons();
                        break;
                    case 4:
                        if (firstButtonPressed)
                        {
                            FirstChoiceOptionA();
                        }
                        else if (secondButtonPressed)
                        {
                            FirstChoiceOptionB();
                        }
                        else if (thirdButtonPressed)
                        {
                            FirstChoiceOptionC();
                        }
                        ResetButtons();
                        break;
                    case 5:
                        SecondChoiceNarraitve();
                        ResetButtons();
                        break;
                    case 6:
                        if (firstButtonPressed)
                        {
                            SecondChoiceOptionA();
                        }
                        else if (secondButtonPressed)
                        {
                            SecondChoiceOptionB();
                        }
                        ResetButtons();
                        break;
                }
            }
        }

        private void ResetButtons()
        {
            firstButtonPressed = false;
            secondButtonPressed = false;
            thirdButtonPressed = false;
        }

        private void StartNarrative()
        {
            tbxNarrative.Text = TextNarrative.Prologue;
            btnOptionA.Text = "Continue";
            btnOptionB.Enabled = false;
            btnOptionC.Enabled = false;
        }

        private void ContinueNarrative()
        {
            tbxNarrative.Text = TextNarrative.FirstSceneBD;
            btnOptionA.Text = "Continue";
        }

        private void ContinueNarrative2()
        {
            tbxNarrative.Text = TextNarrative.FirstSceneBD2;
            this.Height = 620;
            lblPlayerStatistics.Visible = true;
            btnOptionA.Text = "Continue";
        }

        private void FirstChoiceNarrative()
        {
            tbxNarrative.Text = TextNarrative.FirstChoiceNarrative;
            btnOptionB.Enabled = true;
            btnOptionC.Enabled = true;
            btnOptionA.Text = "Step In";
            btnOptionB.Text = "Check sign";
            btnOptionC.Text = "Go back home";
        }

        private void FirstChoiceOptionA()
        {
            tbxNarrative.Text = TextNarrative.FirstChoiceA;
            this.Width = 1050;
            gpxItems.Visible = true;
            gpxItems.Enabled = false;
            btnOptionA.Text = "Continue";
            btnOptionB.Enabled = false;
            btnOptionC.Enabled = false;
        }

        private void FirstChoiceOptionB()
        {
            tbxNarrative.Text = TextNarrative.FirstChoiceB;
            choice--;
        }

        private void FirstChoiceOptionC()
        {
            tbxNarrative.Text = TextNarrative.FirstChoiceC;
            user.userName = "Pussy";
            choice--;
        }

        private void SecondChoiceNarraitve()
        {
            tbxNarrative.Text = TextNarrative.SecondChoiceNarrative;
            btnOptionA.Text = "Fight spider";
            btnOptionB.Text = "Pray";
            btnOptionB.Enabled = true;
            btnOptionC.Enabled = false;
        }

        private void SecondChoiceOptionA()
        {
            gpxItems.Enabled = true;
            tbxNarrative.Text = TextNarrative.SecondChoiceA;
            gpxFight.Visible = true;

            btnUseItem.Enabled = false;
            btnHealthPot.Enabled = false;
            btnPoisonPot.Enabled = false;
            btnAbility.Enabled = false;

            currentMob = Items.ReturnNewMob(MobTypes.SPIDER);

            mobEncounter = true;

            StartFight();

            btnOptionB.Enabled = false;
            btnOptionA.Enabled = false;
        }

        private void SecondChoiceOptionB()
        {
            gpxItems.Enabled = true;
            tbxNarrative.Text = TextNarrative.SecondChoiceB;
            user.CurrentHealth -= 10;
            UpdatePlayerStatistics();
            gpxFight.Visible = true;
            currentMob = Items.ReturnNewMob(MobTypes.SPIDER);
            btnOptionB.Enabled = false;
            btnOptionA.Enabled = false;
        }

        private void SecondSequence()
        {
            if (secondSequence)
            {
                switch (choice)
                {
                    case 0:
                        tbxNarrative.Text = TextNarrative.SecondChoiceSuccess;
                        btnOptionA.Enabled = true;
                        btnOptionA.Text = "Continue";
                        break;
                    case 1:
                        tbxNarrative.Text = TextNarrative.SecondChoiceSuccess2;
                        btnOptionA.Enabled = true;
                        btnAbility.Visible = true;
                        break;
                    case 2:
                        tbxNarrative.Text = TextNarrative.ThirdChoiceNarrative;
                        btnOptionA.Text = "Continue";
                        TreasureSetup();
                        encounter = true;
                        break;
                        //END OF CURRENT TUTORIAL
                        //EXPERIMENTAL THINGS BELOW ONLY 
                        //secondSequence = false;
                        //encounter = true;
                }
            }
        }

        #endregion

        #region NarrativeButtons
        private void BtnOptionA_Click(object sender, EventArgs e)
        {
            choice++;
            firstButtonPressed = true;
            if(firstSequence)
            {
                FirstSequence();            //Tutorial 1
            }
            else if(secondSequence)
            {
                SecondSequence();           //Tutorial 2
            }
            else if(treasureEncounter)
            {
                OnTreasureEncounter();
            }
            else if(riddleSetup)
            {
                RiddleSetup();
            }
            else if(riddleEncounter)
            {
                OnRiddleEncounter();
            }
            else if(mobEncounter)
            {
                StartFight();
            }
            else if(encounter)
            {
                Encounters();
            }
        }

        private void BtnOptionB_Click(object sender, EventArgs e)
        {
            choice++;
            secondButtonPressed = true;
            if (firstSequence)
            {
                FirstSequence();            //Tutorial 1
            }
            else if (secondSequence)
            {
                SecondSequence();           //Tutorial 2
            }
            else if (treasureEncounter)
            {
                OnTreasureEncounter();
            }
        }

        private void BtnOptionC_Click(object sender, EventArgs e)
        {
            choice++;
            thirdButtonPressed = true;
            FirstSequence();
            SecondSequence();
        }
        #endregion

        private void Encounters()
        {
            if (encounter)
            {
                switch (Randomizer.RandomEncounter())
                {
                    case 0: //Mob
                        mobEncounter = true;
                        DisableNarrativeButton();
                        StartFight();
                        break;
                    case 1: //Treasure chests
                        TreasureSetup();
                        break;
                    case 2:
                        choice = 0;
                        riddleSetup = true;
                        RiddleSetup();
                        break;
                }
                encounter = false;
            }
        }
        #region CombatButtons
        private void BtnUseItem_Click(object sender, EventArgs e) //On use item button | Equippes the selected ITEM
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

        private void BtnAttack_Click(object sender, EventArgs e)
        {
            //Temporary experimental works | CHANGE LATER
            if (GlobalSettings.roundCounter > 0)
            {
                userAttack = !userAttack;
            }
            StartFight();
            UpdatePlayerStatistics();
            UpdateItemsList();
        }

        private void BtnAbility_Click(object sender, EventArgs e) //On ability button click
        {
            btnAbility.Enabled = false;
            userAttack = !userAttack;
            ability = true;
            StartFight();
            ability = false;
            UpdatePlayerStatistics();
            UpdateItemsList();
        }


        private void BtnFlee_Click(object sender, EventArgs e)
        {
            string checkIfFled = MobFight.OnPlayerFlee(user, currentMob);
            if (checkIfFled == null)
            {
                lbxCombatLog.Items.Add($"Sucessfully fled {currentMob.Type}");
                GlobalSettings.roundCounter = 0; //Overried the currentMob with a new mob.. has to be changed in the future

                lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                btnOptionA.Enabled = true;
                btnOptionA.Text = "Continue";
                encounter = true;
                mobEncounter = false;
            }
            else
            {
                lbxCombatLog.Items.Add(checkIfFled);
                if (user.currentHealth <= 0)
                {
                    OnPlayerDeath();
                }
                UpdatePlayerStatistics();
            }
            userAttack = !userAttack;
            DisableCombatButtons();
        }

        private void BtnHealthPot_Click(object sender, EventArgs e)
        {
            SearchForPotion("Health Potion");
        }

        private void BtnPoisonPot_Click(object sender, EventArgs e)
        {
            SearchForPotion("Poison Potion");
        }

        #endregion

        #region UpdateVisuals
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
            lblPlayerStatistics.Text = $"Health: {user.currentHealth}/{user.MaxHealth}  Damage: {user.TotalDamageWithoutCrit()}  Armor: {user.TotalArmor()} Evade Chance: {user.TotalEvadeChance()}";
            lblHealthPot.Text = $"Health Potions: {user.AmountPotions(true)}";
            lblPoisonPot.Text = $"Poison Potions: {user.AmountPotions(false)}";
            if (userAttack)
            {
                lblTurn.Text = $"Enemy turn";
            }
            else
            {
                lblTurn.Text = $"Player turn";
            }

            if (MobFight.currentRoundOfBuff > 0)
            {
                lblBuff.Text = "Healed Sucessfully";
            }
            else
            {
                lblBuff.Text = "";
            }

            if (MobFight.currentRoundOfDebuff > 0)
            {
                lblDebuff.Text = currentMob.DebuffString;
            }
            else
            {
                lblDebuff.Text = $"";
            }
        }

        private void UpdateProgressbar()    //Updates enemy healthbar
        {
            if (GlobalSettings.roundCounter == 0)          //On first round
            {
                lblMobHealth.Text = $"{currentMob.Type.ToString()}: {currentMob.MaxHealth}/{currentMob.MaxHealth}";
                prbEnemyHealth.Maximum = (int)currentMob.MaxHealth;
                prbEnemyHealth.Value = (int)currentMob.MaxHealth;
            }
            else
            {
                if (currentMob.Health > 0)           //If enemy is still alive
                {
                    prbEnemyHealth.Value = (int)currentMob.Health;
                    lblMobHealth.Text = $"{currentMob.Type.ToString()}: {currentMob.Health}/{currentMob.MaxHealth}";
                }
                else                               //If enemy ain't
                {
                    prbEnemyHealth.Value = 0;
                    lblMobHealth.Text = $"{currentMob.Type.ToString()}: 0/{currentMob.MaxHealth}";
                }
            }
        }


        private void UpdateAbilityButton() //Checks if the ability is off cooldown
        {
            if (user.currentAbilityCooldown >= user.AbilityCooldown && !userAttack && GlobalSettings.roundCounter != 0)
            {
                btnAbility.Enabled = true;
            }
        }
        #endregion

        #region MobFight
        private void CreateMob()
        {
            if (GlobalSettings.roundCounter == 0 && !firstSequence)          //Create a new random enemy only on start of fight
            {
                currentMob = Items.ReturnNewMob(Randomizer.EnemyRandomizer());      //CREATES A NEW MOB BASED ON RNG
                userAttack = false;                                                 //To ensure that the user will always hit first
            }
        }

        private void StartFight()           //The fight mechanics
        {
            if (mobEncounter)
            {
                CreateMob();

                if (currentMob.Health > 0 && GlobalSettings.roundCounter == 0)                     //On start of fight - Check if it's the first round
                {
                    lbxCombatLog.Items.Clear();
                    UpdateProgressbar();                                            //Update progressbar based on enemy MAX HEALTH
                    GlobalSettings.roundCounter++;
                    tbxNarrative.Text = MobFight.TBStartFight(currentMob, user); //On start of fight events
                    UpdateAbilityButton();                                           //Checks if you're ability is on CD;
                    lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                }
                else if (currentMob.Health > 0 && GlobalSettings.roundCounter != 0)                                //Actual fight <- if it ain't the first round
                {
                    GlobalSettings.roundCounter++;
                    if (userAttack)
                    {
                        lbxCombatLog.Items.Add(MobFight.OnPlayerHit(user, currentMob, ability)); //On player hit
                    }
                    else
                    {
                        lbxCombatLog.Items.Add(MobFight.OnEnemyHit(user, currentMob));                         //On enemy hit
                    }
                    UpdateProgressbar();
                    lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                    if (user.currentHealth <= 0) //On Player death 
                    {
                        OnPlayerDeath();
                    }
                    if (currentMob.Health <= 0) //On Mob Death
                    {
                        OnEnemyDeath();
                        MobFight.currentRoundOfDebuff = 0; //Nulls debuffs on enemy death
                    }
                    UpdateAbilityButton();
                    UpdatePlayerStatistics();
                    DisableCombatButtons();
                }
            }
        }

        #endregion

        #region OnPlayerMobDeath
        private void OnPlayerDeath()        //If the user dies
        {
            if (user.SecondChance <= 0)         //If the user doesn't have a SecondChance
            {
                GlobalSettings.startGame = false;
                DialogResult dialog = MessageBox.Show($"You died! {Environment.NewLine}Do you want to restart?", "Game over", MessageBoxButtons.YesNo);
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
            else
            {
                user.SecondChance--;
                user.currentHealth = user.MaxHealth / 2;
                MessageBox.Show("You had a second chance - sucessfully revived");
            }
        }

        private void OnEnemyDeath()     //If the enemy dies
        {
            MessageBox.Show(MobFight.DeathOfEnemy(user, currentMob)); //Calls event of enemy death
            UpdateProgressbar();
            GlobalSettings.roundCounter = 0;
            if (!firstSequence)
            {
                encounter = true;
                mobEncounter = false;
                btnOptionA.Enabled = true;
                btnOptionA.Text = "Continue";
            }
            Items.RepopulateTheLists();         //Repopulates the item OBJECTS because the enemy stats have CHANGED < replace with only mob repopulate?
            if(firstSequence)
            {
                encounter = false;
                btnOptionA.Enabled = true;
                btnOptionA.Text = "Continue";
                tbxNarrative.Text = "You managed to defeat the spider";
                mobEncounter = false;
                firstSequence = false;
                secondSequence = true;
                choice = -1;
            }
        }

        #endregion

        #region Misc
        private void MainGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalSettings.OnApplicationExit(e);
        }

        private void BtnMusic_Click(object sender, EventArgs e)
        {
            GlobalSettings.SoundToggle();
            GlobalSettings.ChangeSoundImage((Button)sender);
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
                            if (currentMob.Health <= 0)
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
        #endregion

        #region EnableDisableControls
        private void DisableCombatButtons()
        {
            if (!userAttack)
            {
                btnUseItem.Enabled = true;
                btnPoisonPot.Enabled = true;
                btnHealthPot.Enabled = true;
                btnFlee.Enabled = true;
            }
            else
            {
                btnFlee.Enabled = false;
                btnAbility.Enabled = false;
                btnUseItem.Enabled = false;
                btnPoisonPot.Enabled = false;
                btnHealthPot.Enabled = false;
            }
        }

        private void DisableNarrativeButton()
        {
            btnOptionA.Enabled = false;
            btnOptionB.Enabled = false;
            btnOptionC.Enabled = false;
        }
        #endregion

        #region TreasureEncounter
        private void TreasureSetup()
        {
            ResetButtons();
            firstSequence = false;
            secondSequence = false;
            btnOptionA.Enabled = true;
            btnOptionA.Text = "Open the chest";
            btnOptionB.Enabled = true;
            btnOptionB.Text = "Leave the chest";
            tbxNarrative.Text = "You've found a treasure chest";
            treasureEncounter = true;
        }


        private void OnTreasureEncounter()
        {
            if (treasureEncounter)
            {
                if (firstButtonPressed) //Open
                {
                    btnOptionB.Enabled = false;
                    tbxNarrative.Text = Randomizer.OnChestOpen(user);
                    if(user.CurrentHealth <= 0)
                    {
                        OnPlayerDeath();
                    }

                    if (tbxNarrative.Text == "You tried to open the chest, but a hostile mob was hiding inside!")
                    {
                        btnOptionA.Enabled = false;
                        treasureEncounter = false;
                        mobEncounter = true;

                        StartFight();
                    }
                    else
                    {
                        btnOptionA.Text = "Continue";
                        UpdateItemsList();
                        treasureEncounter = false;
                        encounter = true;
                    }
                }
                else if (secondButtonPressed) //Leave
                {
                    tbxNarrative.Text = "You didn't open the chest. It's contents remain unknown";
                    btnOptionA.Text = "Continue";
                    btnOptionB.Enabled = false;
                    treasureEncounter = false;
                    encounter = true;
                }

                if(secondSequence)
                {
                    secondSequence = false;
                    encounter = true;
                }
                UpdatePlayerStatistics();
            }
        }
        #endregion
        private void RiddleSetup()
        {
            if (riddleSetup)
            {
                switch (choice)
                {
                    case 0:
                        tbxNarrative.Text = "You've encountered a door with a riddle on it. You must complete it in order to continue";
                        ResetButtons();
                        firstSequence = false;
                        secondSequence = false;
                        btnOptionA.Enabled = true;
                        btnOptionA.Text = "Continue";
                        btnOptionB.Enabled = false;
                        riddleSetup = true;
                        break;
                    case 1:
                        riddleSetup = false;
                        tbxNarrative.Text = Randomizer.OnRiddleEncounter();
                        btnOptionA.Text = "Confirm answer";
                        riddleEncounter = true;
                        tbxRiddleAnswer.Visible = true;
                        break;
                }
            }
        }

        private void OnRiddleEncounter()
        {
            if (riddleEncounter)
            {
                if (TextNarrative.riddles.ContainsKey(tbxNarrative.Text))
                {
                    if (tbxRiddleAnswer.Text == TextNarrative.riddles[tbxNarrative.Text])
                    {
                        tbxNarrative.Text = "Your answer is correct";
                    }
                    else
                    {
                        tbxNarrative.Text = TextNarrative.RiddleWrongAnswer;
                        user.CurrentHealth -= GlobalSettings.damageOnWrongAnswer;
                        if(user.CurrentHealth <= 0)
                        {
                            OnPlayerDeath();
                        }
                    }
                }
                tbxRiddleAnswer.Text = "";
                tbxRiddleAnswer.Visible = false;
                riddleEncounter = false;
                encounter = true;
            }
        }
    }
}
