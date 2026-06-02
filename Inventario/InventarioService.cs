using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public class InventarioService
    {
        private readonly List<Producto> productos = new();

        public void RegistrarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> ListarProductos()
        {
            return productos;
        }
        public void ActualizarCantidad(string codigo, int nuevaCantidad)
        {

            var producto = productos.FirstOrDefault(
                p => p.Codigo == codigo);

            if (producto != null)
            {
                producto.Cantidad = nuevaCantidad;
            }
        }

        public Producto ConsultarProducto(string codigo)
        {
            return null;
        }
    }

}
