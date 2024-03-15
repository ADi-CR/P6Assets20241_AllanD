using P6Assets20241_AllanD.Views;

namespace P6Assets20241_AllanD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
