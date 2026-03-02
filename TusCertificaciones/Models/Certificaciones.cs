using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TusCertificaciones.Models;

public class Certificaciones
{
    [Key]
    public int CertificacionId { get; set; }

    public string RNE { get; set; } = string.Empty;

    public int NumDistritoEducativo { get; set; }

    public int NumRegional { get; set; }

    public string LugarExpedicion { get; set; } = string.Empty;

    public DateTime FechaCertificacion { get; set; } = DateTime.Now;

    public string NombreCentroEducativo { get; set; } = string.Empty;

    public string NombreDirectorCentroEducativo { get; set; } = string.Empty;

    public string NombreDirectorDistrito { get; set; } = string.Empty;

    public string UbicacionRegional { get; set; } = string.Empty;

    public string UbicacionDistrito { get; set; } = string.Empty;

    public int EstadoId { get; set; }

    [ForeignKey("RNE")]
    public Estudiantes? Estudiantes { get; set; }

    [ForeignKey("EstadoId")]
    public EstadosCertificaciones? EstadosCertificaciones { get; set; }

}
