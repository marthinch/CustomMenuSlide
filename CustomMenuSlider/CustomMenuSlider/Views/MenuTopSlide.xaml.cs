using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomMenuSlider.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuTopSlide : ContentPage
    {
        public MenuTopSlide()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var displayInfo = DeviceDisplay.MainDisplayInfo;

            uint rate = 32;
            uint length = 500;

            if (StacklayoutTop.Height == 0)
            {
                Action<double> callback = input => StacklayoutTop.HeightRequest = input;

                double startHeight = 0;
                double endHeight = displayInfo.Height / 10;

                Easing easing = Easing.SinOut;

                StacklayoutTop.Animate("in", callback, startHeight, endHeight, rate, length, easing);
            }
            else
            {
                Action<double> callback = input => StacklayoutTop.HeightRequest = input;

                double startHeight = displayInfo.Height / 10;
                double endHeight = 0;

                Easing easing = Easing.CubicOut;

                StacklayoutTop.Animate("out", callback, startHeight, endHeight, rate, length, easing);
            }
        }
    }
}