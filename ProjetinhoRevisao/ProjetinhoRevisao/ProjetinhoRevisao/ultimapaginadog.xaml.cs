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
    public partial class ultimapaginadog : ContentPage
    {
        public ultimapaginadog()
        {
            InitializeComponent();
        }

        private void btHtmlLocal(object sender, EventArgs e)
        {
            var html2 = new HtmlWebViewSource();
            html2.BaseUrl = DependencyService.Get<aIBaseUrl>().Get();
            wv1.Source = html2.BaseUrl;
            
        }

        
    }
}

