using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomMenuSlider.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuBottomSlide : ContentPage
    {
        public MenuBottomSlide()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var displayInfo = DeviceDisplay.MainDisplayInfo;

            uint rate = 32;
            uint length = 500;

            if (StacklayoutBottom.Height == 0)
            {
                Action<double> callback = input => StacklayoutBottom.HeightRequest = input;

                double startHeight = 0;
                double endHeight = displayInfo.Height / 10;

                Easing easing = Easing.SinOut;

                StacklayoutBottom.Animate("in", callback, startHeight, endHeight, rate, length, easing);
            }
            else
            {
                Action<double> callback = input => StacklayoutBottom.HeightRequest = input;

                double startHeight = displayInfo.Height / 10;
                double endHeight = 0;

                Easing easing = Easing.CubicOut;

                StacklayoutBottom.Animate("out", callback, startHeight, endHeight, rate, length, easing);
            }
        }
    }
}