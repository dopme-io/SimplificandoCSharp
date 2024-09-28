namespace _01Strings;

public static class Run
{
    public static void Start()
    {
        Console.WriteLine("CAP: STRINGS");
        
        Console.WriteLine("--------------------------------");
        Console.WriteLine("CRIANDO STRINGS MAIS LEGÍVEIS");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("\n------------- Primeira Interpolação -----------------");
        Console.WriteLine(new Virtual().PrimeiraInterpolacao());
        Console.WriteLine("\n------------- Segunda Interpolação -----------------");
        Console.WriteLine(new Virtual().SegundaInterpolacao());
        Console.WriteLine("\n------------- Primeira Tabulaçoes e Quebra de Linhas -----------------");
        Console.WriteLine(new Virtual().PrimeiraQuebraLinha());
        Console.WriteLine("\n------------- Segunda Tabulaçoes e Quebra de Linhas -----------------");
        Console.WriteLine(new Virtual().SegundaQuebraLinha());
        
        Console.WriteLine("\n--------------------------------");
        Console.WriteLine("COVERTENDO STRINGS");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("\n------------- Convertendo uma String em uma Array de Bytes -----------------");
        Console.WriteLine(new Virtual().ConvertStringArrayBytes());
        Console.WriteLine("\n------------- Convertendo uma Array de Bytes em uma String -----------------");
        Console.WriteLine(new Virtual().ConvertArrayBytesString());
        Console.WriteLine("\n------------- Particionando uma string em um array de string -----------------");
        Console.WriteLine(new Virtual().ParticaoStringArrayString());
    }
}