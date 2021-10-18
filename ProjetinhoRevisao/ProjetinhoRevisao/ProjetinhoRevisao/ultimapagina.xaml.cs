using ProjetinhoRevisao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetinhoRevisao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ultimapagina : ContentPage
    {
     

        public ultimapagina()
        {
            InitializeComponent();
            MainPage = new ToolbarItens();
        }

        public ToolbarItens MainPage { get; }

        private void btHtmlLocal(object sender, EventArgs e)
        {
            var html2 = new HtmlWebViewSource();
            html2.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            wv1.Source = html2.BaseUrl;
        }

       
    }
}

        