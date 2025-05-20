using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRgistradas)
    {
        Console.WriteLine("Obrigado por usar o Screen Sound!");
        Console.WriteLine("Até logo!");
    }
}
