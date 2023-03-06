
namespace NewVegasNS
{
    using static Global;
    public class Courier : NewVegas 
    {
        // Properties
        public ArmorType Armor { get; set; }
        public WeaponType Weapon { get; set; }


        //default
        public Courier() : base()
        {
            Armor = ArmorType.LEATHER;
            Weapon = WeaponType.KNIFE;
        }

        //overlaoded/parameterized constructor
        public Courier(int strength, int perception, int endurance, int charisma, int intelligence, int agility, int luck, ArmorType armor = ArmorType.LEATHER, WeaponType weapon = WeaponType.KNIFE) : base(strength, perception, endurance, charisma, intelligence, agility, luck)
        {
            Armor = armor;
            Weapon = weapon;
        }

        //copy
        public Courier(Courier character) : base (character)
        {
            Armor = character.Armor;
            Weapon = character.Weapon;
        }

        // Methods
        public override string ToString()
        {
            return  base.ToString () + $"\nArmor:          {Armor} \nWeapon:         {Weapon}";
        }
    }
}
