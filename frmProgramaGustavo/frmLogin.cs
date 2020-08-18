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
    public partial class frmLogin : MaterialForm
    {
        Usuario usu = new Usuario();
        UsuarioBD usuBD = new UsuarioBD();
        public frmLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usu.Login = txtLogin.Text;
            usu.Senha = txtSenha.Text;

            if (usuBD.conecta(usu))
            {
                frmTelaInicial frmTeIn = new frmTelaInicial();
                this.Hide();
                frmTeIn.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha errados");
                txtLogin.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
