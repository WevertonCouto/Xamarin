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
        private const int FREIO_ABS = 800;
        private const int AR_CONDICIONADO = 1000;
        private const int MP3_PLAYER = 500;
        private Veiculo veiculo;

        public string TextoFreioAbs { get {
                return string.Format("Freio ABS - R$: {0}", FREIO_ABS) ;
            }
        }

        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar Condicionado - R$: {0}", AR_CONDICIONADO);
            }
        }

        public string TextoMP3Player
        {
            get
            {
                return string.Format("MP3 Player - R$: {0}", MP3_PLAYER);
            }
        }

        bool temFreioAbs { get; set; }
        public bool TemFreioABS
        {
            get {
                return temFreioAbs;
            }
            set
            {
                temFreioAbs = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
                DisplayAlert("Freio ABS", (temFreioAbs ? "Ligado!" : "Desligado!"), "Ok");
            }
        }

        bool temArCondicionado { get; set; }
        public bool TemArCondicionado
        {
            get
            {
                return temArCondicionado;
            }
            set
            {
                temArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
                DisplayAlert("Ar Condicionado", (temArCondicionado ? "Ligado!" : "Desligado!"), "Ok");
            }
        }

        bool temMP3Player { get; set; }
        public bool TemMP3Player
        {
            get
            {
                return temMP3Player;
            }
            set
            {
                temMP3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
                DisplayAlert("MP3 Player", (temMP3Player ? "Ligado!" : "Desligado!"), "Ok");
            }
        }


        public string ValorTotal { get { return string.Format("Valor total: R$ {0}", veiculo.Preco + (temFreioAbs ? FREIO_ABS : 0) + (temArCondicionado ? AR_CONDICIONADO : 0) + (temMP3Player ? MP3_PLAYER : 0));  } }
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