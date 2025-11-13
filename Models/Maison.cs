namespace Wintakam.Models
{
    public class Maison
    {
        public string Nom { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int NombreChambres { get; set; }
        public int Superficie { get; set; }
        public string Prix { get; set; } = string.Empty;
        public bool EstFavori { get; set; }
        public bool EstNouveau { get; set; }
    }
}
