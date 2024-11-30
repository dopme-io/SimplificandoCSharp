//// See https://aka.ms/new-console-template for more information

using PrincipioSOLID.Console.DIP;
using PrincipioSOLID.Console.ISP;
using PrincipioSOLID.Console.LSP;
using PrincipioSOLID.Console.OCP;
using PrincipioSOLID.Console.SRP;

Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("Conclusão | Simplificando a Complexidade com C-Sharp e os Príncipios SOLID!");
Console.WriteLine("-------------------------------------------------------------------------");

Console.WriteLine("\n-- SRP --");
UsuarioSRP usuario = new UsuarioSRP("Danilo O. ", "Pinheiro");

Console.WriteLine(usuario.NomeCompleto());

Console.WriteLine("\n-- OCP --");
UsuarioOCP usuarioOcp = new UsuarioOCP("Danilo", "O. Pinheiro");
NomeCompletoOCP nomeCompleto = new NomeCompletoOCP("Danilo", "O. Pinheiro", "dopme.io");

Console.WriteLine(usuarioOcp.NomeCompleto());
Console.WriteLine(nomeCompleto.NomeCompletoApelido());

Console.WriteLine("\n-- LSP --");

static void ObterNomeCompletoLSP(UsuarioLSP usuarioLsp, NomeCompletoLSP nomeCompletoLsp)
{
    Console.WriteLine(usuarioLsp.NomeCompletoLSP());
    Console.WriteLine(nomeCompletoLsp.NomeCompletoApelido());
}

UsuarioLSP usuarioLsp = new UsuarioLSP("Daniloe", "O. Pinheiro");
NomeCompletoLSP nomeCompletoLsp = new NomeCompletoLSP("Daniloe", "O. Pinheiro", "dopme.io");

ObterNomeCompletoLSP(usuarioLsp, nomeCompletoLsp);

Console.WriteLine("\n-- ISP --");
static void ObterNomeCompletoISP(UsuarioISP usuarioIsp, NomeCompletoISP nomeCompletoIsp)
{
    Console.WriteLine(usuarioIsp.NomeCompletoISP());
    Console.WriteLine(nomeCompletoIsp.NomeCompletoApelido());
}

UsuarioISP usuarioIsp = new UsuarioISP("Daniloe", "O. Pinheiro");
NomeCompletoISP nomeCompletoIsp = new NomeCompletoISP("Daniloe", "O. Pinheiro", "dopme.io");

ObterNomeCompletoISP(usuarioIsp, nomeCompletoIsp);

Console.WriteLine("\n-- DIP --");

IValidarUsuarioDIP validarUsuarioDip = new UsuarioDIP();
UsuarioServiceDIP usuarioServiceDip = new UsuarioServiceDIP(validarUsuarioDip);
usuarioServiceDip.ObterNomeCompleto("Daniloe", "O. Pinheiro");
