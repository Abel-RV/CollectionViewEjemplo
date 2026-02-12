using CollectionViewEjemplo.Pages;

namespace CollectionViewEjemplo
{
    public partial class App : Application
    {
        public App(CollectionViewDemo mainPage)
        {
            InitializeComponent();
            MainPage = new NavigationPage(mainPage);

        }

    }
}