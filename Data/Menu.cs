/*
 * Author: Brett Montgomery
 * Class name: Menu.cs
 * Purpose: Class used to represent the menu for Bleakwind Buffet
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.Linq;

namespace BleakwindBuffet.Data.Menu
{
    /// <summary>
    /// A static class that provides the details of the menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Creates a menu of entrees
        /// </summary>
        /// <returns>A list of all offered entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();

            BriarheartBurger bb = new BriarheartBurger();
            entrees.Add(bb);
            DoubleDraugr dd = new DoubleDraugr();
            entrees.Add(dd);
            GardenOrcOmelette go = new GardenOrcOmelette();
            entrees.Add(go);
            PhillyPoacher pp = new PhillyPoacher();
            entrees.Add(pp);
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            entrees.Add(ss);
            ThalmorTriple tt = new ThalmorTriple();
            entrees.Add(tt);
            ThugsTBone tb = new ThugsTBone();
            entrees.Add(tb);

            return entrees;
        }

        /// <summary>
        /// Creates a menu of sides
        /// </summary>
        /// <returns>A list of all offered sides with sizes</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            DragonbornWaffleFries d1 = new DragonbornWaffleFries();
            d1.Size = Size.Small;
            sides.Add(d1);
            DragonbornWaffleFries d2 = new DragonbornWaffleFries();
            d2.Size = Size.Medium;
            sides.Add(d2);
            DragonbornWaffleFries d3 = new DragonbornWaffleFries();
            d3.Size = Size.Large;
            sides.Add(d3);

            FriedMiraak f1 = new FriedMiraak();
            f1.Size = Size.Small;
            sides.Add(f1);
            FriedMiraak f2 = new FriedMiraak();
            f2.Size = Size.Medium;
            sides.Add(f2);
            FriedMiraak f3 = new FriedMiraak();
            f3.Size = Size.Large;
            sides.Add(f3);

            MadOtarGrits m1 = new MadOtarGrits();
            m1.Size = Size.Small;
            sides.Add(m1);
            MadOtarGrits m2 = new MadOtarGrits();
            m2.Size = Size.Medium;
            sides.Add(m2);
            MadOtarGrits m3 = new MadOtarGrits();
            m3.Size = Size.Large;
            sides.Add(m3);

            VokunSalad v1 = new VokunSalad();
            v1.Size = Size.Small;
            sides.Add(v1);
            VokunSalad v2 = new VokunSalad();
            v2.Size = Size.Medium;
            sides.Add(v2);
            VokunSalad v3 = new VokunSalad();
            v3.Size = Size.Large;
            sides.Add(v3);

            return sides;
        }

        /// <summary>
        /// Creates a menu of drinks
        /// </summary>
        /// <returns>The list of all offered drinks with sizes and flavors</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            ArentinoAppleJuice a1 = new ArentinoAppleJuice();
            a1.Size = Size.Small;
            drinks.Add(a1);
            ArentinoAppleJuice a2 = new ArentinoAppleJuice();
            a2.Size = Size.Medium;
            drinks.Add(a2);
            ArentinoAppleJuice a3 = new ArentinoAppleJuice();
            a3.Size = Size.Large;
            drinks.Add(a3);

            CandlehearthCoffee c1 = new CandlehearthCoffee();
            c1.Size = Size.Small;
            drinks.Add(c1);
            CandlehearthCoffee c2 = new CandlehearthCoffee();
            c2.Size = Size.Medium;
            drinks.Add(c2);
            CandlehearthCoffee c3 = new CandlehearthCoffee();
            c3.Size = Size.Large;
            drinks.Add(c3);

            MarkarthMilk m1 = new MarkarthMilk();
            m1.Size = Size.Small;
            drinks.Add(m1);
            MarkarthMilk m2 = new MarkarthMilk();
            m2.Size = Size.Medium;
            drinks.Add(m2);
            MarkarthMilk m3 = new MarkarthMilk();
            m3.Size = Size.Large;
            drinks.Add(m3);

            SailorSoda s1 = new SailorSoda();
            s1.Size = Size.Small;
            s1.Flavor = SodaFlavor.Blackberry;
            drinks.Add(s1);
            SailorSoda s2 = new SailorSoda();
            s2.Size = Size.Small;
            s2.Flavor = SodaFlavor.Cherry;
            drinks.Add(s2);
            SailorSoda s3 = new SailorSoda();
            s3.Size = Size.Small;
            s3.Flavor = SodaFlavor.Grapefruit;
            drinks.Add(s3);
            SailorSoda s4 = new SailorSoda();
            s4.Size = Size.Small;
            s4.Flavor = SodaFlavor.Lemon;
            drinks.Add(s4);
            SailorSoda s5 = new SailorSoda();
            s5.Size = Size.Small;
            s5.Flavor = SodaFlavor.Peach;
            drinks.Add(s5);
            SailorSoda s6 = new SailorSoda();
            s6.Size = Size.Small;
            s6.Flavor = SodaFlavor.Watermelon;
            drinks.Add(s6);

            SailorSoda s7 = new SailorSoda();
            s7.Size = Size.Medium;
            s7.Flavor = SodaFlavor.Blackberry;
            drinks.Add(s7);
            SailorSoda s8 = new SailorSoda();
            s8.Size = Size.Medium;
            s8.Flavor = SodaFlavor.Cherry;
            drinks.Add(s8);
            SailorSoda s9 = new SailorSoda();
            s9.Size = Size.Medium;
            s9.Flavor = SodaFlavor.Grapefruit;
            drinks.Add(s9);
            SailorSoda s10 = new SailorSoda();
            s10.Size = Size.Medium;
            s10.Flavor = SodaFlavor.Lemon;
            drinks.Add(s10);
            SailorSoda s11 = new SailorSoda();
            s11.Size = Size.Medium;
            s11.Flavor = SodaFlavor.Peach;
            drinks.Add(s11);
            SailorSoda s12 = new SailorSoda();
            s12.Size = Size.Medium;
            s12.Flavor = SodaFlavor.Watermelon;
            drinks.Add(s12);

            SailorSoda s13 = new SailorSoda();
            s13.Size = Size.Large;
            s13.Flavor = SodaFlavor.Blackberry;
            drinks.Add(s13);
            SailorSoda s14 = new SailorSoda();
            s14.Size = Size.Large;
            s14.Flavor = SodaFlavor.Cherry;
            drinks.Add(s14);
            SailorSoda s15 = new SailorSoda();
            s15.Size = Size.Large;
            s15.Flavor = SodaFlavor.Grapefruit;
            drinks.Add(s15);
            SailorSoda s16 = new SailorSoda();
            s16.Size = Size.Large;
            s16.Flavor = SodaFlavor.Lemon;
            drinks.Add(s16);
            SailorSoda s17 = new SailorSoda();
            s17.Size = Size.Large;
            s17.Flavor = SodaFlavor.Peach;
            drinks.Add(s17);
            SailorSoda s18 = new SailorSoda();
            s18.Size = Size.Large;
            s18.Flavor = SodaFlavor.Watermelon;
            drinks.Add(s18);

            WarriorWater w1 = new WarriorWater();
            w1.Size = Size.Small;
            drinks.Add(w1);
            WarriorWater w2 = new WarriorWater();
            w2.Size = Size.Medium;
            drinks.Add(w2);
            WarriorWater w3 = new WarriorWater();
            w3.Size = Size.Large;
            drinks.Add(w3);

            return drinks;
        }

        /// <summary>
        /// Gets the possible menu item types
        /// </summary>
        public static string[] ItemType
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink"
            };
        }

        /// <summary>
        /// Creates the full menu
        /// </summary>
        /// <returns>A list of all the items on the menu including size and flavor variations</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> completeMenu = new List<IOrderItem>();

            completeMenu.AddRange(Entrees());
            completeMenu.AddRange(Drinks());
            completeMenu.AddRange(Sides());

            return completeMenu;
        }        
    }
}