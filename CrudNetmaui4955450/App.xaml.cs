namespace CrudNetmaui4955450
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage(); // Eliminada la segunda instancia
        }
    }
}
