using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmProgramaGustavo
{
    public partial class frmFiltrado : MaterialForm
    {
        frmConsulta frmCon = new frmConsulta();
        frmTelaInicial frmTeIn = new frmTelaInicial();
        public frmFiltrado()

        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private bool btnVoltarClicado = false;
        private bool btnAlterarClicado = false;
        private bool btnExcluirClicado = false;

        public void abreForm()
        {
            if(btnVoltarClicado == true)
            {
                this.Hide();
                frmTeIn.Show();
            }
            else
            {
                if(btnAlterarClicado == true)
                {
                    this.Hide();
                    frmCon.Show();
                }
                else
                {
                    if(btnExcluirClicado == true)
                    {
                        this.Hide();
                        frmCon.Show();
                    }
                }
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            btnVoltarClicado = true;
            abreForm();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterarClicado = true;
            abreForm();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnExcluirClicado = true;
            abreForm();
        }
    }
}
