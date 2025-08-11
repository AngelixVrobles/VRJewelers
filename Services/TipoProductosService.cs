using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System;
using VRJewelers.Data;
using VRJewelers.Models;
namespace VRJewelers.Services;

public class TipoProductosService(IDbContextFactory<ApplicationDbContext> contextFactory) : TipoProducto
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory = contextFactory;

    public async Task<List<TipoProducto>> GetAllObject()
    {
        using var context = _contextFactory.CreateDbContext();
        return await context.CategoriaProductos.ToListAsync();
    }

    public async Task<TipoProducto> GetObject(int id)
    {
        using var context = _contextFactory.CreateDbContext();
        return (await context.CategoriaProductos.FindAsync(id))!;
    }

    public async Task<TipoProducto> AddObject(TipoProducto type)
    {
        using var context = _contextFactory.CreateDbContext();
        context.CategoriaProductos.Add(type);
        await context.SaveChangesAsync();
        return type;
    }

    public async Task<bool> UpdateObject(TipoProducto type)
    {
        using var context = _contextFactory.CreateDbContext();
        context.Entry(type).State = EntityState.Modified;
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteObject(int id)
    {
        using var context = _contextFactory.CreateDbContext();
        var categoria = await context.CategoriaProductos.FindAsync(id);
        if (categoria == null)
            return false;
        context.CategoriaProductos.Remove(categoria);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Exist(int id, string? nombre)
    {
        using var context = _contextFactory.CreateDbContext();
        return await context.CategoriaProductos
            .AnyAsync(p => p.TipoId != id && p.Nombre.ToLower().Equals(nombre.ToLower()));
    }

    public async Task<List<TipoProducto>> GetObjectByCondition(Expression<Func<TipoProducto, bool>> expression)
    {
        using var context = _contextFactory.CreateDbContext();
        return await context.CategoriaProductos
            .AsNoTracking()
            .Where(expression)
            .ToListAsync();
    }
}