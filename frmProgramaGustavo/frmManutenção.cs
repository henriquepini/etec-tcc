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
    public partial class frmManutenção : MaterialForm
    {
        private Denuncia denu;
        private DenunciaBD deBD;
        public String operacao;

        public frmManutenção()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            denu = new Denuncia();
            deBD = new DenunciaBD();
        }
        public frmManutenção(int idDenun,String operacao)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            denu = new Denuncia();
            deBD = new DenunciaBD();
            this.operacao = operacao;
            denu.IdDenuncia = idDenun;
            if(this.operacao == "Consulta")
            {
                DesabilitaCampos();
                HabilitaBotoes();
                deBD.consulta(denu,"Consulta");
                MoveObjetoTela();
            }
            else
            {
                if(this.operacao == "Inclusão")
                {
                    LimpaCampos();
                    DesabilitaBotoes();
                }
            }
        }
        private void LimpaCampos()
        {
            txtIdDenuncia.Clear();
            txtNome.Clear();
            mtbCPF.Clear();
            mtbData.Clear();
            txtTipo.Clear();
            txtLocal.Clear();
            txtRefe.Clear();
            txtDescric.Clear();
            txtStatus.Clear();
        }
        private void HabilitaBotoes()
        {
            btnConfimar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        private void DesabilitaBotoes()
        {
            btnConfimar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        private void DesabilitaCampos()
        {
            txtNome.Enabled = false;
            mtbCPF.Enabled = false;
            mtbData.Enabled = false;
            txtTipo.Enabled = false;
            txtLocal.Enabled = false;
            txtRefe.Enabled = false;
            txtDescric.Enabled = false;
            txtStatus.Enabled = false;
        }
        private void HabilitaCampos()
        {
            txtNome.Enabled = true;
            mtbCPF.Enabled = true;
            mtbData.Enabled = true;
            txtTipo.Enabled = true;
            txtLocal.Enabled = true;
            txtRefe.Enabled = true;
            txtDescric.Enabled = true;
            txtStatus.Enabled = true;
        }
        private void MoveObjetoTela()
        {
            txtIdDenuncia.Text = denu.IdDenuncia.ToString();
            txtNome.Text = denu.Nome;
            mtbCPF.Text = denu.Cpf;
            mtbData.Text = denu.Data.ToString();
            txtTipo.Text = denu.Tipo;
            txtLocal.Text = denu.Local;
            txtRefe.Text = denu.PontoRefe;
            txtDescric.Text = denu.Descricao;
            txtStatus.Text = denu.Status;
        }
        private void MoveTelaObjeto()
        {
            denu.Nome = txtNome.Text;
            denu.Cpf = mtbCPF.Text;
            denu.Data = Convert.ToDateTime(mtbData.Text.ToString());
            denu.Tipo = txtTipo.Text;
            denu.Local = txtLocal.Text;
            denu.PontoRefe = txtRefe.Text;
            denu.Descricao = txtDescric.Text;
            denu.Status = txtStatus.Text;
        }


        private Boolean consisteCampos()
        {
            Boolean retorno = false;
            DateTime convertidoDT;
            if (txtNome.Text.ToString().Length < 5)
            {
                MessageBox.Show("Preencha o campo STAUTS corretamente", "Erro ao preencher",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else
            {
                if (mtbCPF.Text.ToString().Length < 14)
                {
                    MessageBox.Show("Preencha o campo CPF corretamente", "Erro ao preencher",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    mtbCPF.Focus();
                }
                else
                {
                    if (DateTime.TryParse(mtbData.Text, out convertidoDT) == false)
                    {
                        MessageBox.Show("Preencha o campo DATA corretamente", "Erro ao preencher",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        mtbData.Focus();
                    }
                    else
                    {
                        if (txtTipo.Text.ToString().Length < 6)
                        {
                            MessageBox.Show("Preencha o campo TIPO corretamente", "Erro ao preencher",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            txtTipo.Focus();
                        }
                        else
                        {
                            if (txtLocal.Text.ToString().Length < 5)
                            {
                                MessageBox.Show("Preencha o campo LOCAL corretamente", "Erro ao preencher",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                txtLocal.Focus();
                            }
                            else
                            {
                                if (txtRefe.Text.ToString().Length < 2)
                                {
                                    MessageBox.Show("Preencha o campo REFERÊNCIA corretamente", "Erro ao preencher",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                    txtRefe.Focus();
                                }
                                else
                                {
                                    if (txtDescric.Text.ToString().Length < 5)
                                    {
                                        MessageBox.Show("Preencha o campo DESCRIÇÃO corretamente", "Erro ao preencher",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                                        txtDescric.Focus();
                                    }
                                    else
                                    {
                                        if(txtStatus.Text.ToString().Length < 4)
                                        {
                                            MessageBox.Show("Preencha o campo STATUS corretamente", "Erro ao preencher",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                            txtStatus.Focus();
                                        }
                                        retorno = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return retorno;
        }

        private void btnConfimar_Click(object sender, EventArgs e)
        {
            int resultado;
            if (consisteCampos() == true)
            {
                if (operacao == "Inclusão")
                {
                    DialogResult resposta = MessageBox.Show("Confirmar a " + operacao + " da Denúncia ?",
                                        "Confirmação da " + operacao,
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
                    if (resposta == DialogResult.Yes)
                    {
                        MoveTelaObjeto();
                        if (deBD.inclui(denu))
                        {
                            MessageBox.Show(operacao + " realizada com sucesso", operacao + " concluída",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                            frmTelaInicial frmTeIn = new frmTelaInicial();
                            this.Close();
                            GC.Collect();
                            frmTeIn.Show();
                        }
                        else
                        {
                            MessageBox.Show("Falha na " + operacao + " da Denúncia", "Erro de " + operacao,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(operacao + " interrompida", "Cancelamento da " + operacao,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (operacao == "Alteração")
                    {
                        DialogResult resposta = MessageBox.Show("Confirmar a " + operacao + " da Denúncia ?",
                                        "Confirmação da " + operacao + ".",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
                        if (resposta == DialogResult.Yes)
                        {
                            MoveTelaObjeto();
                            if (int.TryParse(txtIdDenuncia.Text, out resultado)){
                                if (deBD.altera(denu))
                                {
                                    MessageBox.Show(operacao + " realizada com sucesso", operacao + " concluída",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                                    frmTelaInicial frmTeIn = new frmTelaInicial();
                                    this.Close();
                                    GC.Collect();
                                    frmTeIn.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show(operacao + " cancelada", "Alerta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if(operacao == "Consulta")
            {
                frmTelaInicial frmTeIn = new frmTelaInicial();
                this.Close();
                GC.Collect();
                frmTeIn.Show();
            }
            else
            {
                DialogResult resposta = MessageBox.Show("Cancelar " + operacao + "?", "Cancelamento da " + operacao,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                    MessageBox.Show(operacao + " cancelada", "Cancelamento da " + operacao, 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    frmTelaInicial frmTeIn = new frmTelaInicial();
                    this.Close();
                    GC.Collect();
                    frmTeIn.Show();
                }
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Apenas letras neste campo","Erro ao preencher",MessageBoxButtons.OK);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            operacao = "Alteração";
            HabilitaCampos();
            DesabilitaBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacao = "Exclusão";
            int resultado;
            if(consisteCampos() == true)
            {
                if(int.TryParse(txtIdDenuncia.Text, out resultado))
                {
                    if(MessageBox.Show(null, "Confirmar a "+operacao+"?","Confirmação da "+operacao,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (deBD.exclui(denu))
                        {
                            MessageBox.Show(null, operacao + " realizada com sucesso",
                                operacao + " concluída",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                            frmTelaInicial frmTeIn = new frmTelaInicial();
                            this.Close();
                            GC.Collect();
                            frmTeIn.Show();
                        }
                        else
                        {
                            MessageBox.Show(null, operacao + " cancelada", "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(null, operacao + " cancelada", "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Algo de errado aconteceu ao selecionar a Denúncia", "Falha de consistência",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}

