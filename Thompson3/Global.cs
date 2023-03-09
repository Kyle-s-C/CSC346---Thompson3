/********************************************************************
*** NAME : Kyle Thompson                                          ***
*** CLASS : CSc 346                                               ***
*** ASSIGNMENT : Assignment #3                                    ***
*** DUE DATE : 3-10-23                                            ***
*** INSTRUCTOR : GAMRADT                                          ***
*********************************************************************
*** DESCRIPTION : Using VS Code create a user-defnined Abstract   ***
***               Data Type using C# classes named NewVegas,      ***
***               Global, and Courier. Global cass describes      ***
***               gloabl type information to be used in other     ***
***               solution/project components.                    ***
********************************************************************/

namespace NewVegasNS
{
    public static class Global 
    {
        public enum ArmorType { NONE, LEATHER, METAL, POWER }
        public enum WeaponType { NONE, KNIFE, PISTOL, RIFLE, SHOTGUN }
    }

}
