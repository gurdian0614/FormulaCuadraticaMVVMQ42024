using FormulaCuadraticaMVVMQ42024.Views;

namespace FormulaCuadraticaMVVMQ42024
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FormulaCuadraticaView();
        }
    }
}
