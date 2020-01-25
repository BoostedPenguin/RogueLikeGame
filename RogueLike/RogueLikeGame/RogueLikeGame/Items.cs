using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public static class Items
    {
        //Store all of the OBJECTS with their STATS and INFORMATION
        //PASS only ONE object of this CLASS !
        public static List<Weapons> allWeapons = new List<Weapons>(); 
        public static List<Armor> allArmor = new List<Armor>();
        public static List<Potions> allPotions = new List<Potions>();
        public static List<Mobs> allMobs = new List<Mobs>();
        
        public static void Poppulate() //On start populate the lists ^
        {
            AddAllArmor();
            AddAllWeapons();
            AddAllPotions();
            AddAllMobs();
        }

        public static void RepopulateTheLists() //Repopulates the lists (on enemy death) <-Repopulate only allmobs maybe
        {
            allWeapons.Clear();
            allArmor.Clear();
            allPotions.Clear();
            allMobs.Clear();
            AddAllArmor();
            AddAllWeapons();
            AddAllPotions();
            AddAllMobs();
        }
        public static void AddAllWeapons() //CHANGE this if you want to alter STATS
        {
                                      //Name  Damage  Dr.Chance  Crit.Chance
            allWeapons.Add(new Weapons("Blunt Sword", 2.0, 5, 35));
            allWeapons.Add(new Weapons("Sharp Sword", 4.0, 10, 30));
            allWeapons.Add(new Weapons("Dragon Sword", 8.0, 20, 10));
            allWeapons.Add(new Weapons("Battle Axe", 6.0, 15, 20));
            allWeapons.Add(new Weapons("Sceptar Of Divine", 15.0, 30, 5));
        }
        public static void AddAllArmor()  //CHANGE this if you want to alter STATS
        {
                                    //Name  Armor  Ev.Chance  Dr.Chance
            allArmor.Add(new Armor("Basic Armor", 2, 5, 35));
            allArmor.Add(new Armor("Advanced Armor", 4, 10, 30));
            allArmor.Add(new Armor("Dragon Armor", 8, 15, 10));
            allArmor.Add(new Armor("Flesh Armor", 12, 15, 20));
            allArmor.Add(new Armor("Armor Of Divine", 12, 50, 5));
        }
        public static void AddAllPotions()  //CHANGE this if you want to alter STATS
        {
                                    //Name  Damage Dr.Chance IsHealth
            allPotions.Add(new Potions("Health Potion", 50, 50, true));
            allPotions.Add(new Potions("Poison Potion", 50, 50, false));
        }
        public static void AddAllMobs()  //CHANGE this if you want to alter STATS
        {
                         //Type    //Damage //Ev.Chance //Ability Chance //MaxHealth
            allMobs.Add(new Mobs(MobTypes.SPIDER, 1, 10, 5, 40, 25));
            allMobs.Add(new Mobs(MobTypes.RAT, 20, 15, 10, 50, 25));
            allMobs.Add(new Mobs(MobTypes.SHADOW, 20, 25, 10, 40, 25));
            allMobs.Add(new Mobs(MobTypes.ZOMBIE, 20, 10, 15, 50, 25));
        }

        public static Mobs ReturnNewMob(MobTypes types) //Returns the OBJECT based on it's TYPE
        {
            return allMobs.FirstOrDefault(x => x.type == types);
        }
    }
}
