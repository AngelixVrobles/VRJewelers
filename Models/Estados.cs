using System.ComponentModel.DataAnnotations;

namespace VRJewelers.Models;

public class Estados
{
    [Key]
    public int EstadoId { get; set; }

    [Required(ErrorMessage = "El nombre del Estado es obligatorio")]
    public string? NombreEstado { get; set; }
}
