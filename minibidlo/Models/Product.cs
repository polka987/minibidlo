using System.ComponentModel.DataAnnotations;

namespace minibidlo.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        public string Size { get; set; }

        [Required]
        public string Material { get; set; }

        public int Stock { get; set; }
    }
}
