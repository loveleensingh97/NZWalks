using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.DTOs
{
    public class UpdateRegionRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Code has minimum 3 Characters")]
        [MaxLength(3, ErrorMessage = "Code has maximum 3 Characters")]
        public string Code { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Code has maximum 100 Characters")]
        public string Name { get; set; }

        public string? RegionImageUrl { get; set; }
    }
}
