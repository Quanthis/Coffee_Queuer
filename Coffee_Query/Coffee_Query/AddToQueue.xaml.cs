using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Coffee_Query
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddToQueue : ContentPage
    {
        private CoffeeCounter loadCoffees;

        public AddToQueue(CoffeeCounter content)
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

        private async void GoToFillingOrders(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RemoveFromQueue(loadCoffees));
        }

        private async void IncreaseLatteMacchiatioAmount(object sender, EventArgs e)
        {
            LatteMacchiatoDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.LatteMachiatio , LatteMacchiatoDisplay);
        }

        private async void IncreaseCappucinoAmount(object sender, EventArgs e)
        {
            CappucinoDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Cappucino, CappucinoDisplay);
        }

        private async void IncreaseMilkAmount(object sender, EventArgs e)
        {
            MilkDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Milk, MilkDisplay);
        }

        private async void IncreaseBlackAmount(object sender, EventArgs e)
        {
            BlackoDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Black, BlackoDisplay);
        }

        private async void IncreaseLongAmount(object sender, EventArgs e)
        {
            LongDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Long, LongDisplay);
        }

        private async void IncreaseEspressoAmount(object sender, EventArgs e)
        {
            EspressoDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Espresso, EspressoDisplay);
        }

        private async void ChangeDoppioAmount(object sender, EventArgs e)
        {
            DoppioPlusDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.DoppioPlus, DoppioPlusDisplay);
        }

        private async void ChangeAmericanoAmount(object sender, EventArgs e)
        {
            AmericanoDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Americano, AmericanoDisplay);
        }

        private async void ChangeEspressox2Amount(object sender, EventArgs e)
        {
            Espressox2Display = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Espressox2, Espressox2Display);
        }

        private async void ChangeCappuccinoPlusAmount(object sender, EventArgs e)
        {
            CappuinoPlusDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.CappuccinoPlus, CappuinoPlusDisplay);
        }

        private async void ChangeCappuccinoMixAmount(object sender, EventArgs e)
        {
            CappuinoMixDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.CappuccinoMix, CappuinoMixDisplay);
        }

        private async void ChangeLatteAmount(object sender, EventArgs e)
        {
            LatteDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Latte, LatteDisplay);
        }

        private async void ChangeFlatWhiteAmount(object sender, EventArgs e)
        {
            FlatWhiteDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.FlatWhite, FlatWhiteDisplay);
        }

        private async void ChangeEspressoMacchiatoAmount(object sender, EventArgs e)
        {
            EspressoMacchiatoDisplay = loadCoffees.ReturnCheckedAmount(false, CoffeeCounter.Coffees.EspressoMacchiato, EspressoMacchiatoDisplay);
        }
    }
}