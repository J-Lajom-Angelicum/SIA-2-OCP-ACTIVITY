using System.ComponentModel.DataAnnotations;

namespace SIA_2_OCP_ACTIVITY.Models.DTO
{
    public class ProductCreateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Size { get; set; }
    }
}
