namespace _2025_DI_Exemplo2;

public interface IProvedorMapa
{
    public string NomeProvedor { get; }

    string Mapa(string coordenadas);
    string Rota(string origem, string destino);
}
