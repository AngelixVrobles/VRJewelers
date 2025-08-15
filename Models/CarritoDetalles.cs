using VrJewelers.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VRJewelers.Models;

public class CarritoDetalles
{
	[Key]
	public int CarritoDetalleId { get; set; }

	public int CarritoId { get; set; }
	public Carrito? Carrito { get; set; }

	public int ProductoId { get; set; }
	public Productos? Producto { get; set; }

	public int Cantidad { get; set; }

	public float Precio { get; set; }

	[NotMapped]
	public float Total => Cantidad * Precio;
}