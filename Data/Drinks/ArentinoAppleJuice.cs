/*
 * Author: Brett Montgomery
 * Class name: ArentinoAppleJuice.cs
 * Purpose: Class used to represent arentino apple juice
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the details of arentino apple juice
    /// </summary>
    public class ArentinoAppleJuice
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
                        return 44;
                    case Size.Medium:
                        return 88;
                    case Size.Large:
                        return 132;
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
                        return 0.62;
                    case Size.Medium:
                        return 0.87;
                    case Size.Large:
                        return 1.01;
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

        /* creates a list of special instructions based on the boolean values of the private backing variables */
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Add ice");

                return instructions;
            }
        }

        /* overrides the ToString() function and returns the size and name of the side */
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Arentino Apple Juice";
                case Size.Medium:
                    return "Medium Arentino Apple Juice";
                case Size.Large:
                    return "Large Arentino Apple Juice";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}
