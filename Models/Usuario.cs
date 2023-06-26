using System.ComponentModel.DataAnnotations;


public class Usuario
{
	[Key]
	public int UsuarioId { get; set; }
	public string? Nombre { get; set; }
	public string? Correo { get; set; }
	public string? Password { get; set;}
}
