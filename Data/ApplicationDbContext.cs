using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VrJewelers.Models;
using VRJewelers.Models;

namespace VRJewelers.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Productos> Productos { get; set; }
    public DbSet<Admins> Admins { get; set; }
    public DbSet<Clientes> Clientes { get; set; }
    public DbSet<Carrito> Carritos { get; set; }
    public DbSet<CarritoDetalles> CarritoDetalles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ConfigureProductosModel(modelBuilder);
    }

    public void ConfigureProductosModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Productos>().HasData(
            new Productos { NombreProducto = "Anillo de Oro 18K", Precio = 4750, ITBIS = 855.0f, ProductoId = 1, TipoProducto = "ANILLO", Disponible = true, Descripcion = "Elegante anillo de oro 18 quilates con acabado pulido.", ImagenUrl = "/Imagen/Anillo18K.jpg" },
            new Productos { NombreProducto = "Collar de Plata", Precio = 3200, ITBIS = 576.0f, ProductoId = 2, TipoProducto = "COLLAR", Disponible = true, Descripcion = "Collar de plata esterlina con diseño minimalista.", ImagenUrl = "/Imagen/Salvatoreplata.jpg" },
            new Productos { NombreProducto = "Pulsera de Diamantes", Precio = 12000, ITBIS = 2160.0f, ProductoId = 3, TipoProducto = "PULSERA", Disponible = true, Descripcion = "Pulsera de oro blanco con diamantes incrustados.", ImagenUrl = "/imagen/PulseDiamantes.jpg" },
            new Productos { NombreProducto = "Aretes de Perla", Precio = 2800, ITBIS = 504.0f, ProductoId = 4, TipoProducto = "ARETE", Disponible = true, Descripcion = "Aretes con perlas naturales y cierre de oro.", ImagenUrl = "/Imagen/Aretesperla.jpg" },
            new Productos { NombreProducto = "Anillo de Compromiso", Precio = 9500, ITBIS = 1710.0f, ProductoId = 5, TipoProducto = "ANILLO", Disponible = true, Descripcion = "Anillo de oro blanco con diamante central talla brillante.", ImagenUrl = "/Imagen/anillocompromiso.jpg" },
            new Productos { NombreProducto = "Gargantilla de Zafiro", Precio = 8700, ITBIS = 1566.0f, ProductoId = 6, TipoProducto = "COLLAR", Disponible = true, Descripcion = "Gargantilla de oro rosa con piedra de zafiro azul.", ImagenUrl = "/Imagen/gargantilla_zafiro.jpg" },
            new Productos { NombreProducto = "Pendientes de Oro", Precio = 3500, ITBIS = 630.0f, ProductoId = 8, TipoProducto = "ARETE", Disponible = true, Descripcion = "Pendientes de oro amarillo con diseño clásico.", ImagenUrl = "/Imagen/pendientesdeoro.jpg" },
            new Productos { NombreProducto = "Anillo con Rubí", Precio = 6800, ITBIS = 1224.0f, ProductoId = 9, TipoProducto = "ANILLO", Disponible = true, Descripcion = "Anillo de oro con rubí natural tallado.", ImagenUrl = "/Imagen/anilloruby.jpg" },
            new Productos { NombreProducto = "Collar de Diamantes", Precio = 15000, ITBIS = 2700.0f, ProductoId = 10, TipoProducto = "COLLAR", Disponible = true, Descripcion = "Collar de oro blanco con diamantes de alta calidad.", ImagenUrl = "/Imagen/collardiamantes.webp" },
            new Productos { NombreProducto = "Reloj Clásico de Acero", Precio = 5200, ITBIS = 936.0f, ProductoId = 11, TipoProducto = "RELOJ", Disponible = true, Descripcion = "Reloj de acero inoxidable con correa metálica y esfera minimalista.", ImagenUrl = "/Imagen/relojacero.jpg" },
            new Productos { NombreProducto = "Reloj Automático de Lujo", Precio = 15800, ITBIS = 2844.0f, ProductoId = 12, TipoProducto = "RELOJ", Disponible = true, Descripcion = "Reloj automático con caja de oro y correa de cuero genuino.", ImagenUrl = "/Imagen/RelojAutomaticodelujo.webp" }

        );
    }
}
