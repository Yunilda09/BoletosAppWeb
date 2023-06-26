using System.ComponentModel.DataAnnotations;


public class Eventos
{
    [Key]
    [Range(0, long.MaxValue, ErrorMessage = "El Id debe de estar en el rango{1} y {2}.")]
    public long eventoId { get; set; }
    public string? nombreEvento { get; set; }
    public string? tipoEvento { get; set; }
    public string? lugarEvento { get; set; }
    public DateTime fecha { get; set; } = DateTime.Now;
    public string? cantidadBoletos { get; set; }
     public long capacidadTotal { get; set; }

     public List<Seccion> Secciones { get; set; }
}
public class Seccion
{
    public long seccionId { get; set; }
    public string nombre { get; set; }
    public long capacidad { get; set; }
    public List<Asiento> Asientos { get; set; }
}
public class Asiento
{
    public long asientoId { get; set; }
    public string? numero { get; set; }
    public bool disponible { get; set; }
}
