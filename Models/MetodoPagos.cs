using System.ComponentModel.DataAnnotations;

namespace VRJewelers.Models;

public class MetodoPagos
{
    [Key]
    public int MetodoPagoId { get; set; }

    [Required(ErrorMessage = "El Nombre es obligatorio")]
    [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El Nombre debe contener solo letras.")]
    public string? Nombre { get; set; }
}
