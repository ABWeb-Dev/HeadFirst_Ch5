using System;
using System.Collections.Generic;
using System.Text;

namespace OwensNewDamageCalculator
{
    class SwordDamage
    {
        /// <summary>
        /// BASE_DAMAGE and FLAME_DAMAGE constant values
        /// <variable Name = "BASE_DAMAGE" AccessModifier = "private" Type = "int" Value = "3">Always used by
        /// CalculateDamage method to determine damage output</variable>
        /// <variable Name = "FLAME_DAMAGE" AccessModifier = "private" Type = "int" Value = "2">If the flaming 
        /// variable value is set to true, this value is used by CalculateDamage method to determine damage output</variable>
        /// </summary>
        private const int  BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        /// <summary>
        /// Class fields
        /// <variable Name = "roll" AccessModifier= "Private" Type = "int">Value of roll passed to constructor. This is set 
        /// and retrieved by the Roll property, used in CalculateDamage method to determine damage outpu</variable>
        /// <variable Name = "flaming" AccessModifier= "Private" Type = "bool">Set and retrieved by the Flaming property, used by conditional
        /// statement to determine if flaming was selected by user, if so, FLAME_DAMAGE is added to calculation in CalculateDamage method</variable>
        /// <variable Name = "magic" AccessModifier= "Private" Type = "bool">Set and retrieved by the Magic property, used by conditional
        /// statement to determine if magic was selected by users, if so magicMultiplier  (local variable in Calculate Damage method) is 
        /// applied to the CalculateDamage calculation.</variable>
        /// </summary>
        private int roll;
        private bool flaming;
        private bool magic;

        /// <summary>
        /// <property>Sets and gets instances' 3d6 roll value</property>
        /// </summary>
        public int Roll
        {
            get { return this.roll; }
            set { this.roll = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// <property>Sets and gets flaming value. True if checked, false otherwise</property>
        /// </summary>
        public bool Flaming
        {
            get { return this.flaming; }
            set { this.flaming = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// <property>Sets and gets magic value. True if checked, false otherwise</property>
        /// </summary>
        public bool Magic
        {
            get { return this.magic; }
            set { this.magic = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// <property>retains, sets and retrieves the calculated damage value</property>
        /// </summary>
        public int Damage { get; private set; }

        /// <summary>
        /// The constructor calculates damage based on default Magic
        /// and Flaming values and the starting 3d6 roll
        /// </summary>
        /// <param name="startingRoll"></param>
        public SwordDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

        /// <summary>
        /// Calculates the damage based on the currect properties
        /// </summary>
        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll + magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }
    }
}
