/*
 * Author: Brett Montgomery
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent warrior water
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the details of warrior water
    /// </summary>
    public class WarriorWater
    {
        private Size size = Size.Small;

        /* getter and setter for the private backing variable size */
        public Size Size
        {
            get { return this.Size; }
            set { this.size = value; }
        }

        /* stores values of calories for each available size */
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /* stores values of prices for each available size */
        public double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.00;
                    case Size.Medium:
                        return 0.00;
                    case Size.Large:
                        return 0.00;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        private bool ice = true;

        /* getter and setter for the private backing variable ice */
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        private bool lemon = false;

        /* getter and setter for the private backing variable lemon */
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /* creates a list of special instructions based on the boolean values of the private backing variables */
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold ice");
                if (!Lemon) instructions.Add("Add lemon");

                return instructions;
            }
        }

        /* overrides the ToString() function and returns the size and name of the side */
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Warrior Water";
                case Size.Medium:
                    return "Medium Warrior Water";
                case Size.Large:
                    return "Large Warrior Water";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}