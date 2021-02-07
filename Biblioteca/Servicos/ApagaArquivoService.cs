using System.IO;
using static Biblioteca.Metodos.MeusMetodos;

namespace Biblioteca.Servicos
{
	public class ApagaArquivoService
	{
		public void Executa(object sender, MyEventArgs args)
		{
			string targetpath = @"C:\Users\Fabio\Desktop\file1.txt";

			try
			{
				File.Delete(targetpath);

			}
			catch (IOException e) when (!string.IsNullOrEmpty(e.Message))
			{
				//return "Erro: " + e.Message;
			}

			//return "Ok";
		}
	}
}
