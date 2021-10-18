using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetinhoRevisao.model
{
    class aBaseUrlInterface : aIBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/IndexDog.html";
        }
    }
}
