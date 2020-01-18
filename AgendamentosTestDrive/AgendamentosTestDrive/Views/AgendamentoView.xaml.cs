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
    public partial class AgendamentoView : ContentPage
    {
        private Veiculo veiculo;
        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Title = veiculo.Nome;
            this.veiculo = veiculo;
            this.BindingContext = this;
        }
    }
}