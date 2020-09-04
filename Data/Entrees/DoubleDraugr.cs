/*
 * Author: Brett Montgomery
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the double draugr
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the details of the double draugr
    /// </summary>
    public class DoubleDraugr
    {
        /* stores values of prices for each available size */
        public double Price
        {
            get { return 7.32; }
        }

        /* stores values of calories for each available size */
        public uint Calories
        {
            get { return 843; }
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

                return instructions;
            }
        }

        /* overrides the ToString() function and returns the size and name of the side */
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}