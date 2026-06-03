using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Inventario.Tests
{
    [TestClass]
    public class InventarioTest
    {
        [TestMethod]
        public void RegistrarProducto()
        {
            var inventario = new InventarioService();

            inventario.RegistrarProducto(
                new Producto("P001", "Mouse", 10));

            Assert.AreEqual(
                1,
                inventario.ListarProductos().Count);
        }

        [TestMethod]
        public void ActualizarCantidadProducto()
        {
            var inventario = new InventarioService();

            inventario.RegistrarProducto(
                new Producto("P001", "Mouse", 10));

            inventario.ActualizarCantidad("P001", 20);

            Assert.AreEqual(
                20,
                inventario.ListarProductos()[0].Cantidad);
        }

        [TestMethod]
        public void ConsultarProducto()
        {
            var inventario = new InventarioService();

            inventario.RegistrarProducto(
                new Producto("P001", "Mouse", 10));

            var producto = inventario.ConsultarProducto("P001");

            Assert.IsNotNull(producto);
            Assert.AreEqual("Mouse", producto.Nombre);
        }

        [TestMethod]
        public void ListarProductos()
        {
            var inventario = new InventarioService();

            inventario.RegistrarProducto(
                new Producto("P001", "Mouse", 10));

            inventario.RegistrarProducto(
                new Producto("P002", "Teclado", 5));

            var productos = inventario.ListarProductos();

            Assert.AreEqual(2, productos.Count);
        }
    }
}
