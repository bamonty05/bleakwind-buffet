/*
 * Author: Brett Montgomery
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent philly poacher
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the details of the philly poacher
    /// </summary>
    public class PhillyPoacher
    {
        /* stores values of prices for each available size */
        public double Price
        {
            get { return 7.23; }
        }

        /* stores values of calories for each available size */
        public uint Calories
        {
            get { return 784; }
        }

        private bool sirloin = true;

        /* getter and setter for the private backing variable sirloin */
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }

        private bool onion = true;

        /* getter and setter for the private backing variable onion */
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }

        private bool roll = true;

        /* getter and setter for the private backing variable roll */
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        /* creates a list of special instructions based on the boolean values of the private backing variables */
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!sirloin) instructions.Add("Hold sirloin");
                if (!onion) instructions.Add("Hold onion");
                if (!roll) instructions.Add("Hold roll");

                return instructions;
            }
        }

        /* overrides the ToString() function and returns the size and name of the side */
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}