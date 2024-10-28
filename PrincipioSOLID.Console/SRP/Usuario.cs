namespace PrincipioSOLID.Console.SRP;

public class UsuarioSRP
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    public UsuarioSRP(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string NomeCompleto()
    {
        return $"{Nome} {Sobrenome}";
    }
}