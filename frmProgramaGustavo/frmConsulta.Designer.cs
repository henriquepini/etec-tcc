namespace frmProgramaGustavo
{
    partial class frmConsulta
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
            this.lblProcure = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblParametro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProcure
            // 
            this.lblProcure.AutoSize = true;
            this.lblProcure.BackColor = System.Drawing.Color.Red;
            this.lblProcure.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcure.Location = new System.Drawing.Point(19, 71);
            this.lblProcure.Name = "lblProcure";
            this.lblProcure.Size = new System.Drawing.Size(273, 60);
            this.lblProcure.TabIndex = 1;
            this.lblProcure.Text = "Por favor, procure uma denúncia usando\r\napenas UM dos seguintes parâmetros :\r\n   " +
    "  Nome, Tipo, Local, Descricao,\r\n         Ponto_Refe, Status";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(43, 174);
            this.txtParametro.Multiline = true;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(223, 27);
            this.txtParametro.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnConfirmar.Location = new System.Drawing.Point(51, 251);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.btnVoltar.Location = new System.Drawing.Point(178, 251);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametro.Location = new System.Drawing.Point(40, 153);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(224, 18);
            this.lblParametro.TabIndex = 5;
            this.lblParametro.Text = "Digite o que quer encontrar";
            // 
            // frmConsulta
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVoltar;
            this.ClientSize = new System.Drawing.Size(304, 288);
            this.ControlBox = false;
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblProcure);
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcure;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblParametro;
        public System.Windows.Forms.TextBox txtParametro;
    }
}