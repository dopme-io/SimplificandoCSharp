namespace PrincipioSOLID.Console.OCP;

public class UsuarioOCP
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    public UsuarioOCP(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public virtual string NomeCompleto()
    {
        return $"Nome: {Nome} e o Sobrenome: {Sobrenome}";
    }
}

