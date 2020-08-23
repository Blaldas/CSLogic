using System;
using System.Collections.Generic;
using System.Text;

namespace CSLogic
{   //represents a genade
    //the effect of the grenade must be made based on it's name
    //wich means that no data about its effect, except the radius of effect, will be created
    //at least until I have a new ideia about what i am doing;

    /*              The inicial speed problem
     *  The grenade will be thrown by a player. To decide what the inicial speed is, the grenade must get the players speed on the 3 axis
     *  Then, it must calculate the total speed of the player.
     *  The grenade will calculate the % of total speed in each axis and will use that on the inicial throw speed.
     *  After that, it must add, to each axis (using the same formula) the inicial boost speed
     */ 
    class Grenade
    {
        string name;
        float radiusOfEffect;
        //location and movment
        double locationX;
        double locationY;
        double locationZ;
        double speedX;       //real-time speed
        double speedY;       //real-time speed
        double speedZ;       //real-time speed

        int inicialThowSpeed;       //inicial total speed to be distributed, check the inicial speed to more info
        int inicialBostSpeed;       //inicial boost speed to be distributed, check the inicial speed to more info
    }
}
