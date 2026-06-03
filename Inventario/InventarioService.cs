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

        private Producto? BuscarProducto(string codigo)
        {
            return productos.FirstOrDefault(
                p => p.Codigo == codigo);
        }

        public void RegistrarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> ListarProductos()
        {
            return new List<Producto>(productos);
        }
        public void ActualizarCantidad(string codigo, int nuevaCantidad)
        {

            var producto = BuscarProducto(codigo);

            if (producto != null)
            {
                producto.Cantidad = nuevaCantidad;
            }
        }

        public Producto? ConsultarProducto(string codigo)
        {
            return BuscarProducto(codigo);
        }
    
    }

}
