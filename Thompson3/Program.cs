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
********************************************************************/


using NewVegasNS;

namespace NewVegasApp
{
    using static Global;
    class Program
    {

        /********************************************************************
        *** METHOD: static void Main(string[] args)                       ***
        *********************************************************************
        *** DESCRIPTION : This method will be the starting point at which ***
        ***               the code inside is executed when ran. In this   ***
        ***               method it will.      ***
        *** INPUT ARGS : n/a                                              ***
        *** OUTPUT ARGS : n/a                                             ***
        *** IN/OUT ARGS : n/a                                             ***
        *** RETURN : void - no value                                      ***
        ********************************************************************/


        static void Main(string[] args)
        {
            
            

            // Create a new Courier instance
            Courier c = new Courier();

            // Print the Courier instance using ToString
            Console.WriteLine(c.ToString());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("FIRST COPY");
            Console.WriteLine();
            Console.WriteLine();

            Courier cCopy = new Courier(c);
            Console.WriteLine(cCopy.ToString());

            cCopy.Armor = ArmorType.METAL;
            cCopy.Weapon = WeaponType.PISTOL;
            cCopy.Agility = 3;
            cCopy.Perception = 9;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("COPY UPDATE");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(cCopy.ToString());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("NEW");
            Console.WriteLine();
            Console.WriteLine();

            Courier newCourier = new Courier(5, 6, 4, 6, 7, 8, 9, ArmorType.POWER, WeaponType.RIFLE);
            Console.WriteLine(newCourier.ToString());
           
        }
    }
}

