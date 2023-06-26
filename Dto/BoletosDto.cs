public class BoletoDto
{
    public long BoletoId { get; set; }
    public long EventoId { get; set; }
    public double Precio { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
}

public class BoletoDetalleDto
{
    public long BoletoId { get; set; }
    public long EventoId { get; set; }
    public double Precio { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
}