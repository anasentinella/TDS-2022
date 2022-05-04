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
            btnCancela.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            Insercao = true;
            Edicao = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;
            btnCancela.Enabled = true;


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja mesmo Excluir?", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro salvo com sucesso!", "aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled=false;

            txtDescricao.Enabled = true;
            btnAlterar.Enabled = false;
            btnCancela.Visible = false;
            btnSalvar.Enabled = true;
            btnExcluir.Visible = true;
            btnNovo.Enabled = true;
            btnNovo.Focus();
            Insercao = false;
            Edicao = false;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
