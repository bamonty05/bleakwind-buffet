/*
 * Author: Brett Montgomery
 * Class name: Drink.cs
 * Purpose: Abstract class used to represent a drink
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        // Event handler for property changed
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        public virtual bool SizeSmall { get; set; }
        public virtual bool SizeMedium { get; set; }
        public virtual bool SizeLarge { get; set; }

        /// <summary>
        /// The name of the drink
        /// </summary>
        public string Name => ToString(); 

        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value> US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Desription of the entree
        /// </summary>
        public abstract string Description { get; }
    }
}
