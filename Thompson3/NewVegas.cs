/********************************************************************
*** NAME : Kyle Thompson                                          ***
*** CLASS : CSc 346                                               ***
*** ASSIGNMENT : Assignment #3                                    ***
*** DUE DATE : 3-10-23                                            ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Using VS Code create a user-defnined Abstract   ***
***               Data Type using C# classes named NewVegas,      ***
***               Global, and Courier. NewVegas.cs describes      ***
***               the current state of an object in NewVegas class***
***               instance                                        ***
********************************************************************/

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
        
        
        /*********************************************************************
        *** METHOD: public NewVegas(....)                                      ***
        **********************************************************************
        *** DESCRIPTION : This is the default/overloaded/parameterized     ***
        ***               constructor. If no attributes are set when       ***
        ***               creating a character all will be default of 5,   ***
        ***               otherwise set to what is specified.              ***
        *** INPUT ARGS : int strength = 5,                                 ***
        ***  int perception = 5, int endurance = 5, int charisma =5,       ***    
        ***  int intelligence = 5, int agility = 5, int luck = 5           ***                                         ***
        *** OUTPUT ARGS : n/a                                              ***
        *** IN/OUT ARGS : n/a                                              ***
        *** RETURN : returns a new instance of NewVegas object             ***
        *********************************************************************/
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

        /*********************************************************************
        *** METHOD: public NewVegas                                        ***
        **********************************************************************
        *** DESCRIPTION : This is the copy constructor which copies        ***
        ***               all attributes from one NewVegas object instance ***
        ***               to another NewVegas object instance              ***
        *** INPUT ARGS : NewVegas copy                                     ***                                         ***
        *** OUTPUT ARGS : n/a                                              ***
        *** IN/OUT ARGS : n/a                                              ***
        *** RETURN : n/a                                                   ***
        *********************************************************************/
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

        /*********************************************************************
        *** METHOD: public override string? ToString()                     ***
        **********************************************************************
        *** DESCRIPTION : ToString method is a method to convert an object ***
        ***               to a string. It will display the Strength,       ***
        ***               Perception, Endurance,                           ***
        *** INPUT ARGS : n/a                                               ***                                         ***
        *** OUTPUT ARGS : n/a                                              ***
        *** IN/OUT ARGS : n/a                                              ***
        *** RETURN : returns a string that represents the object           ***
        *********************************************************************/
        public override string? ToString()
        {
            return $"Strength:       {Strength} \nPerception:     {Perception} \nEndurance:      {Endurance} \nCharisma:       {Charisma} \nIntelligence:   {Intelligence} \nAgility:        {Agility} \nLuck:           {Luck}";
        }
    }
}
