using System.ComponentModel.DataAnnotations;

namespace PerfilProducto.Modals
{
    public class Product
    {
        [Key]
        [Required(ErrorMessage = "Se necesita un Id como identificador del producto.")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Se necesitá un nombre de producto")]
        public string Name { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "El precio del producto debe ser mayor que 0.")]
        public decimal Price { get; set; }

        [StringLength(200, ErrorMessage = "La biografia no tener más de 200 caracteres.")]
        public string Description { get; set; }
    }
}
