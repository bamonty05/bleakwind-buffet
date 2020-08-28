/*
 * Author: Brett Montgomery
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the smokehouse skeleton
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrées
{
    /// <summary>
    /// Provides the details of the smokehouse skeleton
    /// </summary>
    public class SmokehouseSkeleton
    {
        /* stores values of prices for each available size */
        public double Price
        {
            get { return 5.62; }
        }

        /* stores values of calories for each available size */
        public uint Calories
        {
            get { return 602; }
        }

        private bool sausageLink = true;

        /* getter and setter for the private backing variable sausageLink */
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }

        private bool egg = true;

        /* getter and setter for the private backing variable egg */
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        private bool hashBrowns = true;

        /* getter and setter for the private backing variable hashBrowns */
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set { hashBrowns = value; }
        }

        private bool pancake = true;

        /* getter and setter for the private backing variable pancake */
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }

        /* creates a list of special instructions based on the boolean values of the private backing variables */
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

        /* overrides the ToString() function and returns the size and name of the side */
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}