using AgendamentosTestDrive.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace AgendamentosTestDrive
{
    [DesignTimeVisible(false)]
    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> listVeiculos { get; set; }
        public ListagemView()
        {
            InitializeComponent();

            this.listVeiculos = new List<Veiculo>
            {
                new Veiculo {Nome = "Azera V6", Preco = 60000},
                new Veiculo {Nome = "Fiesta 2.0", Preco = 5000},
                new Veiculo {Nome = "HB20 S", Preco = 40000},
            };

            //listViewVeiculos.ItemsSource = this.listVeiculos;
            this.BindingContext = this;
        }

        private void ListViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;
            Navigation.PushAsync(new DetalheView());
        }
    }


    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado
        {
            get
            {
                return String.Format("R$ {0}", this.Preco);
            }
        }
    }
}
