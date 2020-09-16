/*
 * Author: Brett Montgomery
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */

using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Menu;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Theory]
        [InlineData("Briarheart Burger")]
        [InlineData("Double Draugr")]
        [InlineData("Garden Orc Omelette")]
        [InlineData("Philly Poacher")]
        [InlineData("Smokehouse Skeleton")]
        [InlineData("Thalmor Triple")]
        [InlineData("Thugs T-Bone")]
        public void MenuReturnsEntrees(string name)
        {
            Assert.Contains<IOrderItem>(Menu.Entrees(), (item) => item.ToString().Equals(name));
        }

        [Theory]
        [InlineData("Small Arentino Apple Juice")]
        [InlineData("Small Candlehearth Coffee")]
        [InlineData("Small Markarth Milk")]
        [InlineData("Small Blackberry Sailor Soda")]
        [InlineData("Small Cherry Sailor Soda")]
        [InlineData("Small Grapefruit Sailor Soda")]
        [InlineData("Small Lemon Sailor Soda")]
        [InlineData("Small Peach Sailor Soda")]
        [InlineData("Small Watermelon Sailor Soda")]
        [InlineData("Small Warrior Water")]
        [InlineData("Medium Arentino Apple Juice")]
        [InlineData("Medium Candlehearth Coffee")]
        [InlineData("Medium Markarth Milk")]
        [InlineData("Medium Blackberry Sailor Soda")]
        [InlineData("Medium Cherry Sailor Soda")]
        [InlineData("Medium Grapefruit Sailor Soda")]
        [InlineData("Medium Lemon Sailor Soda")]
        [InlineData("Medium Peach Sailor Soda")]
        [InlineData("Medium Watermelon Sailor Soda")]
        [InlineData("Medium Warrior Water")]
        [InlineData("Large Arentino Apple Juice")]
        [InlineData("Large Candlehearth Coffee")]
        [InlineData("Large Markarth Milk")]
        [InlineData("Large Blackberry Sailor Soda")]
        [InlineData("Large Cherry Sailor Soda")]
        [InlineData("Large Grapefruit Sailor Soda")]
        [InlineData("Large Lemon Sailor Soda")]
        [InlineData("Large Peach Sailor Soda")]
        [InlineData("Large Watermelon Sailor Soda")]
        [InlineData("Large Warrior Water")]
        public void MenuReturnsDrinks(string name)
        {
            Assert.Contains<IOrderItem>(Menu.Drinks(), (item) => item.ToString().Equals(name));
        }

        [Theory]
        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Small Fried Miraak")]
        [InlineData("Small Mad Otar Grits")]
        [InlineData("Small Vokun Salad")]
        [InlineData("Medium Dragonborn Waffle Fries")]
        [InlineData("Medium Fried Miraak")]
        [InlineData("Medium Mad Otar Grits")]
        [InlineData("Medium Vokun Salad")]
        [InlineData("Large Dragonborn Waffle Fries")]
        [InlineData("Large Fried Miraak")]
        [InlineData("Large Mad Otar Grits")]
        [InlineData("Large Vokun Salad")]
        public void MenuReturnsSides(string name)
        {
            Assert.Contains<IOrderItem>(Menu.Sides(), (item) => item.ToString().Equals(name));
        }

        [Theory]
        [InlineData("Briarheart Burger")]
        [InlineData("Double Draugr")]
        [InlineData("Garden Orc Omelette")]
        [InlineData("Philly Poacher")]
        [InlineData("Smokehouse Skeleton")]
        [InlineData("Thalmor Triple")]
        [InlineData("Thugs T-Bone")]
        [InlineData("Small Arentino Apple Juice")]
        [InlineData("Small Candlehearth Coffee")]
        [InlineData("Small Markarth Milk")]
        [InlineData("Small Blackberry Sailor Soda")]
        [InlineData("Small Cherry Sailor Soda")]
        [InlineData("Small Grapefruit Sailor Soda")]
        [InlineData("Small Lemon Sailor Soda")]
        [InlineData("Small Peach Sailor Soda")]
        [InlineData("Small Watermelon Sailor Soda")]
        [InlineData("Small Warrior Water")]
        [InlineData("Medium Arentino Apple Juice")]
        [InlineData("Medium Candlehearth Coffee")]
        [InlineData("Medium Markarth Milk")]
        [InlineData("Medium Blackberry Sailor Soda")]
        [InlineData("Medium Cherry Sailor Soda")]
        [InlineData("Medium Grapefruit Sailor Soda")]
        [InlineData("Medium Lemon Sailor Soda")]
        [InlineData("Medium Peach Sailor Soda")]
        [InlineData("Medium Watermelon Sailor Soda")]
        [InlineData("Medium Warrior Water")]
        [InlineData("Large Arentino Apple Juice")]
        [InlineData("Large Candlehearth Coffee")]
        [InlineData("Large Markarth Milk")]
        [InlineData("Large Blackberry Sailor Soda")]
        [InlineData("Large Cherry Sailor Soda")]
        [InlineData("Large Grapefruit Sailor Soda")]
        [InlineData("Large Lemon Sailor Soda")]
        [InlineData("Large Peach Sailor Soda")]
        [InlineData("Large Watermelon Sailor Soda")]
        [InlineData("Large Warrior Water")]
        [InlineData("Small Dragonborn Waffle Fries")]
        [InlineData("Small Fried Miraak")]
        [InlineData("Small Mad Otar Grits")]
        [InlineData("Small Vokun Salad")]
        [InlineData("Medium Dragonborn Waffle Fries")]
        [InlineData("Medium Fried Miraak")]
        [InlineData("Medium Mad Otar Grits")]
        [InlineData("Medium Vokun Salad")]
        [InlineData("Large Dragonborn Waffle Fries")]
        [InlineData("Large Fried Miraak")]
        [InlineData("Large Mad Otar Grits")]
        [InlineData("Large Vokun Salad")]
        public void ReturnsFullMenu(string name)
        {
            Assert.Contains<IOrderItem>(Menu.FullMenu(), (item) => item.ToString().Equals(name));
        }
    }
}
