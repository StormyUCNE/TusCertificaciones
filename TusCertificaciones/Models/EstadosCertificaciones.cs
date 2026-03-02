using System.ComponentModel.DataAnnotations;
namespace TusCertificaciones.Models;
public class EstadosCertificaciones
{
    [Key]
    public int EstadoId { get; set; }
    public string Descripcion { get; set; } = string.Empty;
}