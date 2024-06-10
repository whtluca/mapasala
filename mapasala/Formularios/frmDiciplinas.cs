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
    public partial class frmDiciplinas : Form
    {
        BindingSource dados;
        public frmDiciplinas()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtgridDiciplinas.DataSource = dados;
        }

        private void frmDiciplinas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DiciplinasEntidade diciplinas = new DiciplinasEntidade();
            diciplinas.Id = Convert.ToInt32(txtId.Text);
            diciplinas.Nome = txtNome.Text;
            diciplinas.Sigla = txtSigla.Text;
            diciplinas.Ativo = chkAtivo.Checked;

            dados.Add(diciplinas);
        }

        private void dtgridDiciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
