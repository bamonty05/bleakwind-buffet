﻿/*
 * Author: Brett Montgomery
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the double draugr
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the details of the double draugr
    /// </summary>
    public class DoubleDraugr : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Stores values of prices for the entree
        /// </summary>
        public override double Price
        {
            get { return 7.32; }
        }

        /// <summary>
        /// Stores values of calories for the entree
        /// </summary>
        public override uint Calories
        {
            get { return 843; }
        }

        public override string Description
        {
            get { return "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo."; }
        }

        private bool bun = true;

        /// <summary>
        /// Getter and setter for the private backing variable bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ketchup = true;

        /// <summary>
        /// Getter and setter for the private backing variable ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mustard = true;

        /// <summary>
        /// Getter and setter for the private backing variable mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;

        /// <summary>
        /// Getter and setter for the private backing variable pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool cheese = true;

        /// <summary>
        /// Getter and setter for the private backing variable cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool tomato = true;

        /// <summary>
        /// Getter and setter for the private backing variable tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool lettuce = true;

        /// <summary>
        /// Getter and setter for the private backing variable lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mayo = true;

        /// <summary>
        /// Getter and setter for the private backing variable mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Creates a list of special instructions based on the boolean values of the private backing variables
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bun) instructions.Add("Hold bun");
                if (!ketchup) instructions.Add("Hold ketchup");
                if (!mustard) instructions.Add("Hold mustard");
                if (!pickle) instructions.Add("Hold pickle");
                if (!cheese) instructions.Add("Hold cheese");
                if (!tomato) instructions.Add("Hold tomato");
                if (!lettuce) instructions.Add("Hold lettuce");
                if (!mayo) instructions.Add("Hold mayo");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() function and returns the name of the entree
        /// </summary>
        /// <returns>A string containing the name of selected entree</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}