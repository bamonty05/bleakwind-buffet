/*
 * Author: Brett Montgomery
 * Class name: RoundRegister.cs
 * Purpose: Class to implement the round register for completing an order
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using RoundRegister;
using BleakwindBuffet.Data.Order;

namespace BleakwindBuffet.Data.CashDrawerViewModel
{
    /// <summary>
    /// Contains all the information for the Round Register
    /// </summary>
    public class CashDrawerViewModel : INotifyPropertyChanged
    {
        // Event handler for property changed
        public event PropertyChangedEventHandler PropertyChanged;

        public double OrderTotal
        {
            get;
            private set;
        }

        // Constructor for CashDrawerViewModel
        public CashDrawerViewModel(double total)
        {
            OrderTotal = total;
        }

        // Constructor for the Pennies
        public int Pennies
        {
            get => CashDrawer.Pennies;
            private set => CashDrawer.Pennies = value;            
        }

        private int changePennies = 0;
        // Constructor for Change Pennies
        public int ChangePennies
        {
            get
            {
                return changePennies;
            }
            private set
            {
                changePennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
            }
        }

        private int customerPennies = 0;
        // Constructor for Customer Pennies
        public int CustomerPennies
        {
            get
            {
                return customerPennies;
            }
            set
            {
                customerPennies = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerPennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the Nickels
        public int Nickles
        {
            get => CashDrawer.Nickels;
            private set => CashDrawer.Nickels = value;
        }

        private int changeNickles = 0;
        // Constructor for Change Nickels
        public int ChangeNickles
        {
            get
            {
                return changeNickles;
            }
            private set
            {
                changeNickles = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickles"));
            }
        }

        private int customerNickles = 0;
        // Constructor for Customer Nickels
        public int CustomerNickles
        {
            get
            {
                return customerNickles;
            }
            set
            {
                customerNickles = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerNickles"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the Dimes
        public int Dimes
        {
            get => CashDrawer.Dimes;
            private set => CashDrawer.Dimes = value;
        }

        private int changeDimes = 0;
        // Constructor for Change Dimes
        public int ChangeDimes
        {
            get
            {
                return changeDimes;
            }
            private set
            {
                changeDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
            }
        }

        private int customerDimes = 0;
        // Constructor for Customer Dimes
        public int CustomerDimes
        {
            get
            {
                return customerDimes;
            }
            set
            {
                customerDimes = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the Quarters
        public int Quarters
        {
            get => CashDrawer.Quarters;
            private set => CashDrawer.Quarters = value;
        }

        private int changeQuarters = 0;
        // Constructor for Change Quarters
        public int ChangeQuarters
        {
            get
            {
                return changeQuarters;
            }
            private set
            {
                changeQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
            }
        }

        private int customerQuarters = 0;
        // Constructor for Customer Quarters
        public int CustomerQuarters
        {
            get
            {
                return customerQuarters;
            }
            set
            {
                customerQuarters = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the Half Dollars
        public int HalfDollars
        {
            get => CashDrawer.HalfDollars;
            private set => CashDrawer.HalfDollars = value;
        }

        private int changeHalfDollars = 0;
        // Constructor for Change Half Dollars
        public int ChangeHalfDollars
        {
            get
            {
                return changeHalfDollars;
            }
            private set
            {
                changeHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHalfDollars"));
            }
        }

        private int customerHalfDollars = 0;
        // Constructor for Customer Half Dollars
        public int CustomerHalfDollars
        {
            get
            {
                return customerHalfDollars;
            }
            set
            {
                customerHalfDollars = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the Dollar Coins
        public int DollarCoins
        {
            get => CashDrawer.Dollars;
            private set => CashDrawer.Dollars = value;
        }

        private int changeDollarCoins = 0;
        // Constructor for Change Dollar Coins
        public int ChangeDollarCoins
        {
            get
            {
                return changeDollarCoins;
            }
            private set
            {
                changeDollarCoins = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDollarCoins"));
            }
        }

        private int customerDollarCoins = 0;
        // Constructor for Customer Dollar Coins
        public int CustomerDollarCoins
        {
            get
            {
                return customerDollarCoins;
            }
            set
            {
                customerDollarCoins = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDollarCoins"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the One Dollar Bills
        public int Ones
        {
            get => CashDrawer.Ones;
            private set => CashDrawer.Ones = value;
        }

        private int changeOnes = 0;
        // Constructor for Change One Dollar Bills
        public int ChangeOnes
        {
            get
            {
                return changeOnes;
            }
            private set
            {
                changeOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
            }
        }

        private int customerOnes = 0;
        // Constructor for Customer One Dollar Bills
        public int CustomerOnes
        {
            get
            {
                return customerOnes;
            }
            set
            {
                customerOnes = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the Two Dollar Bills
        public int Twos
        {
            get => CashDrawer.Twos;
            private set => CashDrawer.Twos = value;
        }

        private int changeTwos = 0;
        // Constructor for Change Two Dollar Bills
        public int ChangeTwos
        {
            get
            {
                return changeTwos;
            }
            private set
            {
                changeTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
            }
        }

        private int customerTwos = 0;
        // Constructor for Customer Two Dollar Bills
        public int CustomerTwos
        {
            get
            {
                return customerTwos;
            }
            set
            {
                customerTwos = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the Five Dollar Bills
        public int Fives
        {
            get => CashDrawer.Fives;
            private set => CashDrawer.Fives = value;
        }

        private int changeFives = 0;
        // Constructor for Change Five Dollar Bills
        public int ChangeFives
        {
            get
            {
                return changeFives;
            }
            private set
            {
                changeFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
            }
        }

        private int customerFives = 0;
        // Constructor for Customer Five Dollar Bills
        public int CustomerFives
        {
            get
            {
                return customerFives;
            }
            set
            {
                customerFives = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the Ten Dollar Bills
        public int Tens
        {
            get => CashDrawer.Tens;
            private set => CashDrawer.Tens = value;
        }

        private int changeTens = 0;
        // Constructor for Change Ten Dollar Bills
        public int ChangeTens
        {
            get
            {
                return changeTens;
            }
            private set
            {
                changeTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
            }
        }

        private int customerTens = 0;
        // Constructor for Customer Ten Dollar Bills
        public int CustomerTens
        {
            get
            {
                return customerTens;
            }
            set
            {
                customerTens = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the Twenty Dollar Bills
        public int Twenties
        {
            get => CashDrawer.Twenties;
            private set => CashDrawer.Twenties = value;
        }

        private int changeTwenties = 0;
        // Constructor for Change Twenty Dollar Bills
        public int ChangeTwenties
        {
            get
            {
                return changeTwenties;
            }
            private set
            {
                changeTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
            }
        }

        private int customerTwenties = 0;
        // Constructor for Customer Twenty Dollar Bills
        public int CustomerTwenties
        {
            get
            {
                return customerTwenties;
            }
            set
            {
                customerTwenties = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the Fifty Dollar Bills
        public int Fifties
        {
            get => CashDrawer.Fifties;
            private set => CashDrawer.Fifties = value;
        }

        private int changeFifties = 0;
        // Constructor for Change Fifty Dollar Bills
        public int ChangeFifties
        {
            get
            {
                return changeFifties;
            }
            private set
            {
                changeFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
            }
        }

        private int customerFifties = 0;
        // Constructor for Customer Fifty Dollar Bills
        public int CustomerFifties
        {
            get
            {
                return customerFifties;
            }
            set
            {
                customerFifties = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the One-Hundred Dollar Bills
        public int Hundreds
        {
            get => CashDrawer.Hundreds;
            private set => CashDrawer.Hundreds = value;
        }

        private int changeHundreds = 0;
        // Constructor for Change One-Hundred Dollar Bills
        public int ChangeHundreds
        {
            get
            {
                return changeHundreds;
            }
            private set
            {
                changeHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
            }
        }

        private int customerHundreds = 0;
        // Constructor for Customer One-Hundred Dollar Bills
        public int CustomerHundreds
        {
            get
            {
                return customerHundreds;
            }
            set
            {
                customerHundreds = value;
                GetChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountTenured"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
            }
        }

        // Constructor for the Total amount the cash drawer contains
        public double Total => CashDrawer.Total;

        // Constructor for Amount Due
        public double AmountTenured
        {
            get => (CustomerOnes * 1) + (CustomerTwos * 2) + (CustomerFives * 5) + (CustomerTens * 10) + (CustomerTwenties * 20) + (CustomerFifties * 50) + (CustomerHundreds * 100) +
                    (CustomerPennies * 0.01) + (CustomerNickles * 0.05) + (CustomerDimes * 0.1) + (CustomerQuarters * 0.25) + (CustomerHalfDollars * 0.5) + (CustomerDollarCoins * 1);
        }

        // Constructor for Amount Tenured
        public double AmountDue
        {
            get => Math.Max(0, OrderTotal - AmountTenured);
        }

        // Constructor for Change Owed
        public double ChangeOwed
        {
            get => Math.Max(0, AmountTenured - OrderTotal);
        }

        /// <summary>
        /// Method to calculate the values for each change quantity
        /// </summary>
        /// <remarks>
        /// Algorithm taken from https://www.jeremyshanks.com/create-change-calculator-c/
        /// </remarks>
        public void GetChange()
        {
            double total = ChangeOwed;

            ChangeHundreds = (int)(total / 100);
            total %= 100;

            ChangeFifties = (int)(total / 50);
            total %= 50;

            ChangeTwenties = (int)(total / 20);
            total %= 20;

            ChangeTens = (int)(total / 10);
            total %= 10;

            ChangeFives = (int)(total / 5);
            total %= 5;

            ChangeTwos = (int)(total / 2);
            total %= 2;

            ChangeOnes = (int)(total / 1);
            total %= 1;

            ChangeDollarCoins = (int)(total / 1);
            total %= 1;

            ChangeHalfDollars = (int)(total / 0.5);
            total %= 0.50;

            ChangeQuarters = (int)(total / .25);
            total %= 0.25;

            ChangeDimes = (int)(total / .10);
            total %= 0.10;

            ChangeNickles = (int)(total / .05);
            total %= 0.05;

            ChangePennies = (int)(total / .01);
        }

        /// <summary>
        /// Method for finalizing the sale and updating the values of the currency inside the cash drawer
        /// </summary>
        public void ApplyTransaction()
        {
            CashDrawer.OpenDrawer();
            Pennies += CustomerPennies;
            Pennies -= ChangePennies;
            Nickles += CustomerNickles;
            Nickles -= ChangeNickles;
            Dimes += CustomerDimes;
            Dimes -= ChangeDimes;
            Quarters += CustomerQuarters;
            Quarters -= ChangeQuarters;
            HalfDollars += CustomerHalfDollars;
            HalfDollars -= ChangeHalfDollars;
            DollarCoins += CustomerDollarCoins;
            DollarCoins -= ChangeDollarCoins;
            Ones += CustomerOnes;
            Ones -= ChangeOnes;
            Twos += CustomerTwos;
            Twos -= ChangeTwos;
            Fives += CustomerFives;
            Fives -= ChangeFives;
            Tens += CustomerTens;
            Tens -= ChangeTens;
            Twenties += CustomerTwenties;
            Twenties -= ChangeTwenties;
            Fifties += CustomerFifties;
            Fifties -= ChangeFifties;
            Hundreds += CustomerHundreds;
            Hundreds -= ChangeHundreds;
        }
    }
}