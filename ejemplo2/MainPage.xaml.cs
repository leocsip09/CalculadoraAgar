using Microsoft.Maui.Controls;

namespace ejemplo2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCalculadoraAgarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalculadoraAgarPage());
        }

        private async void OnInformacionAgarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InformacionAgarPage());
        }
    }
}