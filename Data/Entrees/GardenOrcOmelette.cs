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
        /// <summary>
        /// Stores values of prices for the entree
        /// </summary>
        public double Price
        {
            get { return 4.57; }
        }

        /// <summary>
        /// Stores values of calories for the entree
        /// </summary>
        public uint Calories
        {
            get { return 404; }
        }

        private bool broccoli = true;

        /// <summary>
        /// Getter and setter for the private backing variable broccoli
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set { broccoli = value; }
        }

        private bool mushrooms = true;

        /// <summary>
        /// Getter and setter for the private backing variable mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
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

        private bool cheddar = true;

        /// <summary>
        /// Getter and setter for the private backing variable cheddar
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        /// <summary>
        /// Creates a list of special instructions based on the boolean values of the private backing variables
        /// </summary>
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

        /// <summary>
        /// Overrides the ToString() function and returns the name of the entree
        /// </summary>
        /// <returns>A string containing the name of selected entree</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}