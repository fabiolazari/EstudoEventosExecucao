using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Metodos;
using Biblioteca.Servicos;

namespace TelaExecuta
{

	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
			
			btnGravar.Click += EventoClickGravar;
			btnDeletar.Click += EventoClickDeletar;
		}


		public void EventoClickGravar(object sender, EventArgs e)
		{
			MeusMetodos meusMetodos = new MeusMetodos();
			meusMetodos.Envia += new GravaArquivoService().Executa;
			meusMetodos.ExecutaMetodo("Gravado com sucesso!");
		}

		public void EventoClickDeletar(object sender, EventArgs e)
		{
			MeusMetodos meusMetodos = new MeusMetodos();
			meusMetodos.Envia += new ApagaArquivoService().Executa;
			meusMetodos.ExecutaMetodo("Apagado com sucesso!");
		}
	}
}
