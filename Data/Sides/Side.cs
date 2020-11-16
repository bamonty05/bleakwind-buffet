/*
 * Author: Brett Montgomery
 * Class name: Side.cs
 * Purpose: Abstract class used to represent a side
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        // Event handler for property changed
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        public virtual bool SizeSmall { get; set; }
        public virtual bool SizeMedium { get; set; }
        public virtual bool SizeLarge { get; set; }

        /// <summary>
        /// The name of the side
        /// </summary>
        public string Name => ToString();

        /// <summary>
        /// The price of the side
        /// </summary>
        /// <value> US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Desription of the entree
        /// </summary>
        public abstract string Description { get; }
    }
}
