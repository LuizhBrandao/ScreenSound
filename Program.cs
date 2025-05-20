// Primeiro programa em C#
// C#: criando sua primeira aplicação
using ScreenSound.Menus;
using ScreenSound.Modelos;
internal class Program
{
    private static void Main(string[] args)
    {
        Banda ira = new Banda("Ira!");
        ira.AdicionarNota(new Avaliacao(10));
        ira.AdicionarNota(new Avaliacao(8));
        ira.AdicionarNota(new Avaliacao(6));
        Banda beatles = new("The Beatles");

        Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(ira.Nome, ira);
        bandasRegistradas.Add(beatles.Nome, beatles);

        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuRegistrarAlbum());
        opcoes.Add(3, new MenuMostrarBandas());
        opcoes.Add(4, new MenuAvaliarBanda());
        opcoes.Add(5, new MenuExibirDetalhes());
        opcoes.Add(-1, new MenuSair());


        void ExibirLogo()
        {
            Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine("Boas Vindas ao Screen Sound !");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as banda");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;

            try
            {
                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

                if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
                {
                    Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
                    menuASerExibido.Executar(bandasRegistradas);
                    if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();

                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }       
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, digite um número válido.");
                Thread.Sleep(1000);
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }

        ExibirOpcoesDoMenu();


        //Orientação a Objetos
        //C#: aplicando a Orientação a Objetos

        Banda brunomars = new Banda("Bruno Mars");
        Album albumDoBrunoMars = new Album("24K Magic");

        Musica musicaBm1 = new Musica(brunomars, "Chunky")
        {
            Duracao = 306,
            Disponivel = true,
        };

        Musica musicaBm2 = new Musica(brunomars, "Perm")
        {
            Duracao = 330,
            Disponivel = false,
        };

        albumDoBrunoMars.AdicionarMusica(musicaBm1);
        albumDoBrunoMars.AdicionarMusica(musicaBm2);
        brunomars.AdicionarAlbum(albumDoBrunoMars);

        musicaBm1.ExibirFichaTecnica();
        musicaBm2.ExibirFichaTecnica();
        albumDoBrunoMars.ExibirMusicasDoAlbum();
        brunomars.ExibirDiscografia();

        Episodio ep1 = new(1, "Técnicas de facilitação", 45);
        ep1.AdicionarConvidados("Maria");
        ep1.AdicionarConvidados("Marcelo");

        Episodio ep2 = new(2, "Técnicas de aprendizado", 71);
        ep2.AdicionarConvidados("Luiz");
        ep2.AdicionarConvidados("Lucas");
        ep2.AdicionarConvidados("Ana");

        Podcast podcast = new("DigitalCast", "Sidney");
        podcast.AdicionarEpisodio(ep1);
        podcast.AdicionarEpisodio(ep2);
        podcast.ExibirDetalhes();
    }
}
