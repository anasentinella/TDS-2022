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
      
        private Categoria categoria = new Categoria();
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsCategoria;
      
        public frmCategoria()
        {
            InitializeComponent();
            lstCategoria = categoria.GeraCategorias();
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
            dgCategoria.ColumnCount = 5;
            dgCategoria.AutoGenerateColumns = false;
            dgCategoria.Columns[0].Width = 50;
            dgCategoria.Columns[0].HeaderText = "ID";
            dgCategoria.Columns[0].DataPropertyName = "Id";
            dgCategoria.Columns[0].Visible = false;
            dgCategoria.Columns[1].Width = 200;
            dgCategoria.Columns[1].HeaderText = "NOME";
            dgCategoria.Columns[1].DataPropertyName = "Nome";
            dgCategoria.Columns[2].Width = 400;
            dgCategoria.Columns[2].HeaderText = "DESCRIÇÃO";
            dgCategoria.Columns[2].DataPropertyName = "Descricao";
            dgCategoria.Columns[3].Width = 50;
            dgCategoria.Columns[3].HeaderText = "TIPO";
            dgCategoria.Columns[3].DataPropertyName = "Tipo";
            dgCategoria.Columns[4].Width = 50;
            dgCategoria.Columns[4].HeaderText = "STATUS";
            dgCategoria.Columns[4].DataPropertyName = "Status";
            dgCategoria.AllowUserToAddRows = false;
            dgCategoria.AllowUserToDeleteRows = false;
            dgCategoria.MultiSelect = false;
            dgCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaCategoria();
        }

        public void carregaCategoria()
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            //dgCategoria.Rows.Clear();
            dgCategoria.DataSource = bsCategoria;
            dgCategoria.Refresh();
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
            btnAlterar.Enabled = false;
            btnExcluir.Visible = false;
            btnSalvar.Visible = true;
            btnCancela.Visible = true;
            Insercao = false;
            Edicao = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja mesmo Excluir?", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("arquivo excluido com sucesso", "aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro salvo com sucesso!", "aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled=false;

            txtDescricao.Enabled = true;
            btnAlterar.Enabled = true;
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

        private void frmCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Rimani qui! :)", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            btnNovo.Focus();
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Visible = true;
            btnSalvar.Visible = false;
            btnCancela.Visible = false;
            grpCategoria.Enabled = false;
            Insercao = true;
            Edicao = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
