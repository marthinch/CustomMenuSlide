using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomMenuSlider.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLeftSlide : ContentPage
    {
        public MenuLeftSlide()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var displayInfo = DeviceDisplay.MainDisplayInfo;

            uint rate = 32;
            uint length = 500;

            if (StacklayoutLeft.Width == 0)
            {
                Action<double> callback = input => StacklayoutLeft.WidthRequest = input;

                double startWidth = 0;
                double endWidth = displayInfo.Width / 5;

                Easing easing = Easing.SinOut;

                StacklayoutLeft.HeightRequest = displayInfo.Height;
                StacklayoutLeft.Animate("in", callback, startWidth, endWidth, rate, length, easing);
            }
            else
            {
                Action<double> callback = input => StacklayoutLeft.WidthRequest = input;

                double startWidth = displayInfo.Width / 5;
                double endWidth = 0;

                Easing easing = Easing.CubicOut;

                StacklayoutLeft.HeightRequest = displayInfo.Height;
                StacklayoutLeft.Animate("out", callback, startWidth, endWidth, rate, length, easing);
            }
        }
    }
}