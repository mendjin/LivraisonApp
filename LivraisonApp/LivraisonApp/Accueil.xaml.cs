using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LivraisonApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Accueil : ContentPage
    {
        public Accueil()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            //MyRadialGradient.RadiusX = this.Width * 6;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           // await FadeBox.FadeTo(1, 500);
            await Navigation.PopModalAsync(false);
        }
    }
}