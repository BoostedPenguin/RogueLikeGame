using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public static class TextNarrative
    {
        //Use this static class to extract string 
        #region StartNarrative
        public static string Prologue = "Welcome to the world of Hellsgate. The game was designed based all around RNG. Depending on your luck you will" +
            "manage to fight different enemies, gather loot, explore the darkness surrounding the dungeon and fight powerful bosses. Have fun!";
        public static string FirstSceneBD = "It isn't every day that you find yourself in the bottom of a godforsaken dungeon," +
            "but yet the thrill of adventure and loot will make even the strongest men question their sanity";
        public static string FirstSceneBD2 = "You seek to find the Holly Grail. Legends say that Satan took it to the depths of Hell in" +
            "order to anger God. You are determined to find it.. whatever the cost"; //Enable character statistics


        public static string FirstChoiceNarrative = "You step into the ruins of an ancient city. On the Left you have an entrance to a dungeon" +
            "keep. On the Right you have there is a sign";
        public static string FirstChoiceA = "You step into the dungeon.. it appears to be an abandoned sewege system. You keep walking for" +
            "hours until you stumble on some lost gear. You pick them up and keep going forward."; //Show the lbxitems and btnuse .visible
        public static string FirstChoiceB = "The sign appears to be a picture of your mom. You seem confused."; //Only Display Redirect to A
        public static string FirstChoiceC = "You try to turn back, but the developer gets angry because you tried to ignore all of his work" +
            "and renames you to Pussy"; //user.username = "pussy" Redirect to A


        public static string SecondChoiceNarrative = "You get dizzy from all of the walking in circles. You stumble upon some cobweb.. and a giant" +
            "angry spider looks towards you";
        public static string SecondChoiceA = "You decide to fight the spider"; //Enable fight controls
        public static string SecondChoiceB = "You start to pray to whatever god you believe in but the spider doesnt seem to care. And bites you";
        //-10 health - start fight
        public static string SecondChoiceSuccess = "You managed to kill the spider. You find a magical amulet next to the spider. " +
            "Maybe that's why the spider was 4 meters in width? Magic?";
        public static string SecondChoiceSuccess2 = "You touch the amulet and you feel a power surge through your body. You have a special ability now";
        //Enable abilities
        #endregion
        #region MobText
        public static string SpiderEncounter1 = "stumbled on a gigantic spider";
        public static string SpiderEncounter2 = "stuck upon a spider nest, with the queen getting ready to attack";
        public static string SpiderEncounter3 = "An ugly gigantic spider sits on the way of ";

        public static string RatEncounter1 = "encountered a poisonous rat";
        public static string RatEncounter2 = "found a big mama rat";
        public static string RatEncounter3 = "stepped on the the tail of a giant rat";

        public static string ShadowEncounter1 = "witnessed a shadow passing through the wall";
        public static string ShadowEncounter2 = "felt his hands freezing after he saw a shadow";
        public static string ShadowEncounter3 = "A shadow tried to suck the brains of";

        public static string ZombieEncounter1 = "saw a zombie eating the flesh out of a corpse";
        public static string ZombieEncounter2 = "felt dizzy by the smell of a half-rotten zombie";
        public static string ZombieEncounter3 = "draw his weapon at the sight of a zombie";
        #endregion
    }
}
