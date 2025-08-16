using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VRJewelers.Models;

public class Productos
{
    [Key]
    public int ProductoId { get; set; }

    public string TipoProducto { get; set; }

    [Required(ErrorMessage = "Se Requiere un nombre")]
    [RegularExpression("^[a-zA-Z0-9 ]+$", ErrorMessage = "El nombre debe Contener Solo Letras y Números.")]
    public string? NombreProducto { get; set; } = string.Empty;

    [Required(ErrorMessage = "Se Requiere de una Descripción")]
    [RegularExpression("^[a-zA-Z0-9 ,]+$", ErrorMessage = "La Descripción debe contener solo Letras y Números")]
    public string? Descripcion { get; set; } = string.Empty;

    [Required(ErrorMessage = "Indique el precio")]
    [Range(0.01, 1000000000, ErrorMessage = "El Precio debe estar 0.01 y 1000000000")]
    public float Precio { get; set; }
    public string? ImagenUrl { get; set; } = null;
}
