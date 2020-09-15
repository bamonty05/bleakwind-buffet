/*
 * Author: Brett Montgomery
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the thalmor triple
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the details of the thalmor triple
    /// </summary>
    public class ThalmorTriple : Entree
    {
        /// <summary>
        /// Stores values of prices for the entree
        /// </summary>
        public override double Price
        {
            get { return 8.32; }
        }

        /// <summary>
        /// Stores values of calories for the entree
        /// </summary>
        public override uint Calories
        {
            get { return 943; }
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

        private bool tomato = true;

        /// <summary>
        /// Getter and setter for the private backing variable tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        private bool lettuce = true;

        /// <summary>
        /// Getter and setter for the private backing variable lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        private bool mayo = true;

        /// <summary>
        /// Getter and setter for the private backing variable mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        private bool bacon = true;

        /// <summary>
        /// Getter and setter for the private backing variable bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        private bool egg = true;

        /// <summary>
        /// Getter and setter for the private backing variable egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
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
                if (!bacon) instructions.Add("Hold bacon");
                if (!egg) instructions.Add("Hold egg");

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() function and returns the name of the entree
        /// </summary>
        /// <returns>A string containing the name of selected entree</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}