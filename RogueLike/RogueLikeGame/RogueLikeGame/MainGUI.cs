using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;   

namespace RogueLikeGame
{
    public partial class MainGUI : Form
    {
        readonly Items allItems;
        readonly GlobalSettings allSettings;
        readonly UserSettings user;         //Should ALWAYS be passed
        Mobs currentMob;                    //TEMPORARY store of the current MOB that you're fighting | PASS WHEN NEEDED
        readonly DictionaryEntries scores;
        bool musicOn = false;
        readonly List<Button> allButtons;
        readonly List<Label> allLabels;
        public MainGUI(UserSettings user, Items items, GlobalSettings allSettings, DictionaryEntries scores)
        { 
            InitializeComponent();
            this.scores = scores;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //Add all UI elements to a list
            allButtons = new List<Button>() { btnAbility, btnAttack, btnFlee, btnHealthPot, btnOptionA, btnOptionB,
            btnOptionC, btnPoisonPot, btnUseItem };
            allLabels = new List<Label>() { lblBuff, lblDebuff, lblHealthPot, lblMobHealth, lblPlayerStatistics, lblPoisonPot, lblTurn, lblMobStats };
            this.allItems = items;
            this.allSettings = allSettings;
            this.user = user;
            FirstSequence();
        }

        public MainGUI(Items items, GlobalSettings allSettings, DictionaryEntries scores)
        {
            InitializeComponent();
            this.scores = scores;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            allButtons = new List<Button>() { btnAbility, btnAttack, btnFlee, btnHealthPot, btnOptionA, btnOptionB,
            btnOptionC, btnPoisonPot, btnUseItem };
            allLabels = new List<Label>() { lblBuff, lblDebuff, lblHealthPot, lblMobHealth, lblPlayerStatistics, lblPoisonPot, lblTurn, lblMobStats };
            this.allItems = items;
            this.allSettings = allSettings;

            this.user = (UserSettings)XmlSerialization.DeserializeObject(0);
            this.currentMob = this.user.currentMob;
            PoppulateOnLoad();
        }

        public void PoppulateOnLoad()
        {
            gpxFight.Enabled = user.isGpxEnabled[0];
            gpxItems.Enabled = user.isGpxEnabled[1];
            for (int i = 0; i < user.textsBtn.Count; i++)
            {
                allButtons[i].Text = user.textsBtn[i];
            }
            for (int i = 0; i < user.isEnabled.Count; i++)
            {
                allButtons[i].Enabled = user.isEnabled[i];
            }
            for (int i = 0; i < user.textsLbl.Count; i++)
            {
                allLabels[i].Text = user.textsLbl[i];
            }
            for(int i = 0; i < user.lbxCombatText.Count; i++)
            {
                lbxCombatLog.Items.Add(user.lbxCombatText[i]);
            }
            lblTurn.Visible = user.isGpxEnabled[2];
            lblPlayerStatistics.Visible = user.isGpxEnabled[3];
            lblMobStats.Visible = user.isGpxEnabled[4];
            tbxNarrative.Text = user.lastNarrative;
            btnAbility.Visible = user.isGpxEnabled[5];
            btnFlee.Visible = user.isGpxEnabled[6];
            if (this.currentMob != null)
            {
                UpdateProgressbar();
            }
            UpdateItemsList();
        }

        #region IntroConcept
        private void FirstSequence()
        {
            if (user.firstSequence)
            {
                switch (user.choice)
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
                        if (user.firstButtonPressed)
                        {
                            FirstChoiceOptionA();
                        }
                        else if (user.secondButtonPressed)
                        {
                            FirstChoiceOptionB();
                        }
                        else if (user.thirdButtonPressed)
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
                        if (user.firstButtonPressed)
                        {
                            SecondChoiceOptionA();
                        }
                        else if (user.secondButtonPressed)
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
            user.firstButtonPressed = false;
            user.secondButtonPressed = false;
            user.thirdButtonPressed = false;
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
        }

        private void ContinueNarrative2()
        {
            tbxNarrative.Text = TextNarrative.FirstSceneBD2;
            lblPlayerStatistics.Visible = true;
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
            gpxItems.Visible = true;
            btnOptionA.Text = "Continue";
            btnOptionB.Enabled = false;
            btnOptionC.Enabled = false;
        }

        private void FirstChoiceOptionB()
        {
            tbxNarrative.Text = TextNarrative.FirstChoiceB;
            user.choice--;
        }

        private void FirstChoiceOptionC()
        {
            tbxNarrative.Text = TextNarrative.FirstChoiceC;
            user.userName = "Pussy";
            user.choice--;
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
            gpxFight.Enabled = true;
            lblTurn.Visible = true;
            lblPlayerStatistics.Visible = true;
            tbxNarrative.Text = TextNarrative.SecondChoiceA;
            gpxFight.Visible = true;
            currentMob = allItems.ReturnNewMob(MobTypes.SPIDER);
            user.mobEncounter = true;
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

            currentMob = allItems.ReturnNewMob(MobTypes.SPIDER);
            user.mobEncounter = true;
            StartFight();

            btnOptionB.Enabled = false;
            btnOptionA.Enabled = false;
        }

        private void SecondSequence()
        {
            if (user.secondSequence)
            {
                switch (user.choice)
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
                        btnFlee.Visible = true;
                        break;
                    case 2:
                        tbxNarrative.Text = TextNarrative.ThirdChoiceNarrative;
                        btnOptionA.Text = "Continue";
                        TreasureSetup();
                        user.encounter = true;
                        break;
                }
            }
        }

        #endregion

        #region NarrativeButtons
        private void BtnOptionA_Click(object sender, EventArgs e)
        {
            user.choice++;
            user.firstButtonPressed = true;
            if(user.firstSequence)
            {
                FirstSequence();            //Tutorial 1
            }
            else if(user.secondSequence)
            {
                SecondSequence();           //Tutorial 2
            }
            else if(user.treasureEncounter)
            {
                OnTreasureEncounter();
            }
            else if(user.riddleSetup)
            {
                RiddleSetup();
            }
            else if(user.riddleEncounter)
            {
                OnRiddleEncounter(allSettings);
            }
            else if(user.elderDragonSetup)
            {
                ElderDragonSetup();
            }
            else if(user.behemothSetup)
            {
                BehemothSetup();
            }
            else if(user.reaperSetup)
            {
                ReaperSetup();
            }
            else if(user.bossEncounter)
            {
                BossEncounter(user.type);
            }
            else if(user.mobEncounter)
            {
                StartFight();
            }
            else if(user.encounter)
            {
                Encounters();
            }
        }

        private void BtnOptionB_Click(object sender, EventArgs e)
        {
            user.choice++;
            user.secondButtonPressed = true;
            if (user.firstSequence)
            {
                FirstSequence();            //Tutorial 1
            }
            else if (user.secondSequence)
            {
                SecondSequence();           //Tutorial 2
            }
            else if (user.treasureEncounter)
            {
                OnTreasureEncounter();
            }
        }

        private void BtnOptionC_Click(object sender, EventArgs e)
        {
            user.choice++;
            user.thirdButtonPressed = true;
            FirstSequence();
            SecondSequence();
        }
        #endregion

