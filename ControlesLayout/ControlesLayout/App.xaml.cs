using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PaginaEstilo());
            //MainPage = new TipoAlerta();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
