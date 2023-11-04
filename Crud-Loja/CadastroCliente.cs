using K4os.Compression.LZ4.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Crud_Loja
{
	public partial class CadastroCliente : Form
	{
		public CadastroCliente()
		{
			InitializeComponent();
		}

		int IndexRow;

		private void label4_Click(object sender, EventArgs e)
		{

		}
		ConexaoCliente bd = new ConexaoCliente();
		string tabela = "Clientes";

		public void ExibirDados()
		{
			string selecionar = $"SELECT * FROM {tabela}";
			DataTable dt = bd.ExecutarConsulta(selecionar);
			dgvLoja.DataSource = dt.AsDataView();

		}



		private void btnAtualizar_Click(object sender, EventArgs e)
		{
			string atualizar;
			if (txtNome.Text != "" && txtCep.Text != "" && txtLogradouro.Text != "" && txtNumero.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && txtEstado.Text != "")
			{
				atualizar = $"UPDATE {tabela} SET nome = '{txtNome.Text}', cep = '{txtCep.Text}', logradouro = '{txtLogradouro.Text}', numero = '{txtNumero.Text}', bairro = '{txtBairro.Text}', cidade = '{txtCidade.Text}', estado = '{txtEstado.Text}' where id = '{lblID.Text}'";
				int resultado = bd.ExecutarComandos(atualizar);
				if (resultado == 1)
				{
					MessageBox.Show("Dados atualizados com sucesso!");
					LimparCampos();
					ExibirDados();
				}
				else
				{
					MessageBox.Show("Erro ao atualizar os dados!");
				}
			}
			else
			{
				MessageBox.Show("Dados inválidos!");
			}

		}


		private void txtNumero_TextChanged_1(object sender, EventArgs e)
		{
			txtNumero.MaxLength = 4;
		}


		private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
		{
			//Se a tecla digitada não for número e nem backspace
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
			{
				//Atribui True no Handled para cancelar o evento
				e.Handled = true;
			}
		}

		private void btnSalvar_Click_1(object sender, EventArgs e)
		{
			string inserir;
			if (txtNome.Text != "" && txtCep.Text != "" && txtLogradouro.Text != "" && txtNumero.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && txtEstado.Text != "")
			{
				inserir = $"INSERT INTO {tabela} VALUES(NULL,'{txtNome.Text}', '{txtCep.Text}','{txtLogradouro.Text}', '{txtNumero.Text}', '{txtBairro.Text}', '{txtCidade.Text}', '{txtEstado.Text}')";
				int resultado = bd.ExecutarComandos(inserir);
				if (resultado == 1)
				{
					MessageBox.Show("Valores inseridos com sucesso!");
					LimparCampos();
					ExibirDados();
				}
				else
				{
					MessageBox.Show("Erro ao inserir valores!");
				}

			}
			else
			{
				MessageBox.Show("Dados inválidos!");
			}
			
		}

		private void btnPesquisar_Click_1(object sender, EventArgs e)
		{
			ExibirDados();
			
		}

		

		private void dgvLoja_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			lblID.Text = dgvLoja.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtNome.Text = dgvLoja.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtCep.Text = dgvLoja.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtLogradouro.Text = dgvLoja.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtNumero.Text = dgvLoja.Rows[e.RowIndex].Cells[4].Value.ToString();
			txtBairro.Text = dgvLoja.Rows[e.RowIndex].Cells[5].Value.ToString();
			txtCidade.Text = dgvLoja.Rows[e.RowIndex].Cells[6].Value.ToString();
			txtEstado.Text = dgvLoja.Rows[e.RowIndex].Cells[7].Value.ToString();


		}

		private void LimparCampos()
		{
			lblID.Text = "";
			txtNome.Clear();
			txtBairro.Clear();
			txtCidade.Clear();
			txtEstado.Clear();
			txtLogradouro.Clear();
			txtNumero.Clear();
			txtCep.Clear();
			txtNome.Focus();
		}

		private void btnDeletar_Click(object sender, EventArgs e)
		{
			string deletar;
			if (lblID.Text != "")
			{
				deletar = $"DELETE FROM {tabela} where id = {lblID.Text}";
				int resultado = bd.ExecutarComandos(deletar);
				if (resultado == 1)
				{
					MessageBox.Show("Dados Deletados com sucesso!");
					LimparCampos();
					ExibirDados();
				}
				else 
				{
					MessageBox.Show("Erro ao deletar o dado!");
				}
			}
			else
			{
				MessageBox.Show("Campo ID sem valor preenchido!");
			}
		}
	}
}
