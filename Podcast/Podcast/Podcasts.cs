public class Podcasts
{

    private List<Episodio> episodios = new List<Episodio>();
    private string Host { get; }
    private string Nome { get; }
    public int TotalEpisodios => episodios.Count;
    public Podcasts(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }




    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host} \n");

        foreach (Episodio episodio in episodios.OrderBy(e => e.NumeroEpisodio)) {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este podcast possui {TotalEpisodios} episodios");
    }
        

}