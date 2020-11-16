/*
 * Author: Brett Montgomery
 * Class name: Combo.cs
 * Purpose: Class to implement a combination feature within the order
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.Data.Combo
{
    /// <summary>
    /// Contains the information for a combo for the order
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        // Event handler for property changed
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for the combo
        /// </summary>
        /// <param name="entree">Entree</param>
        /// <param name="side">Side</param>
        /// <param name="drink">Drink</param>
        public Combo(Entree entree, Side side, Drink drink)
        {
            Entree = entree;
            Side = side;
            Drink = drink;
        }

        /// <summary>
        /// General Property Changed notifier
        /// </summary>
        /// <param name="property"></param>
        protected void NotifyPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private Entree entree;

        /// <summary>
        /// Constructor for an entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                if(entree != null)
                {
                    entree.PropertyChanged -= PropertyChangedListener;
                }
                entree = value;
                entree.PropertyChanged += PropertyChangedListener;
                NotifyPropertyChanged("Entree");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private Side side;

        /// <summary>
        /// Constructor for a side
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (side != null)
                {
                    side.PropertyChanged -= PropertyChangedListener;
                }
                side = value;
                side.PropertyChanged += PropertyChangedListener;
                NotifyPropertyChanged("Side");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private Drink drink;

        /// <summary>
        /// Constructor for a drink
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (drink != null)
                {
                    drink.PropertyChanged -= PropertyChangedListener;
                }
                drink = value;
                drink.PropertyChanged += PropertyChangedListener;
                NotifyPropertyChanged("Drink");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Calculates the price of the combo with a discount
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 1;
            }
        }

        /// <summary>
        /// Calculates the total calories for the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        public string Description
        {
            get
            {
                return Entree.Description + Side.Description + Drink.Description;
            }
        }

        /// <summary>
        /// A list of the special Instructions for the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                specialInstructions.Add(Entree.ToString());
                specialInstructions.AddRange(Entree.SpecialInstructions);
                specialInstructions.Add(Side.ToString());
                specialInstructions.AddRange(Side.SpecialInstructions);
                specialInstructions.Add(Drink.ToString());
                specialInstructions.AddRange(Drink.SpecialInstructions);
                return specialInstructions;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PropertyChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                this.NotifyPropertyChanged("Price");
            }
            if (e.PropertyName == "Calories")
            {
                this.NotifyPropertyChanged("Calories");
            }
            if (e.PropertyName == "SpecialInstructions")
            {
                this.NotifyPropertyChanged("SpecialInstructions");
            }
        }
    }
}
