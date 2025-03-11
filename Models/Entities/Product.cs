using System.ComponentModel.DataAnnotations;

namespace CRUD_Task.Models.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name must be between 3 and 50 characters.", MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name can only contain letters and spaces.")]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }
        [Required]
        public int Quantity { get; set; }

    }
}
