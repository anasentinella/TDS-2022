using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemFinanc
{
    public partial class frmCategoria : Form
    {
        private bool Insercao = false;
        private bool Edicao = false;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkStatus.Checked = false;
            
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            txtNome.Text = "Combustivel";
            txtDescricao.Text = "Consumo de combustivel";
            rdDespesa.Checked = true;
            chkStatus.Checked = true;
            grpCategoria.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;
            limparCampos();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancela.Visible = false;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = true;
            chkStatus.Checked = true;

            Insercao = true;
            Edicao = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancela.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Visible = false;
            btnSalvar.Visible = true;
            btnCancela.Visible = true;
            Insercao = false;
            Edicao = true;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo Excluir? ", " Aviso do sistema! ", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    limparCampos();
                    MessageBox.Show(" Arquivo excluido com sucesso! ", " Aviso do sistema! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            else 
            {
               
            }
            btnNovo.Focus();
        }
         
    private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro salvo com sucesso!", "aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled=true;

            txtDescricao.Enabled = true;
            btnAlterar.Enabled = true;
            btnCancela.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            grpCategoria.Enabled = false;
            btnNovo.Enabled = true;
            btnNovo.Focus();
            Insercao = false;
            Edicao = false;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Visible = true;
            btnSalvar.Visible = false;
            btnCancela.Visible = false;
            grpCategoria.Enabled = false;
            btnNovo.Focus();
            Insercao = true;
            Edicao = false;
        }
        private void frmCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Rimani qui! :)", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
