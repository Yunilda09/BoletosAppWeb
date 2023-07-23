using System.ComponentModel.DataAnnotations;

public class Evento
{
    public long eventoId { get; set; }
    public string? descripcion { get; set; }
    public DateTime fecha { get; set; } 
    public string? nombreEvento { get; set; }
    public string? ubicacion { get; set; }
    public List<Seccion> secciones { get; set; }
}

public class Seccion
{
    public string? nombre { get; set; }
    public long capacidad { get; set; }
    public List<string> asientos { get; set; }
}


