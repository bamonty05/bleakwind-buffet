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
    public class FriedMiraak
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

        /* stores values of prices for each available size */
        public double Price
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

        /* overrides the ToString() function and returns the size and name of the side */
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
