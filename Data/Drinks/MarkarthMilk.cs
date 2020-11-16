/*
 * Author: Brett Montgomery
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent markarth milk
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Provides the details of markarth milk
    /// </summary>
    public class MarkarthMilk : Drink, INotifyPropertyChanged
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

        public override string Description
        {
            get { return "Hormone-free organic 2% milk."; }
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