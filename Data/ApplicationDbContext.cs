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
            new Productos { NombreProducto = "Anillo de Oro 18K", Precio = 4750, ProductoId = 1, TipoProducto = "ANILLO", Descripcion = "Elegante anillo de oro 18 quilates con acabado pulido.", ImagenUrl = "/Imagen/Anillo18K.jpg" },
            new Productos { NombreProducto = "Collar de Plata", Precio = 3200, ProductoId = 2, TipoProducto = "COLLAR", Descripcion = "Collar de plata esterlina con diseño minimalista.", ImagenUrl = "/Imagen/Salvatoreplata.jpg" },
            new Productos { NombreProducto = "Pulsera de Diamantes", Precio = 12000, ProductoId = 3, TipoProducto = "PULSERA", Descripcion = "Pulsera de oro blanco con diamantes incrustados.", ImagenUrl = "/imagen/PulseDiamantes.jpg" },
            new Productos { NombreProducto = "Aretes de Perla", Precio = 2800, ProductoId = 4, TipoProducto = "ARETE", Descripcion = "Aretes con perlas naturales y cierre de oro.", ImagenUrl = "/Imagen/Aretesperla.jpg" },
            new Productos { NombreProducto = "Anillo de Compromiso", Precio = 9500, ProductoId = 5, TipoProducto = "ANILLO", Descripcion = "Anillo de oro blanco con diamante central talla brillante.", ImagenUrl = "/Imagen/anillocompromiso.jpg" },
            new Productos { NombreProducto = "Gargantilla de Zafiro", Precio = 8700, ProductoId = 6, TipoProducto = "COLLAR", Descripcion = "Gargantilla de oro rosa con piedra de zafiro azul.", ImagenUrl = "/Imagen/gargantilla_zafiro.jpg" },
            new Productos { NombreProducto = "Pendientes de Oro", Precio = 3500, ProductoId = 8, TipoProducto = "ARETE", Descripcion = "Pendientes de oro amarillo con diseño clásico.", ImagenUrl = "/Imagen/pendientesdeoro.jpg" },
            new Productos { NombreProducto = "Anillo con Rubí", Precio = 6800, ProductoId = 9, TipoProducto = "ANILLO", Descripcion = "Anillo de oro con rubí natural tallado.", ImagenUrl = "/Imagen/anilloruby.jpg" },
            new Productos { NombreProducto = "Collar de Diamantes", Precio = 15000, ProductoId = 10, TipoProducto = "COLLAR", Descripcion = "Collar de oro blanco con diamantes de alta calidad.", ImagenUrl = "/Imagen/collardiamantes.webp" },
            new Productos { NombreProducto = "Reloj Clásico de Acero", Precio = 5200, ProductoId = 11, TipoProducto = "RELOJ", Descripcion = "Reloj de acero inoxidable con correa metálica y esfera minimalista.", ImagenUrl = "/Imagen/relojacero.jpg" },
            new Productos { NombreProducto = "Reloj Automático de Lujo", Precio = 15800, ProductoId = 12, TipoProducto = "RELOJ", Descripcion = "Reloj automático con caja de oro y correa de cuero genuino.", ImagenUrl = "/Imagen/RelojAutomaticodelujo.webp" }
        );
    }
}
