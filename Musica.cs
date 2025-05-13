class Musica
{
    public string Nome {  get; set; }  
    public string Artista {  get; set; }   
    public int Duracao {  get; set; }  
    public bool Disponivel {  get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da musica: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano Sound+\n");
        }
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }

}