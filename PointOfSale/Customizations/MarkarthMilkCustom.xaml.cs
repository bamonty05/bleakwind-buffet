/*
 * Author: Brett Montgomery
 * Class name: MarkarthMilkCustom.xaml.cs
 * Purpose: User Control Class to represent the Markarth Milk customization screen
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
using BleakwindBuffet.Data.Combo;

namespace PointOfSale.Customizations
{
    /// <summary>
    /// Interaction logic for MarkarthMilkCustom.xaml
    /// </summary>
    public partial class MarkarthMilkCustom : UserControl
    {
        public MarkarthMilkCustom()
        {
            InitializeComponent();
        }

        // Constructor for Combo
        public Combo Combo
        {
            get;
            set;
        }

        // Click event handler for the Done button
        void Done(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow || parent is null));
            if (parent is MainWindow menu)
            {
                if (Combo == null)
                {
                    menu.displayBorder.Child = new MenuSelection();
                }
                else
                {
                    menu.displayBorder.Child = new ComboCustom() { DataContext = this.Combo };
                }
            }
        }
    }
}
