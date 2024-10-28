namespace PrincipioSOLID.Console.OCP;

public class NomeCompletoOCP : UsuarioOCP
{
    public string Apelido { get; set; }

    public NomeCompletoOCP(string nome, string sobrenome, string apelido)
        : base(nome, sobrenome)
        => Apelido = apelido;

    public string NomeCompletoApelido()
    {
        return $"Meu nome é: {Nome} e sobrenome: {Sobrenome} e o meu apelido: {Apelido}";
    }
}