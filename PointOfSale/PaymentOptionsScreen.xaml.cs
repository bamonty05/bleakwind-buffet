/*
 * Author: Brett Montgomery
 * Class name: PaymentOptionsScreen.xaml.cs
 * Purpose: User Control Class to represent the paymeny options screen
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Order;
using BleakwindBuffet.Data.CashDrawerViewModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptionsScreen.xaml
    /// </summary>
    public partial class PaymentOptionsScreen : UserControl
    {
        public PaymentOptionsScreen()
        {
            InitializeComponent();
        }

        // Click event handler for the Credit/Debit button
        void CreditDebit(object sender, RoutedEventArgs e)
        {
            double tempTotal = double.Parse(total.Text.ToString(), System.Globalization.NumberStyles.Currency);
            CardTransactionResult code = CardReader.RunCard(tempTotal);
            bool card = true;

            if (code == CardTransactionResult.Approved)
            {
                PrintReceipt(card);
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
                    menu.full.Children.Remove(this);
                    menu.DataContext = new Order();
                }

                Order.OrderNumber++;
            }
            else
            {
                MessageBox.Show(code.ToString());
            }            
        }

        // Click event handler for the Cash button
        void Cash(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);

            } while (!(parent is MainWindow || parent is null));
            if (parent is MainWindow menu)
            {
                CashDrawerScreen screen = new CashDrawerScreen();
                screen.SetValue(Grid.ColumnSpanProperty, 2);
                menu.full.Children.Add(screen);
                menu.full.Children.Remove(this);
                if (menu.DataContext is Order order)
                {
                    screen.DataContext = new CashDrawerViewModel(order.Total);
                }
            }
        }

        // Click event handler for the Cancel button
        void Cancel(object sender, RoutedEventArgs e)
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

        /// <summary>
        /// Method for printing the reciept
        /// </summary>
        /// <param name="card">Whether the customer is paying with a card or not</param>
        private void PrintReceipt(bool card)
        {
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

                if (card)
                {
                    RecieptPrinter.PrintLine("\nPayment Type:\tCredit\n\n\n");
                    RecieptPrinter.CutTape();
                }
                else
                {
                    RecieptPrinter.PrintLine("\nPayment Type:\tCash");
                    RecieptPrinter.CutTape();
                }
            }
        }
    }
}
