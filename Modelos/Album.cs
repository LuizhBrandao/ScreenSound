﻿namespace ScreenSound.Modelos;
internal class Album : IAvaliavel
{
    public static int ContadorDeObjetos = 0;

    public Album()
    {
        ContadorDeObjetos++;
    }

    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao); 
    
    public List<Musica> Musicas => musicas;

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(n => n.Nota);
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:");
        foreach (var musica in musicas)
        {
        Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este álbum inteiro você precisa de {DuracaoTotal} \n");
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}