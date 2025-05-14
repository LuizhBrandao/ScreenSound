namespace ScreenSound.Modelos;
class Banda
{
    private List<Album> albums = new List<Album>();
    private List<int> notas = new List<int>();

    public Banda(string nome)
    {
        Nome = nome;    
    }
    public string Nome { get; }
    public double Media => notas.Average();
    public List<Album> Albums => albums;
    public void AdiciinarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AdicionarNota(int nota) 
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})\n");
        }
    }
}