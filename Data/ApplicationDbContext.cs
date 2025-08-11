using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VRJewelers.Models;

namespace VRJewelers.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<TipoProducto> CategoriaProductos { get; set; }
    public DbSet<Productos> Productos { get; set; }
    public DbSet<Ordenes> Ordenes { get; set; }
    public DbSet<OrdenesDetalle> OrdenesDetalle { get; set; }
    public DbSet<Ventas> Ventas { get; set; }
    public DbSet<VentasDetalle> VentasDetalle { get; set; }
    public DbSet<Estados> Estados { get; set; }
    public DbSet<MetodoPagos> MetodoPagos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ConfigureGeneralModel(modelBuilder);
        ConfigureProductosModel(modelBuilder);

        // Configurar las relaciones
        modelBuilder.Entity<Ordenes>()
            .HasMany(o => o.OrdenesDetalle)
            .WithOne(d => d.Orden)
            .HasForeignKey(d => d.OrdenId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<OrdenesDetalle>()
            .HasOne(d => d.Producto)
            .WithMany()
            .HasForeignKey(d => d.ProductoId);
    }

    public void ConfigureGeneralModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estados>().HasData(
             new Estados { EstadoId = 1, NombreEstado = "Procesando" },
             new Estados { EstadoId = 2, NombreEstado = "Empacado" },
             new Estados { EstadoId = 3, NombreEstado = "Enviado" },
             new Estados { EstadoId = 4, NombreEstado = "Entregado" }, 
             new Estados { EstadoId = 5, NombreEstado = "Cancelado" }
        );
        modelBuilder.Entity<MetodoPagos>().HasData(
             new MetodoPagos { MetodoPagoId = 1, Nombre = "Efectivo" },
             new MetodoPagos { MetodoPagoId = 2, Nombre = "Tarjeta" }
        );
        modelBuilder.Entity<TipoProducto>().HasData(
             new TipoProducto { TipoId = 1, Nombre = "Joyeria" },
             new TipoProducto { TipoId = 2, Nombre = "Reloj" }

        );
    }

    public void ConfigureProductosModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Productos>().HasData(
            // Joyería
            new Productos { Nombre = "Anillo de Oro 18K", Cantidad = 50, Precio = 4750, ITBIS = 855.0f, ProductoId = 1, TipoId = 1, Disponible = true, Descripcion = "Elegante anillo de oro 18 quilates con acabado pulido.", ImagenUrl = "/Imagen/Anillo18K.jpg" },
            new Productos { Nombre = "Collar de Plata", Cantidad = 50, Precio = 3200, ITBIS = 576.0f, ProductoId = 2, TipoId = 1, Disponible = true, Descripcion = "Collar de plata esterlina con diseño minimalista.", ImagenUrl = "/Imagen/Salvatoreplata.jpg" },
            new Productos { Nombre = "Pulsera de Diamantes", Cantidad = 50, Precio = 12000, ITBIS = 2160.0f, ProductoId = 3, TipoId = 1, Disponible = true, Descripcion = "Pulsera de oro blanco con diamantes incrustados.", ImagenUrl = "/imagen/PulseDiamantes.jpg" },
            new Productos { Nombre = "Aretes de Perla", Cantidad = 50, Precio = 2800, ITBIS = 504.0f, ProductoId = 4, TipoId = 1, Disponible = true, Descripcion = "Aretes con perlas naturales y cierre de oro.", ImagenUrl = "/Imagen/Aretesperla.jpg" },
            new Productos { Nombre = "Anillo de Compromiso", Cantidad = 50, Precio = 9500, ITBIS = 1710.0f, ProductoId = 5, TipoId = 1, Disponible = true, Descripcion = "Anillo de oro blanco con diamante central talla brillante.", ImagenUrl = "/Imagen/anillocompromiso.jpg" },
            new Productos { Nombre = "Gargantilla de Zafiro", Cantidad = 50, Precio = 8700, ITBIS = 1566.0f, ProductoId = 6, TipoId = 1, Disponible = true, Descripcion = "Gargantilla de oro rosa con piedra de zafiro azul.", ImagenUrl = "/Imagen/gargantilla_zafiro.jpg" },
            new Productos { Nombre = "Pendientes de Oro", Cantidad = 50, Precio = 3500, ITBIS = 630.0f, ProductoId = 8, TipoId = 1, Disponible = true, Descripcion = "Pendientes de oro amarillo con diseño clásico.", ImagenUrl = "/Imagen/pendientesdeoro.jpg" },
            new Productos { Nombre = "Anillo con Rubí", Cantidad = 50, Precio = 6800, ITBIS = 1224.0f, ProductoId = 9, TipoId = 1, Disponible = true, Descripcion = "Anillo de oro con rubí natural tallado.", ImagenUrl = "/Imagen/anilloruby.jpg" },
            new Productos { Nombre = "Collar de Diamantes", Cantidad = 50, Precio = 15000, ITBIS = 2700.0f, ProductoId = 10, TipoId = 1, Disponible = true, Descripcion = "Collar de oro blanco con diamantes de alta calidad.", ImagenUrl = "/Imagen/collardiamantes.webp" },

            // Relojes
            new Productos { Nombre = "Reloj Clásico de Acero", Cantidad = 50, Precio = 5200, ITBIS = 936.0f, ProductoId = 14, TipoId = 2, Disponible = true, Descripcion = "Reloj de acero inoxidable con correa metálica y esfera minimalista.", ImagenUrl = "/Imagen/relojacero.jpg" },
            new Productos { Nombre = "Reloj Automático de Lujo", Cantidad = 50, Precio = 15800, ITBIS = 2844.0f, ProductoId = 15, TipoId = 2, Disponible = true, Descripcion = "Reloj automático con caja de oro y correa de cuero genuino.", ImagenUrl = "/Imagen/RelojAutomaticodelujo.webp" }

        );
    }
}
