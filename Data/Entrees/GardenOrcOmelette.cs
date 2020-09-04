/*
 * Author: Brett Montgomery
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the garden orc omelette
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the details of the garden orc omelette
    /// </summary>
    public class GardenOrcOmelette
    {
        /* stores values of prices for each available size */
        public double Price
        {
            get { return 4.57; }
        }

        /* stores values of calories for each available size */
        public uint Calories
        {
            get { return 404; }
        }

        private bool broccoli = true;

        /* getter and setter for the private backing variable broccoli */
        public bool Broccoli
        {
            get { return broccoli; }
            set { broccoli = value; }
        }

        private bool mushrooms = true;

        /* getter and setter for the private backing variable mushrooms */
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
        }

        private bool tomato = true;

        /* getter and setter for the private backing variable tomato */
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        private bool cheddar = true;

        /* getter and setter for the private backing variable cheddar */
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        /* creates a list of special instructions based on the boolean values of the private backing variables */
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!broccoli) instructions.Add("Hold broccoli");
                if (!mushrooms) instructions.Add("Hold mushrooms");
                if (!tomato) instructions.Add("Hold tomato");
                if (!cheddar) instructions.Add("Hold cheddar");

                return instructions;
            }
        }

        /* overrides the ToString() function and returns the size and name of the side */
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}