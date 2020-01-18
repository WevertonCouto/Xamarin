using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendamentosTestDrive
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<Veiculo> listVeiculos { get; set; }
        public MainPage()
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
    }


    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
