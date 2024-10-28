namespace PrincipioSOLID.Console.LSP;

public class UsuarioLSP
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    public UsuarioLSP(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

//    There is no suitable method for override
    public string NomeCompletoLSP()
    {
        return $"Nome: {Nome} e sobrenome: {Sobrenome}";
    }
}