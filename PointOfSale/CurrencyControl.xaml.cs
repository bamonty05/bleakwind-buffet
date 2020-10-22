/*
 * Author: Brett Montgomery
 * Class name: CurrencyControl.xaml.cs
 * Purpose: User Control Class to represent the currency control 
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        public CurrencyControl()
        {
            InitializeComponent();
        }

        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.AffectsRender));

        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender));

        public int CustomerQuantity
        {
            get
            {
                return (int)GetValue(CustomerQuantityProperty);
            }
            set
            {
                SetValue(CustomerQuantityProperty, value);
            }
        }

        public int ChangeQuantity
        {
            get
            {
                return (int)GetValue(ChangeQuantityProperty);
            }
            set
            {
                SetValue(ChangeQuantityProperty, value);
            }
        }

        void AddCurrency(object sender, RoutedEventArgs e)
        {
            CustomerQuantity++;
            e.Handled = true;
        }

        void SubtractCurrency(object sender, RoutedEventArgs e)
        {
            CustomerQuantity--;
            e.Handled = true;
        }
    }
}
