using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coffee_Query
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RemoveFromQueue : ContentPage
    {
        private CoffeeCounter loadCoffees;
        public RemoveFromQueue(CoffeeCounter content)
        {
            InitializeComponent();
            this.loadCoffees = content;

            ShowAmounts();
        }

        private async Task ShowAmounts()
        {
            await Task.Run(() =>
            {
                LatteMacchiatoDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.LatteMachiatio, LatteMacchiatoDisplay);
                CappucinoDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.Cappucino, CappucinoDisplay);
                MilkDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.Milk, MilkDisplay);
                BlackoDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.Black, BlackoDisplay);
                LongDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.Long, LongDisplay);
                EspressoDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.Espresso, EspressoDisplay);
            });
        }

        private async void DecreaseLatteMacchiatioAmount(object sender, EventArgs e)
        {
            LatteMacchiatoDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.LatteMachiatio, LatteMacchiatoDisplay);
        }

        private async void DecreaseCappucinoAmount(object sender, EventArgs e)
        {
            CappucinoDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.Cappucino, CappucinoDisplay);
        }

        private async void DecreaseMilkAmount(object sender, EventArgs e)
        {
            MilkDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.Milk, MilkDisplay);
        }

        private async void DecreaseBlackAmount(object sender, EventArgs e)
        {
            BlackoDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.Black, BlackoDisplay);
        }

        private async void DecreaseLongAmount(object sender, EventArgs e)
        {
            LongDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.Long, LongDisplay);
        }

        private async void DecreaseEspressoAmount(object sender, EventArgs e)
        {
            EspressoDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.Espresso, EspressoDisplay);
        }
    }
}