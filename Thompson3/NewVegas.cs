using System;

namespace NewVegasNS
{
    public class NewVegas
    {
        // Properties
        public int Strength { get; set; }
        public int Perception { get; set; }
        public int Endurance { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }
        
        // Constructors
        public NewVegas(int strength = 5, int perception = 5, int endurance = 5, int charisma = 5, int intelligence = 5, int agility = 5, int luck = 5)
        {
            Strength = strength;
            Perception = perception;
            Endurance = endurance;
            Charisma = charisma;
            Intelligence = intelligence;
            Agility = agility;
            Luck = luck;
        }

        public NewVegas(NewVegas character)
        {
            Strength = character.Strength;
            Perception = character.Perception;
            Endurance = character.Endurance;
            Charisma = character.Charisma;
            Intelligence = character.Intelligence;
            Agility = character.Agility;
            Luck = character.Luck;
        }

        public override string ToString()
        {
            return $"Strength:       {Strength} \nPerception:     {Perception} \nEndurance:      {Endurance} \nCharisma:       {Charisma} \nIntelligence:   {Intelligence} \nAgility:        {Agility} \nLuck:           {Luck}";
        }
    }
}
