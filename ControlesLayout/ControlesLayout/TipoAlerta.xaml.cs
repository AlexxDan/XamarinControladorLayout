using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipoAlerta : ContentPage
    {
        public TipoAlerta()
        {
            InitializeComponent();
            this.botonsimple.Clicked += Botonsimple_Clicked;
            this.botonopciones.Clicked += Botonopciones_Clicked;
            this.botonmodal.Clicked += Botonmodal_Clicked;
            this.botonokcancel.Clicked += Botonokcancel_Clicked1;
        }

        private async void Botonmodal_Clicked(object sender, EventArgs e)
        {
            PaginaModal modal = new PaginaModal();
            await Navigation.PushModalAsync(modal);
        }

        private async void Botonokcancel_Clicked1(object sender, EventArgs e)
        {
            bool respuesta= await DisplayAlert("Pregunta.... "
                ,"Pregunta de prueba???","SI","NO");

            if (respuesta == true)
            {
                this.lblrespuesta.Text = "Es cierta la afirmacion";
            }
            else
            {
                this.lblrespuesta.Text = "No es cierta la afirmacion";
            }
        }

        private async void Botonopciones_Clicked(object sender, EventArgs e)
        {
            String opcion = await DisplayActionSheet("Que empresas quieres?", "Aceptar"
                , "Cancelar", "Prueba 1","Prueba 2","Pruebas 3");

            this.lblrespuesta.Text = opcion;
        }

        private void Botonsimple_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Titulo", "Mensaje simple ", "OK");
        }
    }
}