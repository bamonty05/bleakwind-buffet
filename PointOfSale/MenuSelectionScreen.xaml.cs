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
            var screen = new BriarheartBurgerCustom();
            BriarheartBurger temp = new BriarheartBurger();

            menuBorder.Child = screen;
            screen.DataContext = temp;

        }

        // A click event handler for the Double Draugr button
        void AddDoubleDraugr(object sender, RoutedEventArgs e)
        {
            var screen = new DoubleDraugrCustom();
            DoubleDraugr temp = new DoubleDraugr();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Thalmor Triple button
        void AddThalmorTriple(object sender, RoutedEventArgs e)
        {
            var screen = new ThalmorTripleCustom();
            ThalmorTriple temp = new ThalmorTriple();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Garden Orc Omelette button
        void AddGardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            var screen = new GardenOrcOmeletteCustom();
            GardenOrcOmelette temp = new GardenOrcOmelette();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Philly Poacher button
        void AddPhillyPoacher(object sender, RoutedEventArgs e)
        {
            var screen = new PhillyPoacherCustom();
            PhillyPoacher temp = new PhillyPoacher();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Smokehouse Skeleton button
        void AddSmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            var screen = new SmokehouseSkeletonCustom();
            SmokehouseSkeleton temp = new SmokehouseSkeleton();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Thugs T-Bone button
        void AddThugsTBone(object sender, RoutedEventArgs e)
        {
            var screen = new ThugsTBoneCustom();
            ThugsTBone temp = new ThugsTBone();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Dragonborn Waffle Fries button
        void AddDragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            var screen = new DragonbornWaffleFriesCustom();
            DragonbornWaffleFries temp = new DragonbornWaffleFries();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Fried Miraak button
        void AddFriedMiraak(object sender, RoutedEventArgs e)
        {
            var screen = new FriedMiraakCustom();
            FriedMiraak temp = new FriedMiraak();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Mad Otar Grits
        void AddMadOtarGrits(object sender, RoutedEventArgs e)
        {
            var screen = new MadOtarGritsCustom();
            MadOtarGrits temp = new MadOtarGrits();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Vokun Salad button
        void AddVokunSalad(object sender, RoutedEventArgs e)
        {
            var screen = new VokunSaladCustom();
            VokunSalad temp = new VokunSalad();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Arentino Apple Juice button
        void AddArentinoAppleJuice(object sender, RoutedEventArgs e)
        {
            var screen = new ArentinoAppleJuiceCustom();
            ArentinoAppleJuice temp = new ArentinoAppleJuice();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Candlehearth Coffee button
        void AddCandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            var screen = new CandlehearthCoffeeCustom();
            CandlehearthCoffee temp = new CandlehearthCoffee();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Markarth Milk button
        void AddMarkarthMilk(object sender, RoutedEventArgs e)
        {
            var screen = new MarkarthMilkCustom();
            MarkarthMilk temp = new MarkarthMilk();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Sailor Soda button
        void AddSailorSoda(object sender, RoutedEventArgs e)
        {
            var screen = new SailorSodaCustom();
            SailorSoda temp = new SailorSoda();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }

        // A click event handler for the Warrior Water button
        void AddWarriorWater(object sender, RoutedEventArgs e)
        {
            var screen = new WarriorWaterCustom();
            WarriorWater temp = new WarriorWater();

            menuBorder.Child = screen;
            screen.DataContext = temp;
        }
    }
}