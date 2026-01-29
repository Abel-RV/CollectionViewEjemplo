namespace CollectionViewEjemplo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        public AppShell MainPage { get; }
    }
}
