using System.ComponentModel.DataAnnotations;

public class Silla
{
    public long asientoId { get; set; }
    public long eventoId { get; set; }
    public string? seccion { get; set; }
    public long numero { get; set; }
    public bool reservado { get; set; }
}