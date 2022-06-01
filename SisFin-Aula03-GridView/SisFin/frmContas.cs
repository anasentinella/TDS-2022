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

        public frmContas()
        {
            InitializeComponent();
            lstContas = contas.GeraContas();
            lstCategoria = (new Categoria()).GeraCategorias();
        }

            private void carregaGridContas()
            {
                bsContas = new BindingSource();
                bsContas.DataSource = lstContas;
                dgContas.DataSource = bsContas;
                dgContas.Refresh();
            }

        private void frmContas_Load(object sender, EventArgs e)
        {
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
            dgContas.Columns[3].HeaderText = "TIPO";
            dgContas.Columns[3].DataPropertyName = "Tipo";
            dgContas.Columns[4].Width = 50;
            dgContas.Columns[4].HeaderText = "STATUS";
            dgContas.Columns[4].DataPropertyName = "Status";

            dgContas.AllowUserToAddRows = false;
            dgContas.AllowUserToDeleteRows = false;
            dgContas.MultiSelect = false;
            dgContas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaGridContas();
        }
    }

   
       
}

