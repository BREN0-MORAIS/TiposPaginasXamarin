using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposPagina.TipoPagina.MasterDetails
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void MudarPagina1(Object sender , EventArgs args)
        {
            Detail = new Navigation.Page1();
            IsPresented = false;
        }
        private void MudarPagina2(Object sender, EventArgs args)
        {
            Detail = new Navigation.Page2();
            IsPresented = false;
        }
        private void MudarConteudo(Object sender, EventArgs args)
        {
            Detail = new Conteudo();
            IsPresented = false;
        }
    }
}