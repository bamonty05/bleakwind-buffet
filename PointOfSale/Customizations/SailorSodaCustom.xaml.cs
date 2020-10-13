/*
 * Author: Brett Montgomery
 * Class name: SailorSodaCustom.xaml.cs
 * Purpose: User Control Class to represent the Sailor Soda customization screen
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

namespace PointOfSale.Customizations
{
    /// <summary>
    /// Interaction logic for SailorSodaCustom.xaml
    /// </summary>
    public partial class SailorSodaCustom : UserControl
    {
        public SailorSodaCustom()
        {
            InitializeComponent();
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
                menu.displayBorder.Child = new MenuSelection();
            }
        }
    }
}
