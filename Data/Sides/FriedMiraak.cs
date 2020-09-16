/*
 * Author: Brett Montgomery
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent fried miraak
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Provides the details of fried miraak
    /// </summary>
    public class FriedMiraak : Side
    {
        /// <summary>
        /// Stores values of calories for each available size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 151;
                    case Size.Medium:
                        return 236;
                    case Size.Large:
                        return 306;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Stores values of prices for each available size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.78;
                    case Size.Medium:
                        return 2.01;
                    case Size.Large:
                        return 2.88;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Creates a list of special instructions based on the boolean values of the private backing variables
        /// </summary>
        public override List<string> SpecialInstructions
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
                    return "Small Fried Miraak";
                case Size.Medium:
                    return "Medium Fried Miraak";
                case Size.Large:
                    return "Large Fried Miraak";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}
