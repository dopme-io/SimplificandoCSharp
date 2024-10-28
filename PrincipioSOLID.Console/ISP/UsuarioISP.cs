namespace PrincipioSOLID.Console.ISP;

public class UsuarioISP : IUsuarioBase
{
    public string Nome { get; private set; }
    public string Sobrenome { get; private set; }

    public UsuarioISP(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string NomeCompletoISP()
    {
        return $"Nome: {Nome} e o Sobrenome: {Sobrenome}";
    }
}

