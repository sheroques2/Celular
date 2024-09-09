
public abstract class Celular
{
    // Propriedades comuns a todos os celulares
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string SistemaOperacional { get; set; }

    // Método abstrato que deve ser implementado pelas classes derivadas
    public abstract void FazerChamada(string numero);

    // Método comum que pode ser compartilhado entre todas as classes derivadas
    public void MostrarInfo()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Sistema Operacional: {SistemaOperacional}");
    }
}
public class CelularSamsung : Celular
{
    public CelularSamsung(string modelo)
    {
        Marca = "Samsung";
        Modelo = modelo;
        SistemaOperacional = "Android";
    }

    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"Ligando para {numero} usando um celular Samsung.");
    }
}

public class CelularApple : Celular
{
    public CelularApple(string modelo)
    {
        Marca = "Apple";
        Modelo = modelo;
        SistemaOperacional = "iOS";
    }

    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"Ligando para {numero} usando um celular Apple.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Celular meuSamsung = new CelularSamsung("Galaxy S21");
        Celular meuApple = new CelularApple("iPhone 13");

        meuSamsung.MostrarInfo();
        meuSamsung.FazerChamada("123-456-7890");

        meuApple.MostrarInfo();
        meuApple.FazerChamada("098-765-4321");
    }
}

