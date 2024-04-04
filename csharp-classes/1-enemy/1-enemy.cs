﻿using System;

namespace Enemies
{
    public class Zombie
    {
        public int health;

        public Zombie()
        {
            health = 0;
        }

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }

        public int GetHealth()
        {
            return health;
        }
    }
}
