using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Servicos;

namespace Biblioteca.Metodos
{
	public class MeusMetodos
	{
		public event EventHandler<MyEventArgs> Envia;
		
		public void ExecutaMetodo(string _mensagem)
		{
			Envia(null, new MyEventArgs() { Mensagem = _mensagem });
		}

		public class MyEventArgs : EventArgs
		{
			public string Mensagem { get; set; }
		}

	}
}
