using System;
using System.Windows.Forms;

namespace frmProgramaGustavo
{
    partial class frmTelaInicial
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.dgvDenuncias = new System.Windows.Forms.DataGridView();
            this.Id_Denuncia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ponto_Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblTeste = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenuncias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(308, 386);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 39);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(544, 386);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(110, 39);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnLogoff
            // 
            this.btnLogoff.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogoff.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoff.Location = new System.Drawing.Point(780, 385);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(110, 39);
            this.btnLogoff.TabIndex = 6;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // dgvDenuncias
            // 
            this.dgvDenuncias.AllowUserToAddRows = false;
            this.dgvDenuncias.AllowUserToDeleteRows = false;
            this.dgvDenuncias.AllowUserToResizeColumns = false;
            this.dgvDenuncias.AllowUserToResizeRows = false;
            this.dgvDenuncias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDenuncias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Denuncia,
            this.Nome,
            this.CPF,
            this.Data,
            this.Tipo,
            this.Local,
            this.Descrição,
            this.Ponto_Referencia,
            this.Status});
            this.dgvDenuncias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDenuncias.Location = new System.Drawing.Point(12, 77);
            this.dgvDenuncias.Name = "dgvDenuncias";
            this.dgvDenuncias.ReadOnly = true;
            this.dgvDenuncias.Size = new System.Drawing.Size(944, 302);
            this.dgvDenuncias.TabIndex = 7;
            this.dgvDenuncias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDenuncias_CellClick);
            this.dgvDenuncias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDenuncias_CellDoubleClick);
            // 
            // Id_Denuncia
            // 
            this.Id_Denuncia.DataPropertyName = "ID_Denun";
            this.Id_Denuncia.HeaderText = "ID Denúncia";
            this.Id_Denuncia.Name = "Id_Denuncia";
            this.Id_Denuncia.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Local
            // 
            this.Local.DataPropertyName = "Local";
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.ReadOnly = true;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "Descricao";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            // 
            // Ponto_Referencia
            // 
            this.Ponto_Referencia.DataPropertyName = "Ponto_refe";
            this.Ponto_Referencia.HeaderText = "Ponto de Referência";
            this.Ponto_Referencia.Name = "Ponto_Referencia";
            this.Ponto_Referencia.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(72, 386);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(110, 39);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(472, 397);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(34, 13);
            this.lblTeste.TabIndex = 8;
            this.lblTeste.Text = "Teste";
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogoff;
            this.ClientSize = new System.Drawing.Size(964, 437);
            this.ControlBox = false;
            this.Controls.Add(this.lblTeste);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvDenuncias);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnConsultar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenuncias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.DataGridView dgvDenuncias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Denuncia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ponto_Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnAtualizar;
        private Label lblTeste;
    }
}

