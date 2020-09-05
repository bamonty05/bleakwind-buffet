﻿/*
 * Author: Brett Montgomery
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the thugs t-bone
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Provides the details of the thugs t-bone
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// Stores values of prices for the entree
        /// </summary>
        public double Price
        {
            get { return 6.44; }
        }

        /// <summary>
        /// Stores values of calories for the entree
        /// </summary>
        public uint Calories
        {
            get { return 982; }
        }

        /// <summary>
        /// Creates a list of special instructions based on the boolean values of the private backing variables
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString() function and returns the name of the entree
        /// </summary>
        /// <returns>A string containing the name of selected entree</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}