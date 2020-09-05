/*
 * Author: Brett Montgomery
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the briarheart burger
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the details of the briarheart burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Stores values of prices for the entree
        /// </summary>
        public double Price
        {
            get { return 6.32; }
        }

        /// <summary>
        /// Stores values of calories for the entree
        /// </summary>
        public uint Calories
        {
            get { return 743; }
        }

        private bool bun = true;

        /// <summary>
        /// Getter and setter for the private backing variable bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        private bool ketchup = true;

        /// <summary>
        /// Getter and setter for the private backing variable ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        private bool mustard = true;

        /// <summary>
        /// Getter and setter for the private backing variable mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        private bool pickle = true;

        /// <summary>
        /// Getter and setter for the private backing variable pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        private bool cheese = true;

        /// <summary>
        /// Getter and setter for the private backing variable cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// Creates a list of special instructions based on the boolean values of the private backing variables
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bun) instructions.Add("Hold bun");
                if (!ketchup) instructions.Add("Hold ketchup");
                if (!mustard) instructions.Add("Hold mustard");
                if (!pickle) instructions.Add("Hold pickle");
                if (!cheese) instructions.Add("Hold cheese");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() function and returns the name of the entree
        /// </summary>
        /// <returns>A string containing the name of selected entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}