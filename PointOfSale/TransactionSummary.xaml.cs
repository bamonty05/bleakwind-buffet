/*
 * Author: Brett Montgomery
 * Class name: TransactionSummary.xaml.cs
 * Purpose: User Control Class to represent the sale finalization controls
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
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class TransactionSummary : UserControl
    {
        public TransactionSummary()
        {
            InitializeComponent();
        }

        void FinalizeSale(object sender, RoutedEventArgs e)
        {

        }
    }
}
