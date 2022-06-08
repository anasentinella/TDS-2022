using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisFin
{
    public partial class frmContas : Form
    {
        private Contas contas = new Contas();
        private List<Contas> lstContas = new List<Contas>();
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsContas;
        private BindingSource bsCategoria;

        public frmContas()
        {
            InitializeComponent();
            lstContas = contas.GeraContas();
            lstCategoria = (new Categoria()).GeraCategorias();
        }

       

        private void carregaComboCategoria(int id = 0)
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            cboCategoria.DataSource = bsCategoria;
            cboCategoria.DisplayMember = "Nome";
            cboCategoria.SelectedItem = "id";
            if (id>0)
            {
                foreach (var c in lstCategoria)
                {
                    if (c.Id == id)
                    {
                        int index = cboCategoria.FindString(c.Nome);
                        cboCategoria.SelectedIndex = index;
                    }
                }
            }
            cboCategoria.Refresh();
        }

        private void frmContas_Load(object sender, EventArgs e)
        {
            carregaComboCategoria();

            dgContas.AllowUserToAddRows = false;
            dgContas.AllowUserToDeleteRows = false;
            dgContas.MultiSelect = false;
            dgContas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgContas.ColumnCount = 4;
            dgContas.AutoGenerateColumns = false;
            dgContas.Columns[0].Width = 50;
            dgContas.Columns[0].HeaderText = "ID";
            dgContas.Columns[0].DataPropertyName = "Id";
            dgContas.Columns[0].Visible = false;
            dgContas.Columns[1].Width = 200;
            dgContas.Columns[1].HeaderText = "NOME";
            dgContas.Columns[1].DataPropertyName = "Nome";
            dgContas.Columns[2].Width = 400;
            dgContas.Columns[2].HeaderText = "DESCRIÇÃO";
            dgContas.Columns[2].DataPropertyName = "Descricao";
            dgContas.Columns[3].Width = 50;
            dgContas.Columns[3].HeaderText = "STATUS";
            dgContas.Columns[3].DataPropertyName = "Status";

            dgContas.AllowUserToAddRows = false;
            dgContas.AllowUserToDeleteRows = false;
            dgContas.MultiSelect = false;
            dgContas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaGridContas();
        }
        private void carregaGridContas()
        {
            bsContas = new BindingSource();
            bsContas.DataSource = lstContas;
            dgContas.DataSource = bsContas;
            dgContas.Refresh();
        }
        private void dgContas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgContas.RowCount > 0)
            {
                int _id = Convert.ToInt32(dgContas.Rows[e.RowIndex].Cells[0].Value);
                carregaComboCategoria(_id);

                txtNome.Text = dgContas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescricao.Text = dgContas.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (Convert.ToInt16(dgContas.Rows[e.RowIndex].Cells[3].Value.ToString()) == 1)
                    chkStatus.Checked = true;
                else
                    chkStatus.Checked = false;
            }
        }
    }
}
       

