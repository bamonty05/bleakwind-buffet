/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 * Modified By: Brett Montgomery
 */

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Runtime;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class ArentinoAppleJuiceTests
    {
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var aj = new ArentinoAppleJuice();
            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = true;
            });
            Assert.PropertyChanged(aj, "Ice", () =>
            {
                aj.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var aj = new ArentinoAppleJuice();
            Assert.PropertyChanged(aj, "SpecialInstructions", () =>
            {
                aj.Ice = true;
            });
            Assert.PropertyChanged(aj, "SpecialInstructions", () =>
            {
                aj.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var aj = new ArentinoAppleJuice();
            Assert.PropertyChanged(aj, "SizeSmall", () =>
            {
                aj.Size = Size.Small;
            });
            Assert.PropertyChanged(aj, "SizeMedium", () =>
            {
                aj.Size = Size.Medium;
            });
            Assert.PropertyChanged(aj, "SizeLarge", () =>
            {
                aj.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var aj = new ArentinoAppleJuice();
            Assert.PropertyChanged(aj, "Price", () =>
            {
                aj.Size = Size.Small;
            });
            Assert.PropertyChanged(aj, "Price", () =>
            {
                aj.Size = Size.Medium;
            });
            Assert.PropertyChanged(aj, "Price", () =>
            {
                aj.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldImplementINotifyProperty()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(aj);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(aj);
        }
        
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            Assert.Equal(Size.Small, aj.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Ice = true;
            Assert.True(aj.Ice);
            aj.Ice = false;
            Assert.False(aj.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = Size.Large;
            Assert.Equal(Size.Large, aj.Size);
            aj.Size = Size.Medium;
            Assert.Equal(Size.Medium, aj.Size);
            aj.Size = Size.Small;
            Assert.Equal(Size.Small, aj.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = size;
            Assert.Equal(price, aj.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = size;
            Assert.Equal(cal, aj.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", aj.SpecialInstructions);
            else Assert.Empty(aj.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Arentino Apple Juice")]
        [InlineData(Size.Medium, "Medium Arentino Apple Juice")]
        [InlineData(Size.Large, "Large Arentino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            ArentinoAppleJuice aj = new ArentinoAppleJuice();
            aj.Size = size;
            Assert.Equal(name, aj.ToString());
        }
    }
}