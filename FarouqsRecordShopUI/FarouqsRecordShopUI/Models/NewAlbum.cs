using System.ComponentModel.DataAnnotations;

namespace FarouqsRecordShopUI.Models
{
    public class NewAlbum
    {
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Artist is required.")]
        public string Artist { get; set; }

        [Required(ErrorMessage = "Genre is required.")]
        public string Genre { get; set; }

        [Range(1900, 2026, ErrorMessage = "Release year must be between 1900 and 2026.")]
        public int ReleaseYear { get; set; }

        [Range(0, 10000, ErrorMessage = "Stock must be a positive number.")]
        public int Stock { get; set; }
    }
}
