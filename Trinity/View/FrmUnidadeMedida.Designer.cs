﻿namespace Trinity.View
{
    partial class FrmUnidadeMedida
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnidadeMedida));
            this.lblUnidade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtUnidadeMedida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.epUn = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUnidade.Location = new System.Drawing.Point(147, 28);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(150, 18);
            this.lblUnidade.TabIndex = 17;
            this.lblUnidade.Text = "Unidade de Medida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(291, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtUnidadeMedida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblUnidade);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSigla);
            this.groupBox1.Controls.Add(this.lblSigla);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(2, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Unidade de Medida";
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Arial", 12F);
            this.txtId.Location = new System.Drawing.Point(9, 47);
            this.txtId.MaxLength = 2;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(64, 26);
            this.txtId.TabIndex = 22;
            this.txtId.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Arial", 12F);
            this.lblId.Location = new System.Drawing.Point(6, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(60, 18);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "Código";
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidadeMedida.Font = new System.Drawing.Font("Arial", 12F);
            this.txtUnidadeMedida.Location = new System.Drawing.Point(152, 47);
            this.txtUnidadeMedida.MaxLength = 15;
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.Size = new System.Drawing.Size(238, 26);
            this.txtUnidadeMedida.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(120, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "*";
            // 
            // txtSigla
            // 
            this.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSigla.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSigla.Location = new System.Drawing.Point(82, 47);
            this.txtSigla.MaxLength = 2;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(64, 26);
            this.txtSigla.TabIndex = 0;
            this.txtSigla.Leave += new System.EventHandler(this.txtSigla_Leave);
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSigla.Location = new System.Drawing.Point(78, 28);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(48, 18);
            this.lblSigla.TabIndex = 0;
            this.lblSigla.Text = "Sigla:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTÃO DE UNIDADES DE MEDIDA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 47);
            this.panel1.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(231, 171);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F);
            this.btnExcluir.Location = new System.Drawing.Point(300, 134);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 29);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEditar.Location = new System.Drawing.Point(83, 171);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 29);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(11, 134);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(98, 29);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSalvar.Location = new System.Drawing.Point(152, 134);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 29);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // epUn
            // 
            this.epUn.ContainerControl = this;
            // 
            // FrmUnidadeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 225);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmUnidadeMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trinity: Gestão de Unidades de Medida";
            this.Load += new System.EventHandler(this.FrmUnidadeMedida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epUn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUnidadeMedida;
        private System.Windows.Forms.ErrorProvider epUn;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
    }
}