using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                VdiariaA = 300.0,
                VdiariaC = 150.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                VdiariaA = 250.0,
                VdiariaC = 130.0
            },
            new Quarto()
            {
                Descricao = "Suíte Duplo",
                VdiariaA = 195.0,
                VdiariaC = 90.0
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                VdiariaA = 100.0,
                VdiariaC = 55.0
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.NewPage1());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}