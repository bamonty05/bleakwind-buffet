/*
 * Author: Brett Montgomery
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent sailor soda
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the details of sailor soda
    /// </summary>
    public class SailorSoda : Drink
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
                        return 117;
                    case Size.Medium:
                        return 153;
                    case Size.Large:
                        return 205;                        
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
                        return 1.42;
                    case Size.Medium:
                        return 1.74;
                    case Size.Large:
                        return 2.07;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// Getter and setter for the private backing variable ice
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return this.flavor; }
            set { this.flavor = value; }
        }

        private bool ice = true;

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
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold ice");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() function and returns the size and name of the drink
        /// </summary>
        /// <returns>A string containing the size and name of selected drink</returns>
        public override string ToString()
        {
            string tempFlavor = "";
            switch (flavor)
            {
                case SodaFlavor.Blackberry:
                    tempFlavor = "Blackberry";
                    break;
                case SodaFlavor.Cherry:
                    tempFlavor = "Cherry";
                    break;
                case SodaFlavor.Grapefruit:
                    tempFlavor = "Grapefruit";
                    break;
                case SodaFlavor.Lemon:
                    tempFlavor = "Lemon";
                    break;
                case SodaFlavor.Peach:
                    tempFlavor = "Peach";
                    break;
                case SodaFlavor.Watermelon:
                    tempFlavor = "Watermelon";
                    break;
                default: throw new NotImplementedException("Unkown Flavor");
            }
            switch (Size)
            {
                case Size.Small:
                    return $"Small {tempFlavor} Sailor Soda";
                case Size.Medium:
                    return $"Medium {tempFlavor} Sailor Soda";
                case Size.Large:
                    return $"Large {tempFlavor} Sailor Soda";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}