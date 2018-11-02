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
    public partial class FrmCargo : Form
    {
        List<Cargo> listaCargos;
        bool editando;
        Cargo cargoCarregado;

        public FrmCargo()
        {
            InitializeComponent();
            this.editando = false;
            LimpaCampos();
        }

        private void DesabilitaCampos()
        {
            txtCargo.Enabled = false;
            chkEmpresas.Enabled = false;
            chkVendas.Enabled = false;
            chkClientes.Enabled = false;
            chkFornecedores.Enabled = false;
            chkProdutos.Enabled = false;
            chkUsuarios.Enabled = false;
            chkCompras.Enabled = false;
        }

        private void HabilitaCampos()
        {
            txtCargo.Enabled = !false;
            chkEmpresas.Enabled = !false;
            chkVendas.Enabled = !false;
            chkClientes.Enabled = !false;
            chkFornecedores.Enabled = !false;
            chkProdutos.Enabled = !false;
            chkUsuarios.Enabled = !false;
            chkCompras.Enabled = !false;
        }

        private void HabilitaBotoes()
        {
            DesabilitaCampos();
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void DesabilitaBotoes()
        {
            HabilitaCampos();
            btnNovo.Enabled = !true;
            btnSalvar.Enabled = !false;
            btnEditar.Enabled = !true;
            btnExcluir.Enabled = !true;
        }

        private void LimpaCampos()
        {
            HabilitaBotoes();
            txtCargo.Text = String.Empty;
            chkEmpresas.Checked = false;
            chkVendas.Checked = false;
            chkClientes.Checked = false;
            chkFornecedores.Checked = false;
            chkProdutos.Checked = false;
            chkUsuarios.Checked = false;
            chkCompras.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCargo.Text))
            {
                string permissoes = String.Empty;
                if (chkEmpresas.Checked)
                    permissoes += "EM";
                if (chkVendas.Checked)
                    permissoes += "VE";
                if (chkClientes.Checked)
                    permissoes += "CL";
                if (chkFornecedores.Checked)
                    permissoes += "FO";
                if (chkProdutos.Checked)
                    permissoes += "PR";
                if (chkUsuarios.Checked)
                    permissoes += "US";
                if (chkCompras.Checked)
                    permissoes += "CO";

                if (this.cargoCarregado == null)
                    this.cargoCarregado = new Cargo();

                this.cargoCarregado.cargo = txtCargo.Text;
                this.cargoCarregado.Permissoes = permissoes;

                CargoDAO dao = new CargoDAO();
                if (!this.editando)
                    dao.AdicionaCargo(this.cargoCarregado);
                else dao.AlteraCargo(this.cargoCarregado);
                CarregaListaCargos();
            } else MessageBox.Show("Não foi possível realizar a operação.\nHá CAMPOS OBRIGATÓRIOS que não foram preenchidos!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.editando)
            {
                if (MessageBox.Show("Você realmente quer desfazer as alterações deste CARGO?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HabilitaBotoes();
                    this.editando = false;
                    CarregaCargo();
                }
            }
            else this.Close();
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            CarregaListaCargos();
        }

        public void CarregaListaCargos()
        {
            dgvCargos.AutoGenerateColumns = false;
            listaCargos = new CargoDAO().GetListaCargos();
            dgvCargos.DataSource = new BindingList<Cargo>(listaCargos);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCargos.RowCount != 0)
            {
                if (dgvCargos.CurrentRow.Selected)
                {
                    this.editando = true;
                    DesabilitaBotoes();
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum CARGO selecionado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum CARGO cadastrado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvcargos_SelectionChanged(object sender, EventArgs e)
        {
            LimpaCampos();
            if (dgvCargos.RowCount != 0)
            {
                if (dgvCargos.CurrentRow.Selected)
                {
                    this.editando = false;
                    int idCargo = Convert.ToInt32(dgvCargos.CurrentRow.Cells["idCargo"].Value.ToString());
                    this.cargoCarregado = this.listaCargos.Find(u => u.IdCargo == idCargo);
                    CarregaCargo();
                }
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum CARGO cadastrado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CarregaCargo()
        {
            txtCargo.Text = cargoCarregado.cargo;
            string permissoes = cargoCarregado.Permissoes;
            for (int i = 0; i < permissoes.Length; i += 2)
            {
                if (permissoes.Substring(i, 2) == "EM")
                    chkEmpresas.Checked = true;
                else if (permissoes.Substring(i, 2) == "VE")
                    chkVendas.Checked = true;
                else if (permissoes.Substring(i, 2) == "CL")
                    chkClientes.Checked = true;
                else if (permissoes.Substring(i, 2) == "FO")
                    chkFornecedores.Checked = true;
                else if (permissoes.Substring(i, 2) == "PR")
                    chkProdutos.Checked = true;
                else if (permissoes.Substring(i, 2) == "US")
                    chkUsuarios.Checked = true;
                else if (permissoes.Substring(i, 2) == "CO")
                    chkCompras.Checked = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.editando = false;
            LimpaCampos();
            DesabilitaBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCargos.RowCount != 0)
            {
                if (dgvCargos.CurrentRow.Selected)
                {
                    if (MessageBox.Show("Você realmente quer excluir este CARGO?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CargoDAO dao = new CargoDAO();
                        dao.DeletaCargo(this.cargoCarregado.IdCargo);
                        CarregaListaCargos();
                    }
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum CARGO selecionado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum CARGO cadastrado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
