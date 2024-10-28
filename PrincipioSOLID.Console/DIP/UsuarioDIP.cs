namespace PrincipioSOLID.Console.DIP;

public class UsuarioDIP : IValidarUsuarioDIP
{
    public bool ValidarNomeCompleto(string nome, string sobrenome)
    {
        if (!string.IsNullOrEmpty(nome) || !string.IsNullOrWhiteSpace(sobrenome))
        {
            return nome.Length >= 3 && sobrenome.Length >= 5;
        }
        return false;
    }
}