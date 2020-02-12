using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public class Items
    {
        //Store all of the OBJECTS with their STATS and INFORMATION
        public List<Weapons> allWeapons = new List<Weapons>(); 
        public List<Armor> allArmor = new List<Armor>();
        public List<Potions> allPotions = new List<Potions>();
        public List<Mobs> allMobs = new List<Mobs>();
        public List<Characters> allCharacters = new List<Characters>();

        public void RepopulateTheLists() //Repopulates the lists (on enemy death) <-Repopulate only allmobs maybe
        {
            allWeapons.Clear();
            allArmor.Clear();
            allPotions.Clear();
            allMobs.Clear();
            allCharacters.Clear();
            AddAllArmor(); 
            AddAllWeapons();
            AddAllPotions();
            AddAllMobs();
            AddAllCharacters();
        }

        public void AddAllWeapons() //CHANGE this if you want to alter STATS
        {
                                      //Name  Damage  Dr.Chance  Crit.Chance
            allWeapons.Add(new Weapons("Blunt Sword", 2.0, 5, 35));
            allWeapons.Add(new Weapons("Sharp Sword", 4.0, 10, 30));
            allWeapons.Add(new Weapons("Dragon Sword", 8.0, 20, 10));
            allWeapons.Add(new Weapons("Battle Axe", 6.0, 15, 20));
            allWeapons.Add(new Weapons("Sceptar Of Divine", 15.0, 30, 5));
        }
        public void AddAllArmor()  //CHANGE this if you want to alter STATS
        {
                                    //Name  Armor  Ev.Chance  Dr.Chance
            allArmor.Add(new Armor("Basic Armor", 10, 10, 35));
            allArmor.Add(new Armor("Advanced Armor", 20, 10, 30));
            allArmor.Add(new Armor("Dragon Armor", 30, 15, 10));
            allArmor.Add(new Armor("Flesh Armor", 40, 15, 20));
            allArmor.Add(new Armor("Armor Of Divine", 50, 50, 5));
        }
        public void AddAllPotions()  //CHANGE this if you want to alter STATS
        {
                                    //Name  Damage Dr.Chance IsHealth
            allPotions.Add(new Potions("Health Potion", 50, 50, true));
            allPotions.Add(new Potions("Poison Potion", 30, 50, false));
        }
        public void AddAllMobs()  //CHANGE this if you want to alter STATS
        {
            //Bosses need to have 0% chance to spawn - It's not a random encounter

                         //Type    //Damage //Ev.Chance //Ability Chance //MaxHealth //SpawnChance //Boss //AbilityRounds
            allMobs.Add(new Mobs(MobTypes.SPIDER, 3, 10, 5, 40, 30, false, 1));
            allMobs.Add(new Mobs(MobTypes.RAT, 5, 15, 10, 50, 25, false, 3));
            allMobs.Add(new Mobs(MobTypes.SHADOW, 6, 25, 15, 40, 25, false, 7));
            allMobs.Add(new Mobs(MobTypes.ZOMBIE, 6, 10, 15, 50, 20, false, 1));

            allMobs.Add(new Mobs(MobTypes.ELDERDRAGON, 7, 10, 15, 120, 0, true, 3));
            allMobs.Add(new Mobs(MobTypes.FLESHBEHEMOTH, 5, 10, 20, 150, 0, true, 15));
            allMobs.Add(new Mobs(MobTypes.LIFEREAPER, 9, 10, 20, 120, 0, true, 1));
        }

        public void AddAllCharacters()
        {
                                           //Type   //Health   //Damage multiplier //Base armor //EvadeCh //Ability cd
            allCharacters.Add(new Characters(GameCharacters.Berserker, 200, 1.5, 10, 10, 5, "Blunt Sword", "Basic Armor", 0, this));
            allCharacters.Add(new Characters(GameCharacters.Ghost, 150, 2, 8, 20, 20, "Blunt Sword", "Basic Armor", 1, this));
            allCharacters.Add(new Characters(GameCharacters.GodKnight, 250, 1, 15, 5, 20, "Blunt Sword", "Basic Armor", 0, this));
        }

        public Mobs ReturnNewMob(MobTypes types) //Returns the OBJECT based on it's TYPE
        {
            return allMobs.FirstOrDefault(x => x.Type == types);
        }
    }
}
