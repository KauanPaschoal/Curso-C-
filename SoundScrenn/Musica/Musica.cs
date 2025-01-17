class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");

        if (disponivel)
        {
            Console.WriteLine("Música disponível");
        } else
        {
            Console.WriteLine("Música indisponível, Adquira o Plano Plus");
        }
        Console.WriteLine("\n");
        
    }

}




