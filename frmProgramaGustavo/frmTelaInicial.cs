using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmProgramaGustavo
{
    public partial class frmTelaInicial : MaterialForm
    {
        private Denuncia denu;
        private DenunciaBD deBD;
        frmLogin frmLog = new frmLogin();

        public frmTelaInicial()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            denu = new Denuncia();
            deBD = new DenunciaBD();
            AtualizaGridView();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsulta frmConsul = new frmConsulta();
            DialogResult resposta = frmConsul.ShowDialog();
            if (resposta == DialogResult.OK)
            {       
                denu.Parametro = frmConsul.txtParametro.Text.ToString();
                if (deBD.consulta(denu,"Filtro").Rows.Count > 0)
                {
                    dgvDenuncias.DataSource = deBD.consulta(denu,"Filtro");
                    dgvDenuncias.Refresh();
                }
                else
                {
                    MessageBox.Show("Erro ao realizar a consulta", "Erro ao consultar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            btnIncluirClicado = true;
            atualizaForm();
        }


        private void btnLogoff_Click(object sender, EventArgs e)
        {
            btnLogoffClicado = true;
            atualizaForm();
        }

        private bool btnIncluirClicado = false;
        private bool btnLogoffClicado = false;

        private int idDenun;
        public int IdDenun
        {
            get { return this.idDenun; }
            set { this.idDenun = value; }
        }

        public void atualizaForm()
        {
            if(btnIncluirClicado == true)
            {
                frmManutenção frmManu = new frmManutenção(this.idDenun, "Inclusão");
                this.Hide();
                GC.Collect();
                frmManu.Show();
            }
            else
            {
                if(btnLogoffClicado == true)
                {
                    this.Close();
                    frmLog.Show();
                }
            }
        }

        private void AtualizaGridView()
        {
            dgvDenuncias.DataSource = deBD.consulta();
            dgvDenuncias.Refresh();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaGridView();
        }

        private void dgvDenuncias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int saida;
            if (e.RowIndex != -1)
            {
                if (int.TryParse(dgvDenuncias.Rows[e.RowIndex].Cells[0].Value.ToString(), out saida))
                {
                    //this.idDenun = int.Parse(dgvDenuncias.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this.idDenun = saida;
                }
            }
            frmManutenção frmManu = new frmManutenção(this.idDenun,"Consulta");
            this.Hide();
            GC.Collect();
            frmManu.Show();
        }

        private void dgvDenuncias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int saida;
            if(e.RowIndex != -1)
            {
                if(int.TryParse(dgvDenuncias.Rows[e.RowIndex].Cells[0].Value.ToString(), out saida))
                {
                    denu.IdDenuncia = saida;
                    lblTeste.Text = saida.ToString();
                }
            }
        }
    }
}
