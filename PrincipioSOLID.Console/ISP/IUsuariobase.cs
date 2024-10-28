public interface IUsuarioBase
{
    string Nome { get; }
    string Sobrenome {get;}
    string NomeCompletoISP();
}