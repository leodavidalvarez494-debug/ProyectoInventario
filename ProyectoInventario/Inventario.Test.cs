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
    }
}
