using System.Collections.ObjectModel;
using Wintakam.Models;

namespace Wintakam;

public partial class MaisonsPage : ContentPage
{
    public ObservableCollection<Maison> Maisons { get; set; }

    public MaisonsPage()
    {
        InitializeComponent();

        // Données de démonstration
        Maisons = new ObservableCollection<Maison>
        {
            new Maison
            {
                Nom = "Magne Villa",
                Image = "house1.jpg",
                NombreChambres = 4,
                Superficie = 750,
                Prix = "55 000 000 FCFA",
                EstFavori = false,
                EstNouveau = true
            },
            new Maison
            {
                Nom = "Vallée de l'avenir",
                Image = "house2.jpg",
                NombreChambres = 4,
                Superficie = 1000,
                Prix = "80 000 000 FCFA",
                EstFavori = false,
                EstNouveau = true
            },
            new Maison
            {
                Nom = "Soleil levant",
                Image = "house3.jpg",
                NombreChambres = 3,
                Superficie = 1250,
                Prix = "35 000 000 FCFA",
                EstFavori = false,
                EstNouveau = false
            },
            new Maison
            {
                Nom = "Route de la liberté",
                Image = "house4.jpg",
                NombreChambres = 3,
                Superficie = 950,
                Prix = "38 000 000 FCFA",
                EstFavori = false,
                EstNouveau = false
            },
            new Maison
            {
                Nom = "Sauves nous",
                Image = "house5.jpg",
                NombreChambres = 4,
                Superficie = 850,
                Prix = "45 000 000 FCFA",
                EstFavori = false,
                EstNouveau = false
            },
            new Maison
            {
                Nom = "Villa beau séjour",
                Image = "house6.jpg",
                NombreChambres = 5,
                Superficie = 1200,
                Prix = "92 000 000 FCFA",
                EstFavori = false,
                EstNouveau = false
            }
        };

        MaisonsCollectionView.ItemsSource = Maisons;
    }

    private async void OnSearchClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Recherche", "Fonction de recherche à implémenter", "OK");
    }

    private async void OnFilterClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Filtres", "Options de filtrage avancé à implémenter", "OK");
    }

    private async void OnMaisonTapped(object sender, EventArgs e)
    {
        if (sender is Grid grid && grid.BindingContext is Maison maison)
        {
            // Navigation vers la page de détails avec les données de la maison
            var detailsPage = new DetailsProprietePage(maison);
            await Navigation.PushAsync(detailsPage);
        }
    }
}
