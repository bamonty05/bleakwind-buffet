/*
 * Author: Brett Montgomery
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the smokehouse skeleton
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the details of the smokehouse skeleton
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Stores values of prices for the entree
        /// </summary>
        public double Price
        {
            get { return 5.62; }
        }

        /// <summary>
        /// Stores values of calories for the entree
        /// </summary>
        public uint Calories
        {
            get { return 602; }
        }

        private bool sausageLink = true;

        /// <summary>
        /// Getter and setter for the private backing variable sausageLink
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }

        private bool egg = true;

        /// <summary>
        /// Getter and setter for the private backing variable egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        private bool hashBrowns = true;

        /// <summary>
        /// Getter and setter for the private backing variable hashBrowns
        /// </summary>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set { hashBrowns = value; }
        }

        private bool pancake = true;

        /// <summary>
        /// Getter and setter for the private backing variable pancake
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }

        /// <summary>
        /// Creates a list of special instructions based on the boolean values of the private backing variables
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!sausageLink) instructions.Add("Hold sausage");
                if (!egg) instructions.Add("Hold eggs");
                if (!hashBrowns) instructions.Add("Hold hash browns");
                if (!pancake) instructions.Add("Hold pancake");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() function and returns the name of the entree
        /// </summary>
        /// <returns>A string containing the name of selected entree</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}