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
    public partial class FrmConsultaProduto : Form
    {
        List<Produto> listaProdutos;
        Form formularioInvocador;

        public FrmConsultaProduto()
        {
            InitializeComponent();
        }

        public FrmConsultaProduto(Form formularioInvocador)
        {
            InitializeComponent();
            this.formularioInvocador = formularioInvocador;
        }

        private void TelaConsultaProduto_Load(object sender, EventArgs e)
        {
            CarregaListaProdutos();
        }

        public void CarregaListaProdutos()
        {
            dgvProdutos.AutoGenerateColumns = false;
            this.listaProdutos = new ProdutoDAO().GetListaProdutos();
            dgvProdutos.DataSource = new BindingList<Produto>(this.listaProdutos);
        }

        public void CarregaListaProdutosChave()
        {
            dgvProdutos.AutoGenerateColumns = false;
            String palavraChave = txtPalavraChave.Text.Replace(" ", "%");
            listaProdutos = new ProdutoDAO().GetListaProdutosChave(palavraChave);
            dgvProdutos.DataSource = new BindingList<Produto>(this.listaProdutos);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmProduto telaProduto = new FrmProduto(null);
            telaProduto.ShowDialog();
            CarregaListaProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount != 0)
            {
                if (dgvProdutos.CurrentRow.Selected)
                {
                    if (MessageBox.Show("Você realmente quer excluir este PRODUTO?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idProduto = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["Id"].Value.ToString());
                        ProdutoDAO dao = new ProdutoDAO();
                        dao.DeletaProduto(idProduto);
                        CarregaListaProdutos();
                    }
                } else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum PRODUTO selecionado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum PRODUTO cadastrado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount != 0)
            {
                if (dgvProdutos.CurrentRow.Selected)
                {
                    int idProduto = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["Id"].Value.ToString());
                    FrmProduto telaProduto = new FrmProduto(this.listaProdutos.Find(p => p.IdProduto == idProduto));
                    telaProduto.ShowDialog();
                    CarregaListaProdutos();
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum PRODUTO selecionado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum PRODUTO cadastrado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPalavraChave.Text == "")
            {
                CarregaListaProdutos();
            }
            else
            {
                CarregaListaProdutosChave();
            }
        }

        private void dgvProdutos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.formularioInvocador != null)
            {
                if (dgvProdutos.RowCount != 0)
                {
                    if (dgvProdutos.CurrentRow.Selected)
                    {
                        int idProduto = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["Id"].Value);
                        ((FrmVenda)formularioInvocador).CarregaListaProdutos();
                        ((FrmVenda)formularioInvocador).DefineProduto(idProduto);
                        this.Close();

                    }
                    else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum PRODUTO selecionado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum PRODUTO cadastrado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPalavraChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
                btnBuscar.PerformClick();
        }
    }
}
