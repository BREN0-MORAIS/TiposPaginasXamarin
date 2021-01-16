using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposPagina.TipoPagina.Carrosel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipoPagina3 : ContentPage
    {
        public TipoPagina3()
        {
            InitializeComponent();
        }

        private void MudarPagina(object sender , EventArgs args)
        {
            //Precisa Englobar na NavigationPage para manter o historico e poder voltar
           App.Current.MainPage = new NavigationPage (new Navigation.Page1() );
        }
    }
}