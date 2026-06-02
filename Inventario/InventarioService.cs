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
            foreach (var producto in productos)
            {
                if (producto.Codigo == codigo)
                {
                    producto.Cantidad = nuevaCantidad;
                }
            }
        }
    }
}
