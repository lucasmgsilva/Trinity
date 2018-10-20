﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trinity.Factory;
using Trinity.Model.Bean;

namespace Trinity.Model.DAO
{
    public class MarcaDAO
    {
        SqlConnection connection;

        public MarcaDAO()
        {
            this.connection = new ConnectionFactory().getConnection();
        }

        public void AdicionaMarca (Marca marca)
        {
            string query = "EXECUTE SP_INSERE_MARCA "
                           + "@Marca";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                cmd.Parameters.AddWithValue("@Marca", marca.marca);
                cmd.ExecuteNonQuery();
                MessageBox.Show("A Marca foi cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.connection.Close();

            } catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Não foi possível realizar a operação.\nJá existe um cadastro com esta MARCA!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("Um erro inesperado ocorreu: \n" + ex.Message, "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Marca> GetListaMarcas()
        {
            string query = "SELECT * FROM VW_SELECIONA_MARCA";
            try
            {
                this.connection.Open();
                SqlCommand cmd = new SqlCommand(query, this.connection);
                SqlDataReader dtr = cmd.ExecuteReader();

                List<Marca> listaMarcas = new List<Marca>();

                while (dtr.Read())
                {
                    Marca marca = new Marca();
                    marca.IdMarca = Convert.ToInt32(dtr["idMarca"].ToString());
                    marca.marca = dtr["marca"].ToString();
                    listaMarcas.Add(marca);
                }

                dtr.Close();
                this.connection.Close();

                return listaMarcas;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + ex.Message);
                throw ex;
            }
        }
    }
}
