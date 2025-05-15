namespace ScreenSound.Modelos;
internal class Musica
{

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
        
    }

    public string Nome {  get; }  
    public Banda Artista {  get; }   
    public int Duracao {  get; set; }  
    public bool Disponivel {  get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";  
    
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da musica: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
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