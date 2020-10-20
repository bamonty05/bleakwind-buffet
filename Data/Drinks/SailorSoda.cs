/*
 * Author: Brett Montgomery
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent sailor soda
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the details of sailor soda
    /// </summary>
    public class SailorSoda : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;

        /// <summary>
        /// Size of the drink
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SizeSmall"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SizeMedium"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SizeLarge"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <summary>
        /// Checks if size is small and sets size to small
        /// </summary>
        public override bool SizeSmall
        {
            get { return Size == Size.Small; }
            set
            {
                Size = Size.Small;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// Checks if size is medium and sets size to medium
        /// </summary>
        public override bool SizeMedium
        {
            get { return Size == Size.Medium; }
            set
            {
                Size = Size.Medium;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// Checks if size is large and sets size to large
        /// </summary>
        public override bool SizeLarge
        {
            get { return Size == Size.Large; }
            set
            {
                Size = Size.Large;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

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
            get { return flavor; }
            set
            {
                flavor = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorCherry"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorBlackberry"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorGrapefruit"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorLemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorPeach"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FlavorWatermelon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <summary>
        /// Checks if flavor if cherry and sets flavor to cherry
        /// </summary>
        public bool FlavorCherry
        {
            get { return Flavor == SodaFlavor.Cherry; }
            set
            {
                Flavor = SodaFlavor.Cherry;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// Checks if flavor if blackberry and sets flavor to blackberry
        /// </summary>
        public bool FlavorBlackberry
        {
            get { return Flavor == SodaFlavor.Blackberry; }
            set
            {
                Flavor = SodaFlavor.Blackberry;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// Checks if flavor if grapefruit and sets flavor to grapefruit
        /// </summary>
        public bool FlavorGrapefruit
        {
            get { return Flavor == SodaFlavor.Grapefruit; }
            set
            {
                Flavor = SodaFlavor.Grapefruit;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// Checks if flavor if lemon and sets flavor to lemon
        /// </summary>
        public bool FlavorLemon
        {
            get { return Flavor == SodaFlavor.Lemon; }
            set
            {
                Flavor = SodaFlavor.Lemon;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// Checks if flavor if peach and sets flavor to peach
        /// </summary>
        public bool FlavorPeach
        {
            get { return Flavor == SodaFlavor.Peach; }
            set
            {
                Flavor = SodaFlavor.Peach;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// Checks if flavor if watermelon and sets flavor to watermelon
        /// </summary>
        public bool FlavorWatermelon
        {
            get { return Flavor == SodaFlavor.Watermelon; }
            set
            {
                Flavor = SodaFlavor.Watermelon;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        private bool ice = true;

        /// <summary>
        /// Getter and setter for the private backing variable ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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