/*
 * Author: Brett Montgomery
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent candlehearth coffee
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the details of cnadlehearth coffee
    /// </summary>
    public class CandlehearthCoffee
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
                        return 7;
                    case Size.Medium:
                        return 10;
                    case Size.Large:
                        return 20;
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
                        return 0.75;
                    case Size.Medium:
                        return 1.25;
                    case Size.Large:
                        return 1.75;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        private bool ice = false;

        /* getter and setter for the private backing variable ice */
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        private bool roomForCream = false;

        /* getter and setter for the private backing variable roomForCream */
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        private bool decaf = false;

        /* getter and setter for the private backing variable decaf */
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /* creates a list of special instructions based on the boolean values of the private backing variables */
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Add ice");
                if (!RoomForCream) instructions.Add("Add cream");

                return instructions;
            }
        }

        /* overrides the ToString() function and returns the size and name of the side */
        public override string ToString()
        {
            if (Decaf)
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Decaf Candlehearth Coffee";
                    case Size.Medium:
                        return "Medium Decaf Candlehearth Coffee";
                    case Size.Large:
                        return "Large Decaf Candlehearth Coffee";
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Small:
                        return "Small Candlehearth Coffee";
                    case Size.Medium:
                        return "Medium Candlehearth Coffee";
                    case Size.Large:
                        return "Large Candlehearth Coffee";
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }
    }
}