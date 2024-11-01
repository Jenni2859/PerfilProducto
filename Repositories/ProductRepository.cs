using PerfilProducto.Modals;
using PerfilProducto.Repositories.Interfaces;

namespace PerfilProducto.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProduct()
        {
            return new Product
            {
                Id = 02859,
                Name = "GLOSS DIOR",
                Price = 12000,
                Description = "Gloss Dior super hidrantante color rosa, para darle un toque de brillo de tus maquillajes."
            };

        }
    }
}
