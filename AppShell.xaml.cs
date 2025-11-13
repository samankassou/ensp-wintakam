namespace Wintakam
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Enregistrement des routes pour la navigation
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
            Routing.RegisterRoute("MaisonsPage", typeof(MaisonsPage));
            Routing.RegisterRoute("DetailsProprietePage", typeof(DetailsProprietePage));
        }
    }
}
