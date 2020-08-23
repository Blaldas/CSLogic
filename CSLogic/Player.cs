using System;
using System.Collections.Generic;
using System.Text;

namespace CSLogic
{
    class Player
    {
        //hp and armor
        int hp;
        int armor;
        float helmet;
        //location and movment
        double locationX;
        double locationY;
        double locationZ;
        double speedX;       //real-time speed
        double speedY;       //real-time speed
        double speedZ;       //real-time speed
        //game
        int kills;
        int assists;
        int deaths;
        int points;
        int mvps;
        //weapons;
        Weapon primary;
        Weapon secundary;
        Weapon knife;
        Grenade[] greandeList;      //Array of class grenade, saves all the grenades
    
    
    
    }
}
