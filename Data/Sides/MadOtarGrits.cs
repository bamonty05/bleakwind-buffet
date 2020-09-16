/*
 * Author: Brett Montgomery
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent mad otar grits
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Provides the details of mad otar grits
    /// </summary>
    public class MadOtarGrits : Side
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
                        return 105;
                    case Size.Medium:
                        return 142;
                    case Size.Large:
                        return 179;
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
                        return 1.22;
                    case Size.Medium:
                        return 1.58;
                    case Size.Large:
                        return 1.93;
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
                    return "Small Mad Otar Grits";
                case Size.Medium:
                    return "Medium Mad Otar Grits";
                case Size.Large:
                    return "Large Mad Otar Grits";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}
