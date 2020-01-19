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
        private Veiculo veiculo { get; set;  }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        DateTime dataAgendamento = DateTime.Now;
        public DateTime DataAgendamento {
            get
            {
                return dataAgendamento;
            }
            set {
                dataAgendamento = value;
            } }
        public TimeSpan HoraAgendamento { get; set; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Title = veiculo.Nome;
            this.veiculo = veiculo;
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento", string.Format("Nome: {0}\nFone: {1}\nE-mail: {2}\nData Agendamento: {3}\nHora Agendamento: {4}", this.Nome, this.Telefone, this.Email, this.DataAgendamento.ToString('dd/MM/yyyy'), this.HoraAgendamento), "Ok");
        }
    }
}