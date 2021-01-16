using System;
using TiposPagina.TipoPagina.Carrosel;
using TiposPagina.TipoPagina.MasterDetails;
using TiposPagina.TipoPagina.Navigation;
using TiposPagina.TipoPagina.TabPag;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposPagina
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Page1();
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
