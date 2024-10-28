namespace  PrincipioSOLID.Console.DIP;

public class UsuarioServiceDIP
{
    private readonly IValidarUsuarioDIP _validarUsuarioDip;

    public UsuarioServiceDIP(IValidarUsuarioDIP validarUsuarioDip)
    {
        _validarUsuarioDip = validarUsuarioDip;
    }

    public void ObterNomeCompleto(string nome, string sobrenome)
    {
        if (_validarUsuarioDip.ValidarNomeCompleto(nome, sobrenome))
        {
            string nomeCompleto = $"Nome: {nome} e o Sobrenome: {sobrenome}";
            System.Console.WriteLine($"{nomeCompleto}");
        }
        else
        {
            System.Console.WriteLine($"Nome e Sobrenome inválidos.");
        }
    }
}