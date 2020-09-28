/*
 * Author: Brett Montgomery
 * Class name: MenuSelectionScreen.xaml.cs
 * Purpose: User Control Class to represent the Bleakwind Buffet Menu
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using PointOfSale.Customizations;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        public MenuSelection()
        {
            InitializeComponent();
        }

        // A click event handler for the Briarheart Burger button
        void AddBriarheartBurger(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new BriarheartBurgerCustom();
        }

        // A click event handler for the Double Draugr button
        void AddDoubleDraugr(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new DoubleDraugrCustom();
        }

        // A click event handler for the Thalmor Triple button
        void AddThalmorTriple(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new ThalmorTripleCustom();
        }

        // A click event handler for the Garden Orc Omelette button
        void AddGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new GardenOrcOmeletteCustom();
        }

        // A click event handler for the Philly Poacher button
        void AddPhillyPoacher(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new PhillyPoacherCustom();
        }

        // A click event handler for the Smokehouse Skeleton button
        void AddSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new SmokehouseSkeletonCustom();
        }

        // A click event handler for the Thugs T-Bone button
        void AddThugsTBone(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new ThugsTBoneCustom();
        }

        // A click event handler for the Dragonborn Waffle Fries button
        void AddDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new DragonbornWaffleFriesCustom();
        }

        // A click event handler for the Fried Miraak button
        void AddFriedMiraak(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new FriedMiraakCustom();
        }

        // A click event handler for the Mad Otar Grits
        void AddMadOtarGrits(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new MadOtarGritsCustom();
        }

        // A click event handler for the Vokun Salad button
        void AddVokunSalad(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new VokunSaladCustom();
        }

        // A click event handler for the Arentino Apple Juice button
        void AddArentinoAppleJuice(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new ArentinoAppleJuiceCustom();
        }

        // A click event handler for the Candlehearth Coffee button
        void AddCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new CandlehearthCoffeeCustom();
        }

        // A click event handler for the Markarth Milk button
        void AddMarkarthMilk(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new MarkarthMilkCustom();
        }

        // A click event handler for the Sailor Soda button
        void AddSailorSoda(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new SailorSodaCustom();
        }

        // A click event handler for the Warrior Water button
        void AddWarriorWater(object sender, RoutedEventArgs e)
        {
            menuBorder.Child = new WarriorWaterCustom();
        }
    }
}