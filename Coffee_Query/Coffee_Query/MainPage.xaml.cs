using System;
using Xamarin.Forms;

namespace Coffee_Query
{
    public partial class MainPage : ContentPage
    {
        private CoffeeCounter counter;

        public MainPage()
        {
            InitializeComponent();
            counter = new CoffeeCounter();
        }

        private async void OnAdd(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddToQueue(counter));
        }

        private async void OnRemove(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RemoveFromQueue(counter));
        }

        private async void MoveToLicenses(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Coffee_Query.Licenses());
        }
    }
}
