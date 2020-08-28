/*
 * Author: Brett Montgomery
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent dragonborn waffle fries
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Provides the details of dragonborn waffle fries
    /// </summary>
    public class DragonbornWaffleFries
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
                        return 77;
                    case Size.Medium:
                        return 89;
                    case Size.Large:
                        return 100;
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
                        return 0.42;
                    case Size.Medium:
                        return 0.76;
                    case Size.Large:
                        return 0.96;
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
                    return "Small Dragonborn Waffle Fries";
                case Size.Medium:
                    return "Medium Dragonborn Waffle Fries";
                case Size.Large:
                    return "Large Dragonborn Waffle Fries";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}
