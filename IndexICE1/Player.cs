using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexICE1
{
    public class Player
    {
        int Health, Level;
        string PlayerTag, CharacterClass, CharacterRace, CharacterName; //dont have direct acess to these varibles

        public Player(int health, int level,
                  string playerTag,
                  string characterClass,
                  string characterRace,
                  string characterName)
        {

            Health = health;
            Level = level;
            PlayerTag = playerTag;
            CharacterClass = characterClass;
            CharacterRace = characterRace;
            CharacterName = characterName;
        }


        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Health;
                    case 1:
                        return Level;
                    case 2:
                        return PlayerTag;
                    case 3:
                        return CharacterClass;
                    case 4:
                        return CharacterRace;
                    case 5:
                        return CharacterName;
                    default:
                        return null;
                }
            }

            set
            {
                switch (index)
                {
                    case 0:
                        Health = (int)value;
                        break;
                    case 1:
                        Level = (int)value;
                        break;
                    case 2:
                        PlayerTag = (string)value;
                        break;
                    case 3:
                        CharacterClass = (string)value;
                        break;
                    case 4:
                        CharacterRace= (string)value;
                        break;
                    case 5:
                        CharacterName =(string)value;
                        break;
                    default:
                        throw new ArgumentException("Invalid index provided.");

                }

            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("health"))
                {
                    return Health;
                }
                if (attrName.ToLower().Equals("level"))
                {
                    return Level;
                }
                if (attrName.ToLower().Equals("playertag"))
                {
                    return PlayerTag;
                }
                if (attrName.ToLower().Equals("characterclass"))
                {
                    return CharacterClass;
                }
                if (attrName.ToLower().Equals("characterrace"))
                {
                    return CharacterRace;
                }
                if (attrName.ToLower().Equals("charactername"))
                {
                    return CharacterName;
                }
                return null;
            }

            set
            {
                if (attrName.ToLower().Equals("health"))
                {
                    Health = (int)value;
                }
                if (attrName.ToLower().Equals("levle"))
                {
                    Level= (int)value;
                }
                if (attrName.ToLower().Equals("playertag"))
                {
                    PlayerTag = (string)value;
                }
                if (attrName.ToLower().Equals("characterclass"))
                {
                    CharacterClass= (string)value;
                }
                if (attrName.ToLower().Equals("characterrace"))
                {
                    CharacterRace = (string)value;
                }
                if (attrName.ToLower().Equals("charactername"))
                {
                    CharacterName = (string)value;
                }

            }



        }
    }
}

