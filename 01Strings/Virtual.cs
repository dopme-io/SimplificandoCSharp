using System.Text;

namespace _01Strings;

public class Virtual : Livro
{
    public virtual string PrimeiraInterpolacao()
    {
        return string.Format("{0} é o novo livro de {1}", Titulo, Autor);
    }
    
    public virtual string SegundaInterpolacao()
    {
        return $"{Titulo} é o novo livro de {Autor}";
    }

    public virtual string PrimeiraQuebraLinha()
    {
        return "Amigo leitor, \n\n\tobrigado por ter adquirido este livro. Esperamos que ele o ajude em sua jornada diária de trabalho.\n\nBom estudo!\ndopme.io";
    }

    public virtual string SegundaQuebraLinha()
    {
        return @"Amigo leitor, 
        Obrigado por ter adquirido este livro. Esperamos que ele o ajude em sua jornada diária de trabalho. 
        Bom estudo! 
        dopme.io";
    }

    public virtual string ConvertStringArrayBytes()
    {
        byte[] byt = System.Text.Encoding.Unicode.GetBytes(PrimeiraInterpolacao());
        return Convert.ToBase64String(byt);
    }

    public virtual string ConvertArrayBytesString()
    {
        string baseString = ConvertStringArrayBytes();
        byte[] byt = Convert.FromBase64String(baseString);
        return Encoding.Unicode.GetString(byt);
    }

    public virtual string ParticaoStringArrayString()
    {
        string[] lista = Recentes.Split(",");
        foreach (string livro in lista)
        {
            Console.WriteLine(livro);
        }
        
        return null;
    }
}