using model.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mapasala.Formularios
{
    public partial class frmSalas : Form
    {
        BindingSource dados;
        public frmSalas()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtgridSalas.DataSource = dados;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            SalasEntidade salas = new SalasEntidade();
            salas.Id = Convert.ToInt32(txtId.Text);
            salas.Nome = txtNomeSala.Text;
            salas.IsLab = chkLab.Checked;
            salas.NumCadeiras = Convert.ToInt32(txtNumCadeira.Value);
            salas.NumComputadores = Convert.ToInt32(numCumputadores.Value);
            salas.Disponivel = chkDisponivel.Checked;

            dados.Add(salas);
        }
    }
}
