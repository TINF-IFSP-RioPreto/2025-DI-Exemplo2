namespace _2025_DI_Exemplo2;

public class GoogleMaps : IProvedorMapa
{
    public string NomeProvedor { get; } = "Google Maps";

    public string Mapa(string coordenadas)
    {
        return $"Este é um mapa do Google Maps para " +
               $"as coordenadas {coordenadas}";
    }

    public string Rota(string origem, string destino)
    {
        return $"Esta é a rota entre {origem} e {destino} " +
               $"usando Google Maps";
    }
}
