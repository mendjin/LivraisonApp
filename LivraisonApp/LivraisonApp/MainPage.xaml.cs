using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LivraisonApp
{
    
    public partial class MainPage : ContentPage
    {
        Page Accueil;
        public MainPage()
        {
            InitializeComponent();
            if (ShouldShowAccueil() == true)
            {
                App.Current.ModalPopping += Current_ModalPopping;
                var Accueil = new Accueil();
                Navigation.PushModalAsync(Accueil, false);
            }
        }

        private void Current_ModalPopping(object sender, ModalPoppingEventArgs e)
        {
            if (e.Modal == Accueil)
            {
               //FadeBox.FadeTo(0, 400);
                Accueil = null;
                App.Current.ModalPopping -= Current_ModalPopping;
            }
        }

        private bool ShouldShowAccueil()
        {
            return true;
           
        }

    }
}
