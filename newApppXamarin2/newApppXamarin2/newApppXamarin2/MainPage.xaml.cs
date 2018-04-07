using System;
using System.Collections.Generic;
using System.Globalization;
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
            //this.btnEnviar.Clicked += BtnEnviar_Clicked;
            //this.dtpFechaInicial.DateSelected += DtpFechaInicial_DateSelected;
            //edDesc.Completed += EdDesc_Completed;
            //edDesc.TextChanged += EdDesc_TextChanged;
            //entPassword.Completed += EntPassword_Completed;
           // entPassword.TextChanged += EntPassword_TextChanged;
		}

        private void EntPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            DisplayAlert("Se esta cambiando", "Cargando", "Aceptar");
        }

        private void EntPassword_Completed(object sender, EventArgs e)
        {
            DisplayAlert("Este es el texto", "Completo", "Aceptar");
        }

        private void EdDesc_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            DisplayAlert("Se esta cambiando", "Cargando", "Aceptar");
        }

        private void EdDesc_Completed(object sender, EventArgs e)
        {
            DisplayAlert("Texto completo", "Completo", "Aceptar");
        }

        private void DtpFechaInicial_DateSelected(object sender, DateChangedEventArgs e)
        {
            //CultureInfo culture = new CultureInfo("es-Es");
            //DisplayAlert("Fecha", e.NewDate.ToString(), "Aceptar");
            //DisplayAlert("Fecha",e.NewDate.ToString("D",culture),"Aceptar");

            CultureInfo culture = new CultureInfo("en-US");
            DisplayAlert("Fecha", e.NewDate.ToString("D", culture), "Aceptar");
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
