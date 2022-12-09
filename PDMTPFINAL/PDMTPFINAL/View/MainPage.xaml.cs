using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using Map = Xamarin.Forms.Maps.Map;
using PDMTPFINAL.View;

namespace PDMTPFINAL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked_Crud(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Crud());
        }

        private async void Button_clicked_Creditos(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Creditos());
        }
        
    }
}
