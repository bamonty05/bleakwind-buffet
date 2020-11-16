/*
 * Author: Brett Montgomery
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent fried miraak
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Provides the details of fried miraak
    /// </summary>
    public class FriedMiraak : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;

        /// <summary>
        /// Size of the side
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

        public override string Description
        {
            get { return "Perfectly prepared hash brown pancakes."; }
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
