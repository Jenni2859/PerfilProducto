using Microsoft.AspNetCore.Components;
using PerfilProducto.Modals;

namespace PerfilProducto.Components.Pages
{
    public partial class ProductDetails: ComponentBase
    {
        [Parameter]
        public Product product { get; set; }
    }
}
