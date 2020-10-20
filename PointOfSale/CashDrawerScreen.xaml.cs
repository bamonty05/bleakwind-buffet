/*
 * Author: Brett Montgomery
 * Class name: CashDrawerScreen.xaml.cs
 * Purpose: User Control Class to represent the cash drawer
 */

using BleakwindBuffet.Data.CashDrawerViewModel;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashDrawerScreen.xaml
    /// </summary>
    public partial class CashDrawerScreen : UserControl
    {
        public CashDrawerScreen()
        {
            InitializeComponent();
        }

        // Click event handler for the Return to Order button
        void ReturnToOrder(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);

            } while (!(parent is MainWindow || parent is null));

            if (parent is MainWindow menu)
            {
                menu.displayBorder.Child = new MenuSelection();
                menu.full.Children.Remove(this);
            }
        }
    }
}
