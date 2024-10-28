namespace PrincipioSOLID.Console.ISP;

public class NomeCompletoISP : UsuarioISP, INomeCompletoISP
{
    public string Apelido { get; private set; }

    public NomeCompletoISP(string nome, string sobrenome, string apelido)
        : base(nome, sobrenome)
        => Apelido = apelido;

    public string NomeCompletoApelido()
    {
        return $"Meu nome é: {Nome} e sobrenome: {Sobrenome} e o meu apelido: {Apelido}";
    }
}