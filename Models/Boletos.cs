using System.ComponentModel.DataAnnotations;

public class Boletos{
    [Key]
    [Range(0, long.MaxValue, ErrorMessage = "El Id debe de estar en el rango{1} y {2}.")]
    public long BoletoId { get; set; }
    public long EventoId { get; set; }
    public double Precio { get; set; }
    public string? Area { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;

   // public List<BoletoDetalle> detalle { get; set; } = new List<BoletoDetalle>();

    public Boletos()
    {
        BoletoId=0;
        EventoId = 0;
        Precio= 0;
        Fecha = DateTime.Now;
    }
}