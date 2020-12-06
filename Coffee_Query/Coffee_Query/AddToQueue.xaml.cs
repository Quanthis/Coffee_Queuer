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
    public partial class AddToQueue : ContentPage
    {
        private CoffeeCounter loadContent;

        public AddToQueue(CoffeeCounter content)
        {
            InitializeComponent();

            this.loadContent = content;
        }

        private async void IncreaseLatteMacchiatioAmount(object sender, EventArgs e)
        {
            LatteMacchiatoDisplay = loadContent.ReturnCheckedAmount(false, CoffeeCounter.Coffees.LatteMachiatio , LatteMacchiatoDisplay);
        }

        private async void IncreaseCappucinoAmount(object sender, EventArgs e)
        {
            CappucinoDisplay = loadContent.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Cappucino, CappucinoDisplay);
        }

        private async void IncreaseMilkAmount(object sender, EventArgs e)
        {
            MilkDisplay = loadContent.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Milk, MilkDisplay);
        }

        private async void IncreaseBlackAmount(object sender, EventArgs e)
        {
            BlackoDisplay = loadContent.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Black, BlackoDisplay);
        }

        private async void IncreaseLongAmount(object sender, EventArgs e)
        {
            LongDisplay = loadContent.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Long, LongDisplay);
        }

        private async void IncreaseEspressoAmount(object sender, EventArgs e)
        {
            EspressoDisplay = loadContent.ReturnCheckedAmount(false, CoffeeCounter.Coffees.Espresso, EspressoDisplay);
        }
    }
}