using Microsoft.AspNetCore.Components;
using PerfilProducto.Modals;

namespace PerfilProducto.Components.Pages
{
    public partial class ProductProfile: ComponentBase
    {
        private Product product;

        protected override void OnInitialized()
        {
            //Obtener el usuario de nuestro repositorio
            product = productoRepository.GetProduct();
            Console.WriteLine(product != null ? "Producto obtenido correctamente" : "No se obtuvo ningún producto");
        }

    }
}
