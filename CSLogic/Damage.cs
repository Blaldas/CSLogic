using System;
using System.Collections.Generic;
using System.Text;

namespace CSLogic
{
    //this class represents the output damage that a gun gives to an enimy;
    //the numbers are the base stats, and may change if the enymu is using kevlar with or without kevlar;
    class Damage
    {
        private int headshot;
        private int chestAndArms;
        private int stomach;
        private int legs;

        public Damage(int hs, int chest, int stomach, int legs)
        {
            this.headshot = hs;
            this.chestAndArms = chest;
            this.stomach = stomach;
            this.legs = legs;
        }

        public void setHeadshot(int headshot)
        {
            this.headshot = headshot;
        }
        public void setchestAndArms(int chestAndArms)
        {
            this.chestAndArms = chestAndArms;
        }
        public void setStomach(int stomach)
        {
            this.stomach = stomach;
        }
        public void setLegs(int legs)
        {
            this.legs = legs;
        }

        public int getHeadshot() { return headshot; }
        public int getChestAndArms() { return chestAndArms; }
        public int getStomach() { return stomach; }
        public int getLegs() { return legs; }

    }
}
