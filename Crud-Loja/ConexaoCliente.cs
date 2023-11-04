using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Crud_Loja
{
	internal class ConexaoCliente
	{
		MySqlConnection conn;

		//Metodo de conectar ao bd

		public void ConectarBD()
		{
			try
			{
				conn = new MySqlConnection("Persist Security info= false; server = localhost;database=BdLoja;user=root;pwd=;");
				conn.Open();
			}
			catch (Exception)
			{
				throw;
			}
		}
		public int ExecutarComandos(string sql)
		{
			int resultado;
			try
			{
				ConectarBD();
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.ExecuteNonQuery();
				resultado = 1;


			}
			catch (Exception)
			{

				resultado = 0;
				throw;

			}
			finally
			{
				conn.Close();

			}
			return resultado;
		}

		public DataTable ExecutarConsulta(string sql)
		{
			try
			{
				ConectarBD();
				MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				conn.Close();
			}

		}
	}
}
