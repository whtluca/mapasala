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
        DataTable dados;
        int LinhaSelecionada;
        public frmDiciplinas()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(DiciplinasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "Matematica", "MAT", true);
            dados.Rows.Add(2, "Português", "PORT", true);
            dados.Rows.Add(3, "Física", "FIS", false);

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

            dados.Rows.Add(diciplinas.Linha());

            LimparCampos();
        }

        private void dtgridDiciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtSigla.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtgridDiciplinas.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtgridDiciplinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNome.Text = dtgridDiciplinas.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtSigla.Text = dtgridDiciplinas.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtId.Text = dtgridDiciplinas.Rows[LinhaSelecionada].Cells[2].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow minhamae = dtgridDiciplinas.Rows[LinhaSelecionada];
            minhamae.Cells[0].Value = txtId.Text;
            minhamae.Cells[1].Value = txtNome.Text;
            minhamae.Cells[2].Value = txtSigla.Text;
        }
    }
}
