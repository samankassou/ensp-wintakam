using Wintakam.Models;

namespace Wintakam;

public partial class DetailsProprietePage : ContentPage
{
    private Maison _maison;

    public DetailsProprietePage()
    {
        InitializeComponent();
        System.Diagnostics.Debug.WriteLine("DetailsProprietePage: Constructeur par défaut appelé");
    }

    public DetailsProprietePage(Maison maison) : this()
    {
        _maison = maison;
        System.Diagnostics.Debug.WriteLine($"DetailsProprietePage: Constructeur avec maison appelé - {maison?.Nom}");
        ChargerDetails();
    }

    private void ChargerDetails()
    {
        if (_maison != null)
        {
            // Définir le BindingContext pour les bindings XAML
            BindingContext = _maison;

            // Mise à jour manuelle des informations de base
            TitrePropriete.Text = _maison.Nom;
            ImagePrincipale.Source = _maison.Image;
        }
    }

    private async void OnRetourClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void OnSearchClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Recherche", "Fonction de recherche", "OK");
    }

    private void OnVoirPlusClicked(object sender, EventArgs e)
    {
        // Afficher plus de description
    }

    private async void OnAppelerClicked(object sender, EventArgs e)
    {
        try
        {
            PhoneDialer.Default.Open("+23700000000");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erreur", $"Impossible d'ouvrir le dialer: {ex.Message}", "OK");
        }
    }
}
