using System.ComponentModel.DataAnnotations;

namespace VRJewelers.Models;

public class TipoProducto
{
    [Key]
    public int TipoId { get; set; }

    [Required(ErrorMessage = "No puede estar Vacio")]
    [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El Nombre debe contener solo letras.")]
    public string? Nombre { get; set; }
}
