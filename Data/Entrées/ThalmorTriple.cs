/*
 * Author: Brett Montgomery
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the thalmor triple
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrées
{
    /// <summary>
    /// Provides the details of the thalmor triple
    /// </summary>
    public class ThalmorTriple
    {
        /* stores values of prices for each available size */
        public double Price
        {
            get { return 8.32; }
        }

        /* stores values of calories for each available size */
        public uint Calories
        {
            get { return 943; }
        }

        private bool bun = true;

        /* getter and setter for the private backing variable bun */
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        private bool ketchup = true;

        /* getter and setter for the private backing variable ketchup */
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        private bool mustard = true;

        /* getter and setter for the private backing variable mustard */
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        private bool pickle = true;

        /* getter and setter for the private backing variable pickle */
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        private bool cheese = true;

        /* getter and setter for the private backing variable cheese */
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        private bool tomato = true;

        /* getter and setter for the private backing variable tomato */
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        private bool lettuce = true;

        /* getter and setter for the private backing variable lettuce */
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        private bool mayo = true;

        /* getter and setter for the private backing variable mayo */
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        private bool bacon = true;

        /* getter and setter for the private backing variable bacon */
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        private bool egg = true;

        /* getter and setter for the private backing variable egg */
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /* creates a list of special instructions based on the boolean values of the private backing variables */
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
                if (!tomato) instructions.Add("Hold tomato");
                if (!lettuce) instructions.Add("Hold lettuce");
                if (!mayo) instructions.Add("Hold mayo");
                if (!bacon) instructions.Add("Hold bacon");
                if (!egg) instructions.Add("Hold egg");

                return instructions;
            }
        }

        /* overrides the ToString() function and returns the size and name of the side */
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}