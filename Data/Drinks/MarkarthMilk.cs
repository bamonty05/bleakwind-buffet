/*
 * Author: Brett Montgomery
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent markarth milk
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the details of markarth milk
    /// </summary>
    public class MarkarthMilk
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
                        return 56;
                    case Size.Medium:
                        return 72;
                    case Size.Large:
                        return 93;
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
                        return 1.05;
                    case Size.Medium:
                        return 1.11;
                    case Size.Large:
                        return 1.22;
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

                if (Ice) instructions.Add("Add ice");

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
                    return "Small Markarth Milk";
                case Size.Medium:
                    return "Medium Markarth Milk";
                case Size.Large:
                    return "Large Markarth Milk";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}