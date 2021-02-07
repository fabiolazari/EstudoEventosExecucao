using System.IO;
using System.Text;
using static Biblioteca.Metodos.MeusMetodos;

namespace Biblioteca.Servicos
{
	public class GravaArquivoService
	{

		public void Executa(object sender, MyEventArgs args)
		{

			StringBuilder sb = new StringBuilder("Teste de gravação de arquivo");
			sb.AppendLine("Outro teste de gravação");

			string targetpath = @"C:\Users\Fabio\Desktop\file1.txt";

			try
			{
				using (StreamWriter sw = new StreamWriter(targetpath))
				{
					sw.Write(sb);
				}

			}
			catch (IOException e) when (!string.IsNullOrEmpty(e.Message))
			{
			//	return "Erro: " + e.Message;
			}

			//return "Ok";
		}
	}
}
