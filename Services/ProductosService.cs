using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VRJewelers.Data;
using VRJewelers.Models;

namespace VRJewelers.Services;

public class ProductosService(IDbContextFactory<ApplicationDbContext> contextFactory)
{
	public async Task<bool> Guardar(Productos producto)
    {
        if (!await Existe(producto.ProductoId))
            return await Insertar(producto);
        else
            return await Modificar(producto);
    }

	private async Task<bool> Insertar(Productos producto)
    {
        using var context = contextFactory.CreateDbContext();
        context.Productos.Add(producto);
		return await context.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Productos producto)
    {
        using var context = contextFactory.CreateDbContext();
        context.Productos.Update(producto);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<Productos?> BuscarPorId(int productoId)
    {
        using var context = contextFactory.CreateDbContext();
        return await context
            .Productos
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.ProductoId == productoId);
    }

    public async Task<bool> EliminarPorId(int id)
    {
        using var context = contextFactory.CreateDbContext();
        var producto = await context
                            .Productos
                            .FindAsync(id);
        if (producto == null)
        {
            return false;
        }
        context.Productos.Remove(producto);
        return await context.SaveChangesAsync() > 0;
    }

	private async Task<bool> Existe(int id)
    {
        using var context = contextFactory.CreateDbContext();
        return await context.Productos
            .AnyAsync(p => p.ProductoId != id);
    }

    public async Task<bool> Validar(Productos producto)
    {
        using var context = contextFactory.CreateDbContext();
        return await context.Productos
            .AnyAsync(p => p.NombreProducto == producto.NombreProducto && p.ProductoId != producto.ProductoId);
    }

    public async Task<List<Productos>> Listar(Expression<Func<Productos, bool>> criterio)
    {
        using var context = contextFactory.CreateDbContext();
        return await context.Productos
            .AsNoTracking()
            .Where(criterio)
            .ToListAsync();
    }
}
