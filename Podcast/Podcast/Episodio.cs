using System.Collections.Generic;

public class Episodio
{
    private List<string> ListaConvidadaos = new List<string>();
    private int duracao;
    private int numeroEpisodio;
    private string titulo;
    private string resumo;

    public Episodio(int duracao, int numeroEpisodio, string titulo)
    {
        this.duracao = duracao;
        this.numeroEpisodio = numeroEpisodio;
        this.titulo = titulo;
    }

    public int Duracao => duracao;
    public int NumeroEpisodio => numeroEpisodio;
    public string Titulo => titulo;
    public string Resumo => $"{NumeroEpisodio}. {Titulo} ({Duracao} min) - {string.Join(", ", ListaConvidadaos)}";

    public void AdicionarConvidados(string convidado)
    {
        ListaConvidadaos.Add(convidado);
    }
}