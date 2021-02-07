namespace TelaExecuta
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGravar = new System.Windows.Forms.Button();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGravar
			// 
			this.btnGravar.Location = new System.Drawing.Point(22, 108);
			this.btnGravar.Name = "btnGravar";
			this.btnGravar.Size = new System.Drawing.Size(150, 50);
			this.btnGravar.TabIndex = 0;
			this.btnGravar.Text = "Gravar Arquivo...";
			this.btnGravar.UseVisualStyleBackColor = true;
			// 
			// btnDeletar
			// 
			this.btnDeletar.Location = new System.Drawing.Point(228, 108);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(150, 50);
			this.btnDeletar.TabIndex = 1;
			this.btnDeletar.Text = "Deletar Arquivo...";
			this.btnDeletar.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 264);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnGravar);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGravar;
		private System.Windows.Forms.Button btnDeletar;
	}
}

