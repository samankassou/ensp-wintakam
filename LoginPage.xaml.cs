namespace Wintakam;

public partial class LoginPage : ContentPage
{
    private bool _isPasswordVisible = false;

    public LoginPage()
    {
        InitializeComponent();
    }

    private void OnTogglePasswordClicked(object sender, EventArgs e)
    {
        _isPasswordVisible = !_isPasswordVisible;
        PasswordEntry.IsPassword = !_isPasswordVisible;

        // Changer l'icône (vous devrez ajouter les images eye.png et eye_off.png)
        TogglePasswordButton.Source = _isPasswordVisible ? "eye.png" : "eye_off.png";
    }

    private async void OnSeConnecterClicked(object sender, EventArgs e)
    {
        // Validation basique
        if (string.IsNullOrWhiteSpace(EmailEntry.Text))
        {
            await DisplayAlert("Erreur", "Veuillez entrer votre email", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(PasswordEntry.Text))
        {
            await DisplayAlert("Erreur", "Veuillez entrer votre mot de passe", "OK");
            return;
        }

        // TODO: Implémenter la logique de connexion
        // Navigation vers la page de listing des maisons
        await Shell.Current.GoToAsync("///MaisonsPage");
    }

    private async void OnGoogleLoginClicked(object sender, EventArgs e)
    {
        // TODO: Implémenter la connexion Google
        await DisplayAlert("Info", "Connexion avec Google en cours de développement", "OK");
    }

    private async void OnFacebookLoginClicked(object sender, EventArgs e)
    {
        // TODO: Implémenter la connexion Facebook
        await DisplayAlert("Info", "Connexion avec Facebook en cours de développement", "OK");
    }

    private async void OnSenregistrerTapped(object sender, EventArgs e)
    {
        // TODO: Naviguer vers la page d'inscription
        await DisplayAlert("Info", "Page d'inscription à venir", "OK");
    }

    private async void OnRetourTapped(object sender, EventArgs e)
    {
        // Retour à la page précédente
        await Shell.Current.GoToAsync("..");
    }
}
