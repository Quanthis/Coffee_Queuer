using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
