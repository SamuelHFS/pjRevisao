using ProjetinhoRevisao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(aBaseUrlInterface))]
namespace ProjetinhoRevisao.model
{
    interface aIBaseUrl
    {
        string Get();
    }
}

