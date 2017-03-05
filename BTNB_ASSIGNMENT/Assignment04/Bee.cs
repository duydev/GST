using System;

namespace Assignment04
{
    class Bee
    {
        protected float health = 100F;
        protected float minHealth = 0;

        public float Health
        {
            get
            {
                return health;
            }
        }

        public void damage(int damgeHealth)
        {
            if( damgeHealth < 0 || damgeHealth > 100 || health < minHealth )
            {
                return;
            }
            health -= (float)damgeHealth;
            health = health < 0 ? 0 : health; 
        }

        public override string ToString()
        {
            string output = "";
            string healthStatus = health < minHealth ? "Dead" : "Alive";
            output += "Health: " + health + " - " + healthStatus + Environment.NewLine;
            return output;
        }

    }
}
