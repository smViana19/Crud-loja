namespace Crud_Loja
{
	partial class CadastroCliente
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtCep = new System.Windows.Forms.TextBox();
			this.txtLogradouro = new System.Windows.Forms.TextBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.dgvLoja = new System.Windows.Forms.DataGridView();
			this.lblID = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvLoja)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "Cep:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "Logradouro:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(25, 190);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 22);
			this.label5.TabIndex = 4;
			this.label5.Text = "Numero:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(25, 228);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 22);
			this.label6.TabIndex = 5;
			this.label6.Text = "Bairro:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(25, 272);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 22);
			this.label7.TabIndex = 6;
			this.label7.Text = "Cidade:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(22, 315);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 22);
			this.label8.TabIndex = 7;
			this.label8.Text = "Estado: ";
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(157, 68);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(230, 27);
			this.txtNome.TabIndex = 8;
			// 
			// txtCep
			// 
			this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCep.Location = new System.Drawing.Point(157, 111);
			this.txtCep.MaxLength = 8;
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(230, 27);
			this.txtCep.TabIndex = 9;
			// 
			// txtLogradouro
			// 
			this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLogradouro.Location = new System.Drawing.Point(157, 149);
			this.txtLogradouro.Name = "txtLogradouro";
			this.txtLogradouro.Size = new System.Drawing.Size(230, 27);
			this.txtLogradouro.TabIndex = 10;
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(157, 192);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(230, 27);
			this.txtNumero.TabIndex = 11;
			this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged_1);
			this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
			// 
			// txtBairro
			// 
			this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(157, 230);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(230, 27);
			this.txtBairro.TabIndex = 12;
			// 
			// txtCidade
			// 
			this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(157, 274);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(230, 27);
			this.txtCidade.TabIndex = 13;
			// 
			// txtEstado
			// 
			this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEstado.Location = new System.Drawing.Point(157, 317);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(230, 27);
			this.txtEstado.TabIndex = 14;
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
			this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.ForeColor = System.Drawing.Color.Black;
			this.btnSalvar.Location = new System.Drawing.Point(10, 690);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(92, 58);
			this.btnSalvar.TabIndex = 15;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisar.Location = new System.Drawing.Point(301, 690);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(90, 58);
			this.btnPesquisar.TabIndex = 16;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = false;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAtualizar.Location = new System.Drawing.Point(204, 690);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(91, 58);
			this.btnAtualizar.TabIndex = 17;
			this.btnAtualizar.Text = "Editar";
			this.btnAtualizar.UseVisualStyleBackColor = false;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// btnDeletar
			// 
			this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeletar.Location = new System.Drawing.Point(108, 690);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(90, 58);
			this.btnDeletar.TabIndex = 18;
			this.btnDeletar.Text = "Deletar";
			this.btnDeletar.UseVisualStyleBackColor = false;
			this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
			// 
			// dgvLoja
			// 
			this.dgvLoja.AllowUserToAddRows = false;
			this.dgvLoja.AllowUserToDeleteRows = false;
			this.dgvLoja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLoja.Location = new System.Drawing.Point(416, 51);
			this.dgvLoja.MultiSelect = false;
			this.dgvLoja.Name = "dgvLoja";
			this.dgvLoja.ReadOnly = true;
			this.dgvLoja.Size = new System.Drawing.Size(837, 342);
			this.dgvLoja.TabIndex = 19;
			this.dgvLoja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoja_CellClick);
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(62, 27);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(0, 13);
			this.lblID.TabIndex = 20;
			// 
			// CadastroCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(1285, 863);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.dgvLoja);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnAtualizar);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.txtLogradouro);
			this.Controls.Add(this.txtCep);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CadastroCliente";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvLoja)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtCep;
		private System.Windows.Forms.TextBox txtLogradouro;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Button btnAtualizar;
		private System.Windows.Forms.Button btnDeletar;
		private System.Windows.Forms.DataGridView dgvLoja;
		private System.Windows.Forms.Label lblID;
	}
}

