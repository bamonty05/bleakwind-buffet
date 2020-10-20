/*
 * Author: Brett Montgomery
 * Class name: OrderComponent.xaml.cs
 * Purpose: User Control Class to represent the order window
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Order;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Customizations;
using PointOfSale;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        public OrderComponent()
        {
            InitializeComponent();            
        }

        public MenuSelection MenuSelection { get; set; }

        // Remove button click event handler
        private void RemoveButtonClick(object sender, RoutedEventArgs e)
        {
            var screen = new OrderComponent();
            if (DataContext is Order order)
            {
                var btn = sender as Button;
                order.Remove(btn.DataContext as IOrderItem);
            }
        }

        // Edit item click event handler
        private void EditItemClick(object sender, SelectionChangedEventArgs e)
        {
            if (OrderList.SelectedItem == null)
            {
                return;
            }

            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow || parent is null));

            if (parent is MainWindow menu)
            {
                string itemString = OrderList.SelectedItem.ToString();

                if (itemString.Contains("Briarheart Burger"))
                {

                    BriarheartBurger item = e.AddedItems[0] as BriarheartBurger;
                    if (DataContext is Order order)
                    {
                        var screen = new BriarheartBurgerCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }

                }

                if (itemString.Contains("Double Draugr"))
                {

                    DoubleDraugr item = e.AddedItems[0] as DoubleDraugr;
                    if (DataContext is Order order)
                    {
                        var screen = new DoubleDraugrCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Thalmor Triple"))
                {

                    ThalmorTriple item = e.AddedItems[0] as ThalmorTriple;
                    if (DataContext is Order order)
                    {
                        var screen = new ThalmorTripleCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Garden Orc Omelette"))
                {

                    GardenOrcOmelette item = e.AddedItems[0] as GardenOrcOmelette;
                    if (DataContext is Order order)
                    {
                        var screen = new GardenOrcOmeletteCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Philly Poacher"))
                {

                    PhillyPoacher item = e.AddedItems[0] as PhillyPoacher;
                    if (DataContext is Order order)
                    {
                        var screen = new PhillyPoacherCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Smokehouse Skeleton"))
                {

                    SmokehouseSkeleton item = e.AddedItems[0] as SmokehouseSkeleton;
                    if (DataContext is Order order)
                    {
                        var screen = new SmokehouseSkeletonCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Thugs T-Bone"))
                {

                    ThugsTBone item = e.AddedItems[0] as ThugsTBone;
                    if (DataContext is Order order)
                    {
                        var screen = new ThugsTBoneCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Dragonborn Waffle Fries"))
                {

                    DragonbornWaffleFries item = e.AddedItems[0] as DragonbornWaffleFries;
                    if (DataContext is Order order)
                    {
                        var screen = new DragonbornWaffleFriesCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Fried Miraak"))
                {

                    FriedMiraak item = e.AddedItems[0] as FriedMiraak;
                    if (DataContext is Order order)
                    {
                        var screen = new FriedMiraakCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Mad Otar Grits"))
                {

                    MadOtarGrits item = e.AddedItems[0] as MadOtarGrits;
                    if (DataContext is Order order)
                    {
                        var screen = new MadOtarGritsCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Vokun Salad"))
                {

                    VokunSalad item = e.AddedItems[0] as VokunSalad;
                    if (DataContext is Order order)
                    {
                        var screen = new VokunSaladCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Arentino Apple Juice"))
                {

                    ArentinoAppleJuice item = e.AddedItems[0] as ArentinoAppleJuice;
                    if (DataContext is Order order)
                    {
                        var screen = new ArentinoAppleJuiceCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Candlehearth Coffee"))
                {

                    CandlehearthCoffee item = e.AddedItems[0] as CandlehearthCoffee;
                    if (DataContext is Order order)
                    {
                        var screen = new CandlehearthCoffeeCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Markarth Milk"))
                {

                    MarkarthMilk item = e.AddedItems[0] as MarkarthMilk;
                    if (DataContext is Order order)
                    {
                        var screen = new MarkarthMilkCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Sailor Soda"))
                {

                    SailorSoda item = e.AddedItems[0] as SailorSoda;
                    if (DataContext is Order order)
                    {
                        var screen = new SailorSodaCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }

                if (itemString.Contains("Warrior Water"))
                {

                    WarriorWater item = e.AddedItems[0] as WarriorWater;
                    if (DataContext is Order order)
                    {
                        var screen = new WarriorWaterCustom();
                        screen.DataContext = item;
                        menu.displayBorder.Child = screen;
                    }
                }
            }
        }
    }
}
