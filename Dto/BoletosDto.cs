using System.ComponentModel.DataAnnotations;
using System;
public class BoletoDto
{
    public long boletoId { get; set; }
    public string? asiento { get; set; }
    public double cantidadBoletos { get; set; }
    public double precio { get; set; }
     public EventoDto? eventos { get; set; }
}
