﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trinity.Model.Bean;
using Trinity.Model.DAO;

namespace Trinity.View
{
    public partial class FrmVenda : Form
    {
        public FrmVenda()
        {
            InitializeComponent();
            CarregaListaClientes();
            CarregaListaProdutos();
            LimpaCampos();
        }

        public void DefineCliente(ClientePF_PJ cliente)
        {
            cmbCliente.DisplayMember = "NomeRazaoSocial";
            List<ClientePF_PJ> adapter = new List<ClientePF_PJ>();
            adapter.Add(cliente);
            cmbCliente.DataSource = adapter;
        }

        public void LimpaCampos()
        {
            txtDataVenda.Text = DateTime.Now.ToString();
            cmbCliente.SelectedItem = null;
            cmbProduto.SelectedItem = null;
        }

        public void CarregaListaClientes()
        {
            List<Cliente> listaClientes = new ClienteDAO().GetListaClientes();
            List<ClientePF_PJ> listaClientesPreparados = new List<ClientePF_PJ>();
            foreach (var cliente in listaClientes)
            {
                ClientePF_PJ clientePreparado = new ClientePF_PJ();

                if (cliente is ClientePF)
                {
                    clientePreparado.Id = cliente.IdCliente;
                    clientePreparado.NomeRazaoSocial = ((ClientePF)cliente).Nome;
                    clientePreparado.ApelidoNomeFantasia = ((ClientePF)cliente).Apelido;
                    clientePreparado.CpfCnpj = ((ClientePF)cliente).Cpf;

                }
                else if (cliente is ClientePJ)
                {
                    clientePreparado.Id = cliente.IdCliente;
                    clientePreparado.NomeRazaoSocial = ((ClientePJ)cliente).RazaoSocial;
                    clientePreparado.ApelidoNomeFantasia = ((ClientePJ)cliente).NomeFantasia;
                    clientePreparado.CpfCnpj = ((ClientePJ)cliente).Cnpj;
                }

                listaClientesPreparados.Add(clientePreparado);
            }
            listaClientes = null;
            cmbCliente.DisplayMember = "NomeRazaoSocial";
            cmbCliente.DataSource = listaClientesPreparados;
        }

        private void CarregaListaProdutos()
        {
            cmbProduto.DisplayMember = "Descricao";
            cmbProduto.DataSource = new ProdutoDAO().GetListaProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente telaConsultaCliente = new FrmConsultaCliente(this);
            telaConsultaCliente.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
