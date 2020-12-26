using System;
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

                DoppioPlusDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.DoppioPlus, DoppioPlusDisplay);
                AmericanoDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.Americano, AmericanoDisplay);
                Espressox2Display = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.Espressox2, Espressox2Display);
                CappuinoPlusDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.CappuccinoPlus, CappuinoPlusDisplay);
                CappuinoMixDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.CappuccinoMix, CappuinoMixDisplay);
                LatteDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.Latte, LatteDisplay);
                FlatWhiteDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.FlatWhite, FlatWhiteDisplay);
                EspressoMacchiatoDisplay = loadCoffees.ReturnCheckedAmount(CoffeeCounter.Coffees.EspressoMacchiato, EspressoMacchiatoDisplay);
            });
        }

        private async void GoToCollectingOrders(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddToQueue(loadCoffees));
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

        private async void ChangeDoppioAmount(object sender, EventArgs e)
        {
            DoppioPlusDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.DoppioPlus, DoppioPlusDisplay);
        }

        private async void ChangeAmericanoAmount(object sender, EventArgs e)
        {
            AmericanoDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.Americano, AmericanoDisplay);
        }

        private async void ChangeEspressox2Amount(object sender, EventArgs e)
        {
            Espressox2Display = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.Espressox2, Espressox2Display);
        }

        private async void ChangeCappuccinoPlusAmount(object sender, EventArgs e)
        {
            CappuinoPlusDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.CappuccinoPlus, CappuinoPlusDisplay);
        }

        private async void ChangeCappuccinoMixAmount(object sender, EventArgs e)
        {
            CappuinoMixDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.CappuccinoMix, CappuinoMixDisplay);
        }

        private async void ChangeLatteAmount(object sender, EventArgs e)
        {
            LatteDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.Latte, LatteDisplay);
        }

        private async void ChangeFlatWhiteAmount(object sender, EventArgs e)
        {
            FlatWhiteDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.FlatWhite, FlatWhiteDisplay);
        }

        private async void ChangeEspressoMacchiatoAmount(object sender, EventArgs e)
        {
            EspressoMacchiatoDisplay = loadCoffees.ReturnCheckedAmount(true, CoffeeCounter.Coffees.EspressoMacchiato, EspressoMacchiatoDisplay);
        }
    }
}