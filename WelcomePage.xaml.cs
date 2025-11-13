namespace Wintakam;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        InitializeComponent();
    }

    private async void OnContinuerClicked(object sender, EventArgs e)
    {
        // Navigation vers la page de login
        await Shell.Current.GoToAsync("LoginPage");
    }
}
