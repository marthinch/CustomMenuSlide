using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomMenuSlider.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonMenuTopSlider_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuTopSlide());
        }

        private async void ButtonMenuBottomSlider_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuBottomSlide());
        }

        private async void ButtonMenuLeftSlider_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuLeftSlide());
        }
    }
}