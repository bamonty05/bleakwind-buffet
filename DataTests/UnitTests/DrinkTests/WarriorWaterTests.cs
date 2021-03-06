﻿/*
 * Author: Brett Montgomery
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Runtime;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = true;
            });
            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = false;
            });
        }

        [Fact]
        public void ChangingIceNotifiesSpecialInstructionsProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Ice = true;
            });
            Assert.PropertyChanged(ww, "SpecialInstructions", () =>
            {
                ww.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "SizeSmall", () =>
            {
                ww.Size = Size.Small;
            });
            Assert.PropertyChanged(ww, "SizeMedium", () =>
            {
                ww.Size = Size.Medium;
            });
            Assert.PropertyChanged(ww, "SizeLarge", () =>
            {
                ww.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesPriceProperty()
        {
            var ww = new WarriorWater();
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Small;
            });
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Medium;
            });
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Large;
            });
        }

        [Fact]
        public void ShouldImplementINotifyProperty()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ww);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if (!includeIce && includeLemon)
            {
                Assert.Contains("Hold ice", ww.SpecialInstructions);
                Assert.Contains("Add lemon", ww.SpecialInstructions);
            }
            else if (includeLemon)
            {
                Assert.Contains("Add lemon", ww.SpecialInstructions);
            }
            else if(!includeIce)
            {
                Assert.Contains("Hold ice", ww.SpecialInstructions);
            }
            else
            {
                Assert.Empty(ww.SpecialInstructions);
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }
    }
}
