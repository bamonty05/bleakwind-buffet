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
using BleakwindBuffet.Data.CashDrawerViewModel;
using BleakwindBuffet.Data.Order;
using RoundRegister;
using BleakwindBuffet.Data;

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
            if(this.DataContext is CashDrawerViewModel drawer)
            {
                drawer.ApplyTransaction();
                
                DateTime currentTime = DateTime.Now;

                if (DataContext is Order order)
                {
                    RecieptPrinter.PrintLine("Order Number:\t" + Order.OrderNumber.ToString());
                    RecieptPrinter.PrintLine("\n" + currentTime.ToString() + "\n\n");

                    foreach (IOrderItem item in order)
                    {
                        RecieptPrinter.PrintLine(item.ToString() + "\t" + item.Price.ToString("C2") + "\n");
                        int temp = 0;
                        while (temp < item.SpecialInstructions.Count)
                        {
                            RecieptPrinter.PrintLine("\t" + item.SpecialInstructions[temp].ToString() + "\n");
                            temp++;
                        }
                    }

                    RecieptPrinter.PrintLine("\nSubtotal:\t" + order.Subtotal.ToString("C2"));
                    RecieptPrinter.PrintLine("\nTax:\t" + order.Tax.ToString("C2"));
                    RecieptPrinter.PrintLine("\nTotal:\t\t" + order.Total.ToString("C2"));

                    RecieptPrinter.PrintLine("\nPayment Type:\tCash");
                    RecieptPrinter.PrintLine("\nChange Owed:\t\t" + drawer.ChangeOwed.ToString("C2"));
                    RecieptPrinter.CutTape();
                }
            }

            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);

            } while (!(parent is MainWindow || parent is null));
            if (parent is MainWindow menu)
            {
                MenuSelection screen = new MenuSelection();
                OrderComponent orderComp = new OrderComponent();

                menu.displayBorder.Child = screen;
                menu.orderBorder.Child = orderComp;
                // Get back to menu selection screen
                menu.full.Children.Remove(this);
                menu.DataContext = new Order();
            }

            Order.OrderNumber++;
        }
    }
}
