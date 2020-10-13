/*
 * Author: Brett Montgomery
 * Class name: OrderComponent.xaml.cs
 * Purpose: User Control Class to represent the order window
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Order;
using PointOfSale.Customizations;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        public OrderComponent()
        {
            InitializeComponent();            
        }

        // Remove button click event handler
        private void RemoveButtonClick(object sender, RoutedEventArgs e)
        {
            var screen = new OrderComponent();
            if (DataContext is Order order)
            {
                var btn = sender as Button;
                order.Remove(btn.DataContext as IOrderItem);
            }
        }

        // Edit item click event handler
        private void EditItemClick(object sender, SelectionChangedEventArgs e)
        {
            if (OrderList.SelectedItem == null)
            {
                return;
            }
            string itemString = OrderList.SelectedItem.ToString();

            if (itemString.Contains("Briarheart Burger"))
            {
                
                BriarheartBurger item = e.AddedItems[0] as BriarheartBurger;
                if (DataContext is Order order)
                {
                    var screen = new BriarheartBurgerCustom();
                    screen.DataContext = item;
                    
                }
            }
        }
    }
}
