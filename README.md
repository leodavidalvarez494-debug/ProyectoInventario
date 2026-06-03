# ProyectoInventario 📦

Un sistema de gestión de inventario completo desarrollado en **C#** que permite administrar productos de forma eficiente.

## 📋 Descripción

**ProyectoInventario** es una aplicación que proporciona herramientas para la gestión integral de tu inventario. Puedes registrar nuevos productos, actualizar información existente, consultar detalles de productos y listar todo tu inventario.

## ✨ Características

- ✅ **Registrar productos** - Agregar nuevos productos al inventario
- ✅ **Actualizar productos** - Modificar información de productos existentes
- ✅ **Consultar información** - Ver detalles específicos de cada producto
- ✅ **Listar productos** - Visualizar todos los productos del inventario
- ✅ **Gestión completa de CRUD** - Operaciones Create, Read, Update, Delete
- ✅ **Suite de pruebas unitarias** - Tests con MSTest para validar funcionalidad

## 🛠️ Tecnologías Utilizadas

- **Lenguaje:** C#
- **Framework:** .NET 8.0
- **Testing:** MSTest v3.6.4
- **IDE:** Visual Studio 2019+

## 📦 Instalación

### Requisitos Previos
- Visual Studio 2019 o superior
- .NET 8.0 SDK
- Git

### Pasos de instalación

1. **Clonar el repositorio:**
```bash
git clone https://github.com/leodavidalvarez494-debug/ProyectoInventario.git
cd ProyectoInventario
```

2. **Abrir el proyecto:**
```bash
# Abre el proyecto en Visual Studio
start ProyectoInventario.sln
```

3. **Restaurar dependencias:**
```bash
dotnet restore
```

4. **Compilar el proyecto:**
```bash
dotnet build
```

## 🚀 Uso

### Ejecutar la aplicación
```bash
dotnet run
```

### Ejecutar pruebas
```bash
dotnet test
```

### Operaciones disponibles

#### 1. Registrar un producto
```csharp
var inventario = new InventarioService();
inventario.RegistrarProducto(new Producto("P001", "Mouse", 10));
```

#### 2. Actualizar cantidad
```csharp
inventario.ActualizarCantidad("P001", 20);
```

#### 3. Consultar producto
```csharp
var producto = inventario.ConsultarProducto("P001");
```

#### 4. Listar productos
```csharp
var productos = inventario.ListarProductos();
```

## 📁 Estructura del Proyecto

```
ProyectoInventario/
├── .gitignore
├── ProyectoInventario.sln
├── Inventario/                    # Proyecto principal
│   ├── Inventario.csproj
│   ├── Producto.cs               # Modelo de producto
│   └── InventarioService.cs      # Servicio de negocio
└── ProyectoInventario/            # Proyecto de pruebas
    ├── Inventario.Tests.csproj
    ├── Inventario.Test.cs        # Tests unitarios
    └── MSTestSettings.cs
```

## 🧪 Pruebas Unitarias

El proyecto incluye 4 tests principales:

- ✅ **RegistrarProducto** - Verifica que se agregan productos correctamente
- ✅ **ActualizarCantidadProducto** - Verifica que se actualiza la cantidad
- ✅ **ConsultarProducto** - Verifica la búsqueda por código
- ✅ **ListarProductos** - Verifica el listado de todos los productos

Ejecuta con: `dotnet test`

## 📋 Modelo de Datos

### Clase Producto
```csharp
public class Producto
{
    public string Codigo { get; set; }      // Identificador único
    public string Nombre { get; set; }      // Nombre del producto
    public int Cantidad { get; set; }       // Cantidad en inventario
    
    public Producto(string codigo, string nombre, int cantidad)
}
```

### Servicio InventarioService
Métodos disponibles:
- `RegistrarProducto(Producto)` - Agregar producto
- `ListarProductos()` - Obtener todos los productos
- `ActualizarCantidad(string codigo, int nuevaCantidad)` - Actualizar cantidad
- `ConsultarProducto(string codigo)` - Buscar por código

## 🤝 Contribuir

Las contribuciones son bienvenidas. Si deseas contribuir:

1. Fork el repositorio
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## 📝 Licencia

Este proyecto está disponible bajo la licencia que especifiques. Por el momento, no tiene licencia asignada.

## 👨‍💻 Autor

**leodavidalvarez494-debug**

Puedes contactarme a través de GitHub: [@leodavidalvarez494-debug](https://github.com/leodavidalvarez494-debug)

## 🐛 Reportar Problemas

Si encuentras algún error o tienes sugerencias de mejora, por favor abre un [Issue](https://github.com/leodavidalvarez494-debug/ProyectoInventario/issues).

## 📞 Soporte

Para soporte o preguntas sobre el proyecto, abre una discusión en la sección de [Discussions](https://github.com/leodavidalvarez494-debug/ProyectoInventario/discussions).

---

**Última actualización:** 03 de junio de 2026

¡Gracias por usar ProyectoInventario! 🎉
