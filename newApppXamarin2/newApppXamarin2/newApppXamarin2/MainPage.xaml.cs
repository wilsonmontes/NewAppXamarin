using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace newApppXamarin2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.btnEnviar.Clicked += BtnEnviar_Clicked;
		}

        private void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Boton", "Evento desde CodeBehind", "Aceptar");
        }

        private void btn_Clicked(Object sender, EventArgs e)
        {
            DisplayAlert("Boton", "Evento desde XAML", "Aceptar");
        }
	}
}
