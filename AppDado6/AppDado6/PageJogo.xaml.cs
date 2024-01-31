using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDado6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageJogo : ContentPage
    {
        public PageJogo()
        {
            InitializeComponent();
            Random r = new Random();
            int n = r.Next(1, 6);
            if (n == 1)
            {
                imgDado.Source = "dado1";
            }
            else if(n == 2)
            {
                imgDado.Source = "dado2";
            }else if(n == 3)
            {
                imgDado.Source = "dado3";
            }else if (n == 4)
            {
                imgDado.Source = "dado4";
            }else if (n == 5)
            {
                imgDado.Source = "dado5";
            }
            else
            {
                imgDado.Source = "dado6";
            }
        }

        private async Task btVoltar_ClickedAsync(object sender, EventArgs e)
        {
            
        }

        private async void btVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}