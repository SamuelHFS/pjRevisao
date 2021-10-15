using ProjetinhoRevisao.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetinhoRevisao
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public ListView Content { get; }
        

        public MainPage()
        {
            InitializeComponent();
           
            ListView.ItemsSource = new List<Animais>

            {
                new Animais
                {
                    nome = "teste",
                    imagem = "gato.jpg",
                    tipo = "teste",
                    Peso = 5.9,
                    altura = 25,
                    sexo = "teste",
                    caracteristicas = "teste"
                },
                new Animais{
                  nome = "teste1",
                    imagem = "cachorro.jpg",
                    tipo = "teste1",
                    Peso = 5.9,
                    altura = 25,
                    sexo = "teste1",
                    caracteristicas = "teste1"
                }
            };
            ListView.ItemTemplate = new DataTemplate(typeof(ImageCell));
            ListView.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "imagem");
            ListView.ItemTemplate.SetBinding(ImageCell.TextProperty, "nome");
            ListView.ItemTemplate.SetBinding(ImageCell.DetailProperty, "caracteristicas");

            ListView.ItemSelected += ListView_ItemSelected;
            Content = ListView;

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var animais = e.SelectedItem as Animais;
            Detail = new NavigationPage(new Apresentacao(animais));
            IsPresented = false;
        }
    }
    }

