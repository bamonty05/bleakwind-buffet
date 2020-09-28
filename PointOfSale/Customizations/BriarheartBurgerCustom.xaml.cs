/*
 * Author: Brett Montgomery
 * Class name: BriarheartBurgerCustom.xaml.cs
 * Purpose: User Control Class to represent the Briarheart Burger customization screen
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
    /// Interaction logic for BriarheartBurgerCustom.xaml
    /// </summary>
    public partial class BriarheartBurgerCustom : UserControl
    {
        public BriarheartBurgerCustom()
        {
            InitializeComponent();
        }

        // Click event handler for the Done button
        void Done(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new MenuSelection();
        }

        // Click event handler for the Cancel button
        void Cancel(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new MenuSelection();
        }
    }
}
