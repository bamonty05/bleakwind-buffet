/*
 * Author: Brett Montgomery
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent vokun salad
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Provides the details of vokun salad
    /// </summary>
    public class VokunSalad
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
                        return 41;
                    case Size.Medium:
                        return 52;
                    case Size.Large:
                        return 73;
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
                        return 0.93;
                    case Size.Medium:
                        return 1.28;
                    case Size.Large:
                        return 1.82;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Creates a list of special instructions based on the boolean values of the private backing variables
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() function and returns the size and name of the side
        /// </summary>
        /// <returns>A string containing the size and name of selected side</returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Vokun Salad";
                case Size.Medium:
                    return "Medium Vokun Salad";
                case Size.Large:
                    return "Large Vokun Salad";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}
