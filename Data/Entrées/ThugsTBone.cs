/*
 * Author: Brett Montgomery
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the thugs t-bone
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrées
{
    /// <summary>
    /// Provides the details of the thugs t-bone
    /// </summary>
    public class ThugsTBone
    {
        /* stores values of prices for each available size */
        public double Price
        {
            get { return 6.44; }
        }

        /* stores values of calories for each available size */
        public uint Calories
        {
            get { return 982; }
        }

        /* creates a list of special instructions based on the boolean values of the private backing variables */
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

        /* overrides the ToString() function and returns the size and name of the side */
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}