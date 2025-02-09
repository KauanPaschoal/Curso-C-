Episodio ep1 = new(45, 1, "Técnicas de facilitação");
ep1.AdicionarConvidados("Maria");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(67, 2, "Técnicas de Aprendizado");
ep2.AdicionarConvidados("Maria");
ep2.AdicionarConvidados("Otavio");
ep2.AdicionarConvidados("Marcos");



Podcasts podcasts = new("Podcast Especial", "Daniel");
podcasts.AdicionarEpisodio(ep1);
podcasts.AdicionarEpisodio(ep2);
podcasts.ExibirDetalhes();