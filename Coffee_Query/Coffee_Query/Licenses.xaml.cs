using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Coffee_Query
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Licenses : ContentPage
    {
        public Licenses()
        {
            InitializeComponent();
        }

        #region General
        private async void ViewPixbayLicense(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://pixabay.com/service/license/"));
        }

        private async void ViewUnplashLicense(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://unsplash.com/license"));
        }

        private async void ViewCreator(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://github.com/Quanthis"));
        }
        #endregion

        #region SpecificThanks

        private async void ViewLatteMacchiato(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://pixabay.com/users/realsmarthome-4309228/"));
        }

        private async void ViewCappuccino(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://unsplash.com/@joshcouchdesign"));
        }

        private async void ViewMilk(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://unsplash.com/@enginakyurt"));
        }

        private async void ViewEspresso(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://unsplash.com/@nate_dumlao"));
        }

        private async void ViewBlack(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://unsplash.com/@pmiazga"));
        }

        private async void ViewLong(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://unsplash.com/@tak_tag"));
        }

        private async void ViewAmericano(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://unsplash.com/@patrickian4"));
        }

        private async void ViewDoubleEspresso(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://unsplash.com/@chasecreate"));
        }

        private async void ViewCappuccinoPlus(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://unsplash.com/@joshcouchdesign"));
            await Launcher.OpenAsync(new Uri(@"https://pixabay.com/users/nickype-10327513/"));
        }

        private async void ViewCappuccinoMix(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://unsplash.com/@pundalex"));
        }

        private async void ViewLatte(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://pixabay.com/users/stocksnap-894430/"));
        }

        private async void ViewFlatWhite(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://unsplash.com/@shaynamdouglas"));
        }

        private async void ViewEspressoMacchiato(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://www.instagram.com/p/CHlL7owljYe/?igshid=adzuelr29mif&fbclid=IwAR2KdAiNKuxUUCr6pfqQi4h0Y56CSCSl1HWfeq-Zoj-NPqX76YXFs5eC75U"));
        }

        private async void ViewBackground(object sender, EventArgs e)
        {
            await Launcher.OpenAsync(new Uri(@"https://unsplash.com/@the_savage_lens"));
        }

        #endregion
    }
}