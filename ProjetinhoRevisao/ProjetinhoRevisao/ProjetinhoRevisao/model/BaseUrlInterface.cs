using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetinhoRevisao.model
{
    class BaseUrlInterface : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/Index.html";
        }
    }
}


