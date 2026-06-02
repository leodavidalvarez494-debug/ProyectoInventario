using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public class InventarioService
    {
        private List<Producto> productos = new List<Producto>();

        public void RegistrarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> ListarProductos()
        {
            return productos;
        }
    }
}
