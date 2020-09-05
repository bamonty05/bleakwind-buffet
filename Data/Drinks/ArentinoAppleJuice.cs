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

        /// <summary>
        /// Getter and setter for the private backing variable size
        /// </summary>
        public Size Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        /// <summary>
        /// Stores values of calories for each available size
        /// </summary>
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

        /// <summary>
        /// Stores values of prices for each available size
        /// </summary>
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

        /// <summary>
        /// Getter and setter for the private backing variable ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Creates a list of special instructions based on the boolean values of the private backing variables
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Add ice");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() function and returns the size and name of the drink
        /// </summary>
        /// <returns>A string containing the size and name of selected drink</returns>
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
