/*
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class EventoService
{
    private readonly HttpClient httpClient;
    private const string apiUrl = "https://api/eventos"; // Reemplaza con la URL de tu API

    public EventoService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<List<Eventos>> ObtenerEventos()
    {
        return await httpClient.GetFromJsonAsync<List<Eventos>>(apiUrl);
    }

    public async Task<bool> ReservarAsiento(int eventoId, string seccion, string asiento, string cliente)
    {
        var boleto = new Boletos
        {
            Asiento = asiento,
            CantidadBoletos = 1, // Cambia el valor según tu lógica de cantidad de boletos
            Precio = 0.0m // Cambia el valor según tu lógica de precio
        };

        var response = await httpClient.PostAsJsonAsync($"{apiUrl}/{eventoId}/{seccion}/{asiento}/reservar", boleto);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> AsientoDisponible(int eventoId, string seccion, string asiento)
    {
        var response = await httpClient.GetAsync($"{apiUrl}/{eventoId}/{seccion}/{asiento}/disponible");
        return response.IsSuccessStatusCode;
    }
}
*/