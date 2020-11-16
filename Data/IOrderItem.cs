/*
 * Author: Brett Montgomery
 * Class name: IOrderItem.cs
 * Purpose: Interface to be implemented in entrees, drinks, and sides
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface for basic aspects of a menu item
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// The Price of an item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The amount of calories in an item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// A lsit of special intrustions for the item
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// A string consisting of the items description
        /// </summary>
        string Description { get; }
    }
}
