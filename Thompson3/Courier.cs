/********************************************************************
*** NAME : Kyle Thompson                                          ***
*** CLASS : CSc 346                                               ***
*** ASSIGNMENT : Assignment #3                                    ***
*** DUE DATE : 3-10-23                                            ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Using VS Code create a user-defnined Abstract   ***
***               Data Type using C# classes named NewVegas,      ***
***               Global, and Courier.                            ***
***               Courier.cs includes a default constructor,      ***
***               overloaded/parameterized constructor, and copy  ***
***               constructor.                                    ***
********************************************************************/
namespace NewVegasNS
{
    using static Global;
    public class Courier : NewVegas 
    {
        // properties
        public ArmorType Armor { get; set; }
        public WeaponType Weapon { get; set; }


        /*********************************************************************
        *** METHOD: public Courier() : base()                                        ***
        **********************************************************************
        *** DESCRIPTION : This is default constructor that initializes the ***
        ***               armor and weapon properties of the Courier to    ***
        ***               specific values. The base() calls the defualt    ***
        ***               default constructor of the base class which is   ***
        ***               from the class that Courier is derived from      ***
        *** INPUT ARGS : NewVegas copy                                     ***                                    
        *** OUTPUT ARGS : n/a                                              ***
        *** IN/OUT ARGS : n/a                                              ***
        *** RETURN : n/a                                                   ***
        *********************************************************************/
        public Courier() : base()
        {
            Armor = ArmorType.LEATHER;
            Weapon = WeaponType.KNIFE;
        }

    
        /*********************************************************************
        *** METHOD: public Courier(.....) : base(.....)                    ***
        **********************************************************************
        *** DESCRIPTION : This is overloaded/parameterized constructor.    ***
        ***               It initializes the Armor and Weapon properties   ***
        ***               of the Courier class based on the values of the  *** 
        ***               armor and weapon input arguments (or their       ***
        ***               default values if not specified). It also calls  ***
        ***               the constructor of the base class: base(strength,***
        ***               perception, endurance, charisma, intelligence,   ***
        ***               agility, luck)) to initialize the properties     ***
        ***               of the base class.                               ***
        *** INPUT ARGS : strength, perception, endurance, charisma,        ***
                         intelligence, agility, luck, armor, weapon        ***                                    
        *** OUTPUT ARGS : n/a                                              ***
        *** IN/OUT ARGS : n/a                                              ***
        *** RETURN : n/a                                                   ***
        *********************************************************************/
        public Courier(int strength, int perception, int endurance, int charisma, int intelligence, int agility, int luck, ArmorType armor = ArmorType.LEATHER, WeaponType weapon = WeaponType.KNIFE) : base(strength, perception, endurance, charisma, intelligence, agility, luck)
        {
            Armor = armor;
            Weapon = weapon;
        }
        
        /*********************************************************************
        *** METHOD: public Courier(Courier character) : base (character)   ***
        **********************************************************************
        *** DESCRIPTION : The copy constructor initializes the Armor and   ***
        ***               Weapon properties of the Courier class based on  ***
        ***               the corresponding properties of the input Courier***
        ***               object. It also calls the constructor of the base***
        ***               class (: base (character)) to initialize the     ***
        ***               properties of the base class.                    ***
        *** INPUT ARGS :  character - object that represents what is       ***
        **                to be copied                                     ***                                    
        *** OUTPUT ARGS : n/a                                              ***
        *** IN/OUT ARGS : n/a                                              ***
        *** RETURN : n/a                                                   ***
        *********************************************************************/
        public Courier(Courier character) : base (character)
        {
            Armor = character.Armor;
            Weapon = character.Weapon;
        }

        /*********************************************************************
        *** METHOD: public override string? ToString()                     ***
        **********************************************************************
        *** DESCRIPTION : The purpose of this method is to return a string ***
        ***               representation of the Courier object, including  ***
        ***               its base properties (inherited from the base     ***
        ***               class) as well as its Armor and Weapon           ***
        ***               properties. The base.ToString() method is called *** 
        ***               to get the string representation of the base     ***
        ***               properties, and then the Armor and Weapon        ***
        ***               properties are added to that string using        ***
        ***               string interpolation.                            ***
        *** INPUT ARGS : n/a                                               ***                                         ***
        *** OUTPUT ARGS : n/a                                              ***
        *** IN/OUT ARGS : n/a                                              ***
        *** RETURN : returns a string that represents the object           ***
        *********************************************************************/
        public override string? ToString()
        {
            return  base.ToString () + $"\nArmor:          {Armor} \nWeapon:         {Weapon}";
        }
    }
}
