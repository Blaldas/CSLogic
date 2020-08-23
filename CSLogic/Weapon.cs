using System;
using System.Collections.Generic;
using System.Text;

namespace CSLogic
{
    //this class represents the weapons;
    //I'm still tinking on how to implement the spray pattern, sinze I want a simpler solution than jkust creating a vector with the changes
    class Weapon
    {
        string weaponName;
        //time to ready
        float reloadTime;
        float fireReady;
        //bullets 
        int clip;
        int reservBullets;
        //firing
        int accuracy;
        int RPM;
        Damage Damage; //class
        float bulletPenetration;
        //spread
        int spreadStoped;
        int spreadCrouch;
        int spreadMoving;
        //monetary
        int price;
        int killAward;
        //moving
        int maxSpeed;
        //special
        bool silencer;
        bool burst;
        bool doubleZoom;
        bool singleZoom;


        //constructor, gets and sets need to much effort to do;


    }

}
