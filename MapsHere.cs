namespace _2025_DI_Exemplo2;

public class MapsHere : IProvedorMapa
{
    public string NomeProvedor { get; } = "Maps Here";

    public string Mapa(string coordenadas)
    {
        return $"Este é um mapa do Maps Here para " +
               $"as coordenadas {coordenadas}";
    }

    public string Rota(string origem, string destino)
    {
        return $"Esta é a rota entre {origem} e {destino} " +
               $"usando Maps Here";
    }
}