        private void Encounters()
        {
            if (user.encounter)
            {
                user.actionCounter++;
                switch (Randomizer.RandomEncounter(user.actionCounter, allSettings))
                {
                    //Random Encounters
                    case 0: //Mob
                        user.mobEncounter = true;
                        DisableNarrativeButton();
                        StartFight();
                        break;
                    case 1: //Treasure chests
                        TreasureSetup();
                        break;
                    case 2: //Riddle
                        user.choice = 0;
                        user.riddleSetup = true;
                        RiddleSetup();
                        break;
                    //End of random encounters
                    case 3: //FirstBossEncounter
                        user.choice = 0;
                        user.elderDragonSetup = true;
                        ElderDragonSetup();
                        break;
                    case 4: //SecondBossEncounter
                        user.choice = 0;
                        user.behemothSetup = true;
                        BehemothSetup();
                        break;
                    case 5: //ThirdBossEncounter
                        user.choice = 0;
                        user.reaperSetup = true;
                        ReaperSetup();
                        break;
                }
                user.encounter = false;
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

                        user.userAttack = !user.userAttack;
                        lbxCombatLog.Items.Add($"{user.userName} equipped new gear");
                        btnUseItem.Enabled = false;
                        lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                    }
                    else
                    {
                        user.currentWeapon = checkingWeapon;

                        user.userAttack = !user.userAttack;
                        lbxCombatLog.Items.Add($"{user.userName} equipped new gear");
                        btnUseItem.Enabled = false;
                        lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                    }
                    DisableCombatButtons();
                    UpdateItemsList();
                    UpdatePlayerStatistics();
                }
            }
        }

        private void BtnAttack_Click(object sender, EventArgs e) //On Turn/Attack button click
        {   
            if (user.roundCounter > 0)
            {
                user.userAttack = !user.userAttack;
            }
            StartFight();
            UpdatePlayerStatistics();
            UpdateItemsList();
        }

        private void BtnAbility_Click(object sender, EventArgs e) //On ability button click
        {
            if (currentMob.Boss && user.CharacterName == GameCharacters.Ghost)
            {
                //Do nothing because you dont want to evade a boss fight
            }
            else
            {
                btnAbility.Enabled = false;
                user.userAttack = !user.userAttack;
                user.ability = true;
                StartFight();
                if (user.CharacterName == GameCharacters.Ghost)
                {
                    btnFlee.Enabled = false;
                    btnOptionA.Enabled = true;
                }
                user.ability = false;
                UpdatePlayerStatistics();
                UpdateItemsList();
            }
        }

        private void BtnFlee_Click(object sender, EventArgs e)
        {
            if (!currentMob.Boss && !   user.firstSequence)
            {
                string checkIfFled = MobFight.OnPlayerFlee(user, currentMob);
                if (checkIfFled == null)
                {
                    lbxCombatLog.Items.Add($"Sucessfully fled {currentMob.Type}");
                    user.roundCounter = 0; //Overried the currentMob with a new mob.. has to be changed in the future

                    lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                    btnOptionA.Enabled = true;
                    btnOptionA.Text = "Continue";
                    btnAttack.Enabled = false;
                    user.encounter = true;
                    user.mobEncounter = false;
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
                user.userAttack = !user.userAttack;
                DisableCombatButtons();
            }
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
            lblPlayerStatistics.Text = $"Player Stats:\nHealth: {user.currentHealth}/{user.MaxHealth}  Damage: {user.TotalDamageWithoutCrit(allSettings)}{Environment.NewLine}Armor: {user.TotalArmor(allSettings)} Evade Chance: {user.TotalEvadeChance()}";
            lblHealthPot.Text = $"Health Potions: {user.AmountPotions(true)}";
            lblPoisonPot.Text = $"Poison Potions: {user.AmountPotions(false)}";
            if(currentMob != null && currentMob.Health > 0)
            {
                lblMobStats.Text = $"Mob stats:\nType: {currentMob.Type}\nHealth: {currentMob.MaxHealth}\nDamage: {currentMob.Damage}\nEvade Chance: {currentMob.EvadeChance}\nAbility Chance {currentMob.AbilityChance}\nAbility: {currentMob.AbilityString()}";
            }
            else
            {
                lblMobStats.Text = "";
            }
            if (user.userAttack)
            {
                lblTurn.Text = $"Enemy turn";
            }
            else
            {
                lblTurn.Text = $"Player turn";
            }

            if (user.currentRoundOfBuff > 0)
            {
                lblBuff.Text = "Healed Sucessfully";
            }
            else
            {
                lblBuff.Text = "";
            }

            if (user.currentRoundOfDebuff > 0)
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
            prbEnemyHealth.Maximum = (int)currentMob.MaxHealth;
            if (user.roundCounter == 0)          //On first round
            {
                lblMobHealth.Text = $"{currentMob.Type.ToString()}: {currentMob.MaxHealth}/{currentMob.MaxHealth}";
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
            if (user.currentAbilityCooldown >= user.AbilityCooldown && !user.userAttack && user.roundCounter != 0)
            {
                btnAbility.Enabled = true;
            }
        }
        #endregion

        #region MobFight
        private void CreateMob()
        {
            if (user.roundCounter == 0 && !user.firstSequence && !user.bossEncounter)          //Create a new random enemy only on start of fight
            {
                currentMob = allItems.ReturnNewMob(Randomizer.EnemyRandomizer(allItems));      //CREATES A NEW MOB BASED ON RNG
                user.userAttack = false;                                                 //To ensure that the user will always hit first
            }
        }

        private void StartFight()           //The fight mechanics
        {
            if (user.mobEncounter)
            {
                lblTurn.Visible = true;
                btnAttack.Enabled = true;
                CreateMob();

                if (currentMob.Health > 0 && user.roundCounter == 0)                     //On start of fight - Check if it's the first round
                {
                    lbxCombatLog.Items.Clear();
                    UpdateProgressbar();                                            //Update progressbar based on enemy MAX HEALTH
                    user.roundCounter++;
                    tbxNarrative.Text = MobFight.TBStartFight(currentMob, user); //On start of fight events
                    UpdateAbilityButton();                                           //Checks if you're ability is on CD;
                    lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                }
                else if (currentMob.Health > 0 && user.roundCounter != 0)                                //Actual fight <- if it ain't the first round
                {
                    user.roundCounter++;
                    lblMobStats.Visible = true;
                    if (user.userAttack)
                    {
                        lbxCombatLog.Items.Add(MobFight.OnPlayerHit(user, currentMob, user.ability, allSettings)); //On player hit
                    }
                    else
                    {
                        lbxCombatLog.Items.Add(MobFight.OnEnemyHit(user, currentMob, allSettings));                         //On enemy hit
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
                        user.currentRoundOfDebuff = 0; //Nulls debuffs on enemy death
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
                string path = Directory.GetCurrentDirectory();
                path += @"\CurrentUserSettings.xml";
                if(File.Exists(path))
                {
                    File.Delete(path);
                }
                SerializeScores();
                DialogResult dialog = MessageBox.Show($"You died! {Environment.NewLine}Do you want to restart?", "Game over", MessageBoxButtons.YesNo);
                allSettings.OnPlayerDeath = true;
                if (dialog == DialogResult.Yes) //If yes, restart the game, if no - close application
                {
                    //startForm.Show();
                    //this.Dispose();
                    Process.Start(Application.ExecutablePath);
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                user.SecondChance--;
                user.currentHealth = user.MaxHealth / 2;
                MessageBox.Show("You had a second chance - sucessfully revived");
            }
        }

        private void SerializeScores()
        {
            scores.AddToLists(user.userName, user.actionCounter);
            XmlSerialization.SerializeObject(scores);
        }

        private void OnEnemyDeath()     //If the enemy dies
        {
            btnAttack.Enabled = false;
            lblMobStats.Visible = false;
            lblTurn.Visible = false;
            MessageBox.Show(MobFight.DeathOfEnemy(user, currentMob, allSettings, allItems)); //Calls event of enemy death
            UpdateProgressbar();
            user.roundCounter = 0;
            if (!user.firstSequence)
            {
                user.encounter = true;
                user.mobEncounter = false;
                btnOptionA.Enabled = true;
                btnOptionA.Text = "Continue";
            }
            this.currentMob.Health = currentMob.MaxHealth; //Repopulate the health for next encounter
            if (user.firstSequence)
            {
                user.encounter = false;
                btnOptionA.Enabled = true;
                btnOptionA.Text = "Continue";
                tbxNarrative.Text = "You managed to defeat the spider";
                user.mobEncounter = false;
                user.firstSequence = false;
                user.secondSequence = true;
                user.choice = -1;
            }
            if(user.bossEncounter)
            {
                user.bossEncounter = false;
                tbxNarrative.Text = "You managed to defeat one of the three great bosses";
                if (currentMob.Type == MobTypes.LIFEREAPER)
                {
                    tbxNarrative.Text = TextNarrative.LifeReaperDefeat;
                }
                user.encounter = true;
                user.mobEncounter = false;
                btnOptionA.Text = "Continue";
                btnOptionA.Enabled = true;
            }
        }

        #endregion

        #region Misc
        private void SaveDataToFile()
        {
            List<string> textsButton = new List<string>();
            List<string> textsLbl = new List<string>();
            List<bool> isEnabled = new List<bool>();
            List<string> lbxCombatStrings = new List<string>();
            List<bool> isGpxEnabled = new List<bool>()
            {
                gpxFight.Enabled,
                gpxItems.Enabled,
                lblTurn.Visible,
                lblPlayerStatistics.Visible,
                lblMobStats.Visible,
                btnAbility.Visible,
                btnFlee.Visible
            };
            foreach (Button a in allButtons)
            {
                textsButton.Add(a.Text);
                isEnabled.Add(a.Enabled);
            }
            foreach (Label a in allLabels)
            {
                textsLbl.Add(a.Text);
            }
            foreach (string g in lbxCombatLog.Items)
            {
                lbxCombatStrings.Add(g);
            }
            string t = tbxNarrative.Text;

            user.PoppulateOnClose(textsButton, isEnabled, textsLbl, lbxCombatStrings, t, isGpxEnabled);
            user.currentMob = this.currentMob;
            XmlSerialization.SerializeObject(user);
        }

        private void MainGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allSettings.OnPlayerDeath)
            {
                SaveDataToFile();
            }
            allSettings.OnApplicationExit(e);
        }

        private void BtnMusic_Click(object sender, EventArgs e)
        {
            musicOn = allSettings.SoundToggle(musicOn);
            allSettings.ChangeSoundImage((Button)sender, musicOn);
        }

        private void SearchForPotion(string name)
        {
            if (!user.userAttack)
            {
                foreach (Potions a in user.potions)
                {
                    if (a.PotionName == name)
                    {
                        if (a.IsHealthPotion) //Health potion
                        {
                            lbxCombatLog.Items.Add(MobFight.PotionUse(a, user, currentMob));
                            user.userAttack = !user.userAttack;
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
                            user.userAttack = !user.userAttack;
                            lbxCombatLog.SelectedIndex = lbxCombatLog.Items.Count - 1;
                            break;
                        }
                    }
                }
                UpdatePlayerStatistics();
                DisableCombatButtons();
            }
        }
        #endregion

        #region EnableDisableControls
        private void DisableCombatButtons()
        {
            if (!user.userAttack)
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
            user.firstSequence = false;
            user.secondSequence = false;
            btnOptionA.Enabled = true;
            btnOptionA.Text = "Open the chest";
            btnOptionB.Enabled = true;
            btnOptionB.Text = "Leave the chest";
            tbxNarrative.Text = "You've found a treasure chest";
            user.treasureEncounter = true;
        }

        private void OnTreasureEncounter()
        {
            if (user.treasureEncounter)
            {
                if (user.firstButtonPressed) //Open
                {
                    btnOptionB.Enabled = false;
                    tbxNarrative.Text = Randomizer.OnChestOpen(user, allSettings, allItems);
                    if(user.CurrentHealth <= 0)
                    {
                        OnPlayerDeath();
                    }

                    if (tbxNarrative.Text == "You tried to open the chest, but a hostile mob was hiding inside!")
                    {
                        btnOptionA.Enabled = false;
                        user.treasureEncounter = false;
                        user.mobEncounter = true;

                        StartFight();
                    }
                    else
                    {
                        btnOptionA.Text = "Continue";
                        UpdateItemsList();
                        user.treasureEncounter = false;
                        user.encounter = true;
                    }
                }
                else if (user.secondButtonPressed) //Leave
                {
                    tbxNarrative.Text = "You didn't open the chest. It's contents remain unknown";
                    btnOptionA.Text = "Continue";
                    btnOptionB.Enabled = false;
                    user.treasureEncounter = false;
                    user.encounter = true;
                }

                if(user.secondSequence)
                {
                    user.secondSequence = false;
                    user.encounter = true;
                }
                UpdatePlayerStatistics();
            }
        }
        #endregion
        private void RiddleSetup()
        {
            if (user.riddleSetup)
            {
                switch (user.choice)
                {
                    case 0:
                        tbxNarrative.Text = "You've encountered a door with a riddle on it. You must complete it in order to continue";
                        ResetButtons();
                        user.firstSequence = false;
                        user.secondSequence = false;
                        btnOptionA.Enabled = true;
                        btnOptionA.Text = "Continue";
                        btnOptionB.Enabled = false;
                        user.riddleSetup = true;
                        break;
                    case 1:
                        user.riddleSetup = false;
                        tbxNarrative.Text = Randomizer.OnRiddleEncounter();
                        btnOptionA.Text = "Confirm answer";
                        user.riddleEncounter = true;
                        tbxRiddleAnswer.Visible = true;
                        break;
                }
            }
        }

        private void OnRiddleEncounter(GlobalSettings allSettings)
        {
            if (user.riddleEncounter)
            {
                if (TextNarrative.riddles.ContainsKey(tbxNarrative.Text))
                {
                    if (tbxRiddleAnswer.Text.ToLower() == TextNarrative.riddles[tbxNarrative.Text])
                    {
                        tbxNarrative.Text = "Your answer is correct";
                    }
                    else
                    {
                        tbxNarrative.Text = TextNarrative.RiddleWrongAnswer;
                        user.CurrentHealth -= allSettings.damageOnWrongAnswer;
                        if(user.CurrentHealth <= 0)
                        {
                            OnPlayerDeath();
                        }
                        UpdatePlayerStatistics();
                    }
                }
                tbxRiddleAnswer.Text = "";
                tbxRiddleAnswer.Visible = false;
                user.riddleEncounter = false;
                user.encounter = true;
            }
        }

        private void ElderDragonSetup()
        {
            if(user.elderDragonSetup)
            {
                switch(user.choice)
                {
                    case 0:
                        tbxNarrative.Text = "Dragon Encounter";
                        ResetButtons();
                        btnOptionA.Enabled = true;
                        btnOptionA.Text = "Continue";
                        btnOptionB.Enabled = false;
                        user.elderDragonSetup = true;
                        break;
                    case 1:
                        tbxNarrative.Text = TextNarrative.BossInfo;
                        user.type = MobTypes.ELDERDRAGON;
                        user.bossEncounter = true;
                        user.elderDragonSetup = false;
                        break;
                }
            }
        }

        private void BehemothSetup()
        {
            if (user.behemothSetup)
            {
                switch (user.choice)
                {
                    case 0:
                        tbxNarrative.Text = "Behemoth Encounter";
                        ResetButtons();
                        btnOptionA.Enabled = true;
                        btnOptionA.Text = "Continue";
                        btnOptionB.Enabled = false;
                        user.behemothSetup = true;
                        break;
                    case 1:
                        tbxNarrative.Text = TextNarrative.BossInfo;
                        user.type = MobTypes.FLESHBEHEMOTH;
                        user.bossEncounter = true;
                        user.behemothSetup = false;
                        break;
                }
            }
        }

        private void ReaperSetup()
        {
            if (user.reaperSetup)
            {
                switch (user.choice)
                {
                    case 0:
                        tbxNarrative.Text = "Reaper Encounter";
                        ResetButtons();
                        btnOptionA.Enabled = true;
                        btnOptionA.Text = "Continue";
                        btnOptionB.Enabled = false;
                        user.reaperSetup = true;
                        break;
                    case 1:
                        tbxNarrative.Text = TextNarrative.BossInfo;
                        user.type = MobTypes.LIFEREAPER;
                        user.bossEncounter = true;
                        user.reaperSetup = false;
                        break;
                }
            }
        }

        private void BossEncounter(MobTypes mob)
        {
            if(user.bossEncounter)
            {
                currentMob = allItems.ReturnNewMob(mob);
                user.mobEncounter = true;
                StartFight();
                btnOptionA.Enabled = false;
            }
        }
    }
}
