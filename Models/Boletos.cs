using System.ComponentModel.DataAnnotations;

/*
public class Boletos{
    [Key]
    [Range(0, long.MaxValue, ErrorMessage = "El Id debe de estar en el rango{1} y {2}.")]
    public long boletoId { get; set; }
    public string? asiento { get; set; }
    public long cantidadBoletos { get; set; }
    public double precio { get; set; }
     public List<Evento> eventos { get; set; }
}*/

public class Boletos
{
    [Key]
    [Range(0, long.MaxValue, ErrorMessage = "El Id debe de estar en el rango {1} y {2}.")]
   // [JsonProperty("boletoId")] // Establecer el nombre correcto de la propiedad en la deserialización
    public long boletoId { get; set; }

    public string? asiento { get; set; }

   // [JsonProperty("cantidadBoletos")] // Establecer el nombre correcto de la propiedad en la deserialización
    public long cantidadBoletos { get; set; }

    public double precio { get; set; }

}
