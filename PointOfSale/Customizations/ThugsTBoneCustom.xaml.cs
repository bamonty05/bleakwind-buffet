/*
 * Author: Brett Montgomery
 * Class name: ThugsTBoneCustom.xaml.cs
 * Purpose: User Control Class to represent the Thugs T-Bone customization screen
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
    /// Interaction logic for ThugsTBoneCustom.xaml
    /// </summary>
    public partial class ThugsTBoneCustom : UserControl
    {
        public ThugsTBoneCustom()
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
