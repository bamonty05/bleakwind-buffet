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

        /* getter and setter for the private backing variable size */
        public Size Size
        {
            get { return this.size; }
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

        /* stores values of prices for each available size */
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

        /* overrides the ToString() function and returns the size and name of the side */
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
