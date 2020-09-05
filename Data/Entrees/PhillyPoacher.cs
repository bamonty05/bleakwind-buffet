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
        /// <summary>
        /// Stores values of prices for the entree
        /// </summary>
        public double Price
        {
            get { return 7.23; }
        }

        /// <summary>
        /// Stores values of calories for the entree
        /// </summary>
        public uint Calories
        {
            get { return 784; }
        }

        private bool sirloin = true;

        /// <summary>
        /// Getter and setter for the private backing variable sirloin
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }

        private bool onion = true;

        /// <summary>
        /// Getter and setter for the private backing variable onion
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }

        private bool roll = true;

        /// <summary>
        /// Getter and setter for the private backing variable roll
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        /// <summary>
        /// Creates a list of special instructions based on the boolean values of the private backing variables
        /// </summary>
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

        /// <summary>
        /// Overrides the ToString() function and returns the name of the entree
        /// </summary>
        /// <returns>A string containing the name of selected entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}