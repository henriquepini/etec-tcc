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
    public partial class frmConsulta : MaterialForm
    {
        private Denuncia denu;
        private DenunciaBD deBD;
        public frmConsulta()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            denu = new Denuncia();
            deBD = new DenunciaBD();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtParametro.Text.ToString().Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo corretamente",
                    "Erro ao preencher", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtParametro.Focus();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
