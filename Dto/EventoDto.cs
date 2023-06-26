
using System;
public class EventoDto
{
    public int eventoId { get; set; }
    public string? nombreEvento { get; set; }
    public string? tipoEvento { get; set; }
    public string? lugarEvento { get; set; }
    public DateTime fecha { get; set; } = DateTime.Now;
    public string? cantidadBoletos { get; set; }
     public long capacidadTotal { get; set; }
      public List<Seccion> Secciones { get; set; }
}

public class SeccionDTo
{
    public long SeccionId { get; set; }
    public string Nombre { get; set; }
    public long Capacidad { get; set; }
    public List<Asiento> Asientos { get; set; }
}
public class EventoDetallDto 
{
    public long EventoId { get; set; }
    public string? NombreEvento { get; set; }
    public string? TipoEvento { get; set; }
    public string? LugarEvento { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string? CantidadBoletos { get; set; }
     public long CapacidadTotal { get; set; }
}