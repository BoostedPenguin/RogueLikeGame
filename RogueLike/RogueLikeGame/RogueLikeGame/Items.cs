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
            allArmor.Add(new Armor("Basic Armor", 2, 5, 35));
            allArmor.Add(new Armor("Advanced Armor", 4, 10, 30));
            allArmor.Add(new Armor("Dragon Armor", 8, 15, 10));
            allArmor.Add(new Armor("Flesh Armor", 12, 15, 20));
            allArmor.Add(new Armor("Armor Of Divine", 12, 50, 5));
        }
        public void AddAllPotions()  //CHANGE this if you want to alter STATS
        {
                                    //Name  Damage Dr.Chance IsHealth
            allPotions.Add(new Potions("Health Potion", 50, 50, true));
            allPotions.Add(new Potions("Poison Potion", 50, 50, false));
        }
        public void AddAllMobs()  //CHANGE this if you want to alter STATS
        {
            //Bosses need to have 0% chance to spawn - It's not a random encounter

                         //Type    //Damage //Ev.Chance //Ability Chance //MaxHealth //Boss
            allMobs.Add(new Mobs(MobTypes.SPIDER, 40, 10, 5, 40, 25, false));
            allMobs.Add(new Mobs(MobTypes.RAT, 4, 15, 10, 50, 25, false));
            allMobs.Add(new Mobs(MobTypes.SHADOW, 4, 25, 10, 40, 25, false));
            allMobs.Add(new Mobs(MobTypes.ZOMBIE, 4, 10, 15, 50, 25, false));

            allMobs.Add(new Mobs(MobTypes.ELDERDRAGON, 10, 10, 20, 50, 0, true));
            allMobs.Add(new Mobs(MobTypes.FLESHBEHEMOTH, 4, 10, 20, 500, 0, true));
            allMobs.Add(new Mobs(MobTypes.LIFEREAPER, 4, 10, 20, 50, 0, true));
        }

        public void AddAllCharacters()
        {
            allCharacters.Add(new Characters(GameCharacters.Berserker, 150, 1.5, 5, 10, 5, "Blunt Sword", "Basic Armor", 0, this));
            allCharacters.Add(new Characters(GameCharacters.Ghost, 100, 2, 2, 20, 15, "Blunt Sword", "Basic Armor", 1, this));
            allCharacters.Add(new Characters(GameCharacters.GodKnight, 200, 1, 8, 5, 20, "Blunt Sword", "Basic Armor", 0, this));
        }

        public Mobs ReturnNewMob(MobTypes types) //Returns the OBJECT based on it's TYPE
        {
            return allMobs.FirstOrDefault(x => x.Type == types);
        }
    }
}
