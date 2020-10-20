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

        // Constructor for the Pennies
        public int Pennies => CashDrawer.Pennies;

        private int changePennies = 0;
        // Constructor for Change Pennies
        public int ChangePennies
        {
            get
            {
                return changePennies;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerPennies"));
            }
        }

        // Constructor for the Nickels
        public int Nickles => CashDrawer.Nickels;

        private int changeNickles = 0;
        // Constructor for Change Nickels
        public int ChangeNickles
        {
            get
            {
                return changeNickles;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerNickles"));
            }
        }

        // Constructor for the Dimes
        public int Dimes => CashDrawer.Dimes;

        private int changeDimes = 0;
        // Constructor for Change Dimes
        public int ChangeDimes
        {
            get
            {
                return changeDimes;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDimes"));
            }
        }

        // Constructor for the Quarters
        public int Quarters => CashDrawer.Quarters;

        private int changeQuarters = 0;
        // Constructor for Change Quarters
        public int ChangeQuarters
        {
            get
            {
                return changeQuarters;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuarters"));
            }
        }

        // Constructor for the Half Dollars
        public int HalfDollars => CashDrawer.HalfDollars;

        private int changeHalfDollars = 0;
        // Constructor for Change Half Dollars
        public int ChangeHalfDollars
        {
            get
            {
                return changeHalfDollars;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHalfDollars"));
            }
        }

        // Constructor for the Dollar Coins
        public int DollarCoins => CashDrawer.Dollars;

        private int changeDollarCoins = 0;
        // Constructor for Change Dollar Coins
        public int ChangeDollarCoins
        {
            get
            {
                return changeDollarCoins;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDollarCoins"));
            }
        }

        // Constructor for the One Dollar Bills
        public int Ones => CashDrawer.Ones;

        private int changeOnes = 0;
        // Constructor for Change One Dollar Bills
        public int ChangeOnes
        {
            get
            {
                return changeOnes;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerOnes"));
            }
        }

        // Constructor for the Two Dollar Bills
        public int Twos => CashDrawer.Twos;

        private int changeTwos = 0;
        // Constructor for Change Two Dollar Bills
        public int ChangeTwos
        {
            get
            {
                return changeTwos;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwos"));
            }
        }

        // Constructor for the Five Dollar Bills
        public int Fives => CashDrawer.Fives;

        private int changeFives = 0;
        // Constructor for Change Five Dollar Bills
        public int ChangeFives
        {
            get
            {
                return changeFives;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFives"));
            }
        }

        // Constructor for the Ten Dollar Bills
        public int Tens => CashDrawer.Tens;

        private int changeTens = 0;
        // Constructor for Change Ten Dollar Bills
        public int ChangeTens
        {
            get
            {
                return changeTens;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTens"));
            }
        }

        // Constructor for the Twenty Dollar Bills
        public int Twenties => CashDrawer.Twenties;

        private int changeTwenties = 0;
        // Constructor for Change Twenty Dollar Bills
        public int ChangeTwenties
        {
            get
            {
                return changeTwenties;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwenties"));
            }
        }

        // Constructor for the Fifty Dollar Bills
        public int Fifties => CashDrawer.Fifties;

        private int changeFifties = 0;
        // Constructor for Change Fifty Dollar Bills
        public int ChangeFifties
        {
            get
            {
                return changeFifties;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFifties"));
            }
        }

        // Constructor for the One-Hundred Dollar Bills
        public int Hundreds => CashDrawer.Hundreds;

        private int changeHundreds = 0;
        // Constructor for Change One-Hundred Dollar Bills
        public int ChangeHundreds
        {
            get
            {
                return changeHundreds;
            }
            set
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHundreds"));
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
            get => Total - AmountTenured;
        }

        // Constructor for Change Owed
        public double ChangeOwed
        {
            get => AmountTenured - Total;
        }

        /// <summary>
        /// Method to calculate the values for each change quantity
        /// </summary>
        /// <remarks>
        /// Algorithm taken from https://www.jeremyshanks.com/create-change-calculator-c/
        /// </remarks>
        /// <param name="total">The total change owed</param>
        public void GetChange(double total)
        {
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
            total %= 0.5;

            ChangeQuarters = (int)(total / .25);
            total %= .25;

            ChangeDimes = (int)(total / .10);
            total %= .10;

            ChangeNickles = (int)(total / .05);
            total %= .05;

            ChangePennies = (int)(total / .01);
        }
    }
}
