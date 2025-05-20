using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeBanda);
        bandasRegistradas.Add(nomeBanda, banda);
        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
