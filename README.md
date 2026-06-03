# ProyectoInventario 📦

Un sistema de gestión de inventario completo desarrollado en **C#** que permite administrar productos de forma eficiente.

## 📋 Descripción

**ProyectoInventario** es una aplicación que proporciona herramientas para la gestión integral de tu inventario. Puedes registrar nuevos productos, actualizar información existente, consultar detalles específicos y visualizar un listado completo de todos los artículos disponibles.

## ✨ Características

- ✅ **Registrar productos** - Agregar nuevos productos al inventario
- ✅ **Actualizar productos** - Modificar información de productos existentes
- ✅ **Consultar información** - Ver detalles específicos de cada producto
- ✅ **Listar productos** - Visualizar todos los productos del inventario
- ✅ **Gestión completa de CRUD** - Operaciones Create, Read, Update, Delete

## 🛠️ Tecnologías Utilizadas

- **Lenguaje:** C#
- **Plataforma:** .NET Framework / .NET Core

## 📦 Instalación

### Requisitos Previos
- Visual Studio 2019 o superior
- .NET Framework 4.7+ o .NET 5+
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

### Operaciones disponibles

#### 1. Registrar un producto
```
Ingresa el nombre del producto, cantidad y precio
El sistema asignará un ID automático
```

#### 2. Actualizar un producto
```
Proporciona el ID del producto y los nuevos datos
El sistema actualizará la información
```

#### 3. Consultar información
```
Especifica el ID del producto para ver sus detalles
```

#### 4. Listar productos
```
Visualiza todos los productos registrados en el inventario
```

## 📁 Estructura del Proyecto

```
ProyectoInventario/
├── src/
│   ├── Models/           # Clases de modelo (Producto)
│   ├── Services/         # Lógica de negocio
│   ├── Data/             # Acceso a datos
│   └── Program.cs        # Punto de entrada
├── README.md
└── .gitignore
```

## 💾 Base de Datos

El proyecto utiliza un sistema de almacenamiento de datos. Asegúrate de configurar:
- Cadena de conexión (si usa SQL Server)
- Migraciones de base de datos
- Scripts de inicialización

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