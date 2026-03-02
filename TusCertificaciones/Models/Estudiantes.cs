using System.ComponentModel.DataAnnotations;
namespace TusCertificaciones.Models;
public class Estudiantes
{
    [Key]
    public string RNE { get; set; } = string.Empty;

    public string PrimerNombre { get; set; } = string.Empty;

    public string SegundoNombre { get; set; } = string.Empty;

    public string PrimerApellido { get; set; } = string.Empty;

    public string SegundoApellido{ get; set; } = string.Empty;

    public int Edad { get; set; }

    public DateOnly FechaNacimiento { get; set; }

    public string Direccion { get; set; } = string.Empty;

    public string Telefono { get; set; } = string.Empty;

    public string Cedula { get; set; } = string.Empty;

    public string GradoAcademico { get; set; } = string.Empty;

    public string AnoAcademico { get; set; } = string.Empty;

    public string TandaSeccion { get; set; } = string.Empty;
}