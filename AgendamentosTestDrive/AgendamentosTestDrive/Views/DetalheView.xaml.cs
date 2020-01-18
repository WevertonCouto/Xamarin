using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendamentosTestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage
    {
        private Veiculo veiculo;
        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Title = veiculo.Nome;
            this.veiculo = veiculo;
            this.BindingContext = this;
        }

        private void BtnProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(this.veiculo));
        }
    }
}