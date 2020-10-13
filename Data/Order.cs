/*
 * Author: Brett Montgomery
 * Class name: Order.cs
 * Purpose: Class to represent an order created in the GUI
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections;
using System.Collections.ObjectModel;

namespace BleakwindBuffet.Data.Order
{
    /// <summary>
    /// Contains all information for the current order
    /// </summary>
    public class Order : ICollection, INotifyPropertyChanged, INotifyCollectionChanged
    {
        public static uint orderNumber = 1;

        // List of each item in the order
        public List<IOrderItem> Items = new List<IOrderItem>();

        // Event handler for property changed
        public event PropertyChangedEventHandler PropertyChanged;

        // Event handler for collection changed
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        // Current order number
        public static uint OrderNumber { get { return orderNumber; } set { orderNumber = value; } }
        
        /// <summary>
        /// Calculates the total calories for the order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach(IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

        /// <summary>
        /// Sets sales tax rate for the items in the order
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;
        

        /// <summary>
        /// Calculates the subtotal of the order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subTotal = 0.0;
                foreach (IOrderItem item in Items)
                {
                    subTotal += item.Price;
                }
                return subTotal;
            }
        }

        /// <summary>
        /// Calculates the total tax on the order
        /// </summary>
        public double Tax
        {
            get
            {
                double tax = Subtotal * SalesTaxRate;
                return tax;
            }
        }

        /// <summary>
        /// Calculates the order total including sales tax
        /// </summary>
        public double Total
        {
            get
            {
                double total = Subtotal + Tax;
                return total;
            }
        }

        // Count property for ICollection interface
        public int Count => Items.Count;

        // IsSynchronized property for ICollection interface
        public bool IsSynchronized => throw new NotImplementedException();

        // SyncRoot property for ICollection interface
        public object SyncRoot => throw new NotImplementedException();

        

        /// <summary>
        /// Invokes property changed event when the subtotal, price, total, or calories changes
        /// </summary>
        /// <param name="item">Order item</param>
        public void Add(IOrderItem item)
        {
            Items.Add(item);
            item.PropertyChanged += OnItemChanged;

            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Invokes property changed event when the subtotal, price, total, or calories changes
        /// </summary>
        /// <param name="item">Order item</param>
        public void Remove(IOrderItem item)
        {
            int index = Items.IndexOf(item);
            Items.Remove(item);
            item.PropertyChanged -= OnItemChanged;

            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));

        }

        /// <summary>
        /// Invokes property changed event when an item in the existing order is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }

            if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        // CopyTo property for ICollection interface
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        // GetEnumerator property for ICollection interface
        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
