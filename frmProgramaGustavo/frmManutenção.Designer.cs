namespace frmProgramaGustavo
{
    partial class frmManutenção
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
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescric = new System.Windows.Forms.Label();
            this.txtDescric = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConfimar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblPonto = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRefe = new System.Windows.Forms.TextBox();
            this.lblIdDenuncia = new System.Windows.Forms.Label();
            this.txtIdDenuncia = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(12, 130);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 15);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF :";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(74, 128);
            this.mtbCPF.Mask = "999.999.999-99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(90, 20);
            this.mtbCPF.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(12, 196);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(49, 15);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo :";
            // 
            // lblDescric
            // 
            this.lblDescric.AutoSize = true;
            this.lblDescric.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescric.Location = new System.Drawing.Point(12, 295);
            this.lblDescric.Name = "lblDescric";
            this.lblDescric.Size = new System.Drawing.Size(84, 15);
            this.lblDescric.TabIndex = 8;
            this.lblDescric.Text = "Descrição :";
            // 
            // txtDescric
            // 
            this.txtDescric.Location = new System.Drawing.Point(102, 295);
            this.txtDescric.Multiline = true;
            this.txtDescric.Name = "txtDescric";
            this.txtDescric.Size = new System.Drawing.Size(289, 86);
            this.txtDescric.TabIndex = 7;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(12, 235);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(56, 15);
            this.lblLocal.TabIndex = 10;
            this.lblLocal.Text = "Local :";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(74, 233);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(317, 20);
            this.txtLocal.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 399);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(105, 15);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status atual :";
            // 
            // btnConfimar
            // 
            this.btnConfimar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfimar.Location = new System.Drawing.Point(78, 458);
            this.btnConfimar.Name = "btnConfimar";
            this.btnConfimar.Size = new System.Drawing.Size(80, 23);
            this.btnConfimar.TabIndex = 10;
            this.btnConfimar.Text = "Confirmar";
            this.btnConfimar.UseVisualStyleBackColor = true;
            this.btnConfimar.Click += new System.EventHandler(this.btnConfimar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(243, 458);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(12, 164);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(49, 15);
            this.lblData.TabIndex = 16;
            this.lblData.Text = "Data :";
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(74, 162);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(66, 20);
            this.mtbData.TabIndex = 3;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(74, 196);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(175, 20);
            this.txtTipo.TabIndex = 4;
            // 
            // lblPonto
            // 
            this.lblPonto.AutoSize = true;
            this.lblPonto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPonto.Location = new System.Drawing.Point(12, 266);
            this.lblPonto.Name = "lblPonto";
            this.lblPonto.Size = new System.Drawing.Size(91, 15);
            this.lblPonto.TabIndex = 18;
            this.lblPonto.Text = "Referência :";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 101);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 15);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nome :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(324, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtRefe
            // 
            this.txtRefe.Location = new System.Drawing.Point(109, 264);
            this.txtRefe.Name = "txtRefe";
            this.txtRefe.Size = new System.Drawing.Size(282, 20);
            this.txtRefe.TabIndex = 6;
            // 
            // lblIdDenuncia
            // 
            this.lblIdDenuncia.AutoSize = true;
            this.lblIdDenuncia.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDenuncia.Location = new System.Drawing.Point(12, 75);
            this.lblIdDenuncia.Name = "lblIdDenuncia";
            this.lblIdDenuncia.Size = new System.Drawing.Size(35, 15);
            this.lblIdDenuncia.TabIndex = 20;
            this.lblIdDenuncia.Text = "ID :";
            // 
            // txtIdDenuncia
            // 
            this.txtIdDenuncia.Enabled = false;
            this.txtIdDenuncia.Location = new System.Drawing.Point(74, 73);
            this.txtIdDenuncia.Name = "txtIdDenuncia";
            this.txtIdDenuncia.Size = new System.Drawing.Size(50, 20);
            this.txtIdDenuncia.TabIndex = 20;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(123, 397);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(175, 20);
            this.txtStatus.TabIndex = 8;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(118, 429);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 23);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(204, 429);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 23);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmManutenção
            // 
            this.AcceptButton = this.btnConfimar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVoltar;
            this.ClientSize = new System.Drawing.Size(410, 487);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtIdDenuncia);
            this.Controls.Add(this.lblIdDenuncia);
            this.Controls.Add(this.txtRefe);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblPonto);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConfimar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.txtDescric);
            this.Controls.Add(this.lblDescric);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.lblCPF);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManutenção";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Manutenção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDescric;
        private System.Windows.Forms.TextBox txtDescric;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnConfimar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblPonto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRefe;
        private System.Windows.Forms.Label lblIdDenuncia;
        private System.Windows.Forms.TextBox txtIdDenuncia;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}