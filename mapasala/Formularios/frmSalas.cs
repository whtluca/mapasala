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
        DataTable dados;
        int LinhaSelecionada;
        public frmSalas()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(SalasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }
            dados.Rows.Add(1, "Maker", 20, 30, true, true);
            dados.Rows.Add(2, "02", 20, 30, true, false);
            dados.Rows.Add(3, "03", 20, 30, false, false);

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
            salas.NumCadeiras = Convert.ToInt32(numCadeira.Value);
            salas.NumComputadores = Convert.ToInt32(numCumputadores.Value);
            salas.Disponivel = chkDisponivel.Checked;




            dados.Rows.Add(salas.Linha());
            LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtId.Text = "";
            txtNomeSala.Text = "";
            numCumputadores.Value = 0;
            numCadeira.Value = 0;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtgridSalas.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtgridSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNomeSala.Text = dtgridSalas.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            numCumputadores.Value = Convert.ToInt32(dtgridSalas.Rows[LinhaSelecionada].Cells[0].Value);
            numCadeira.Value = Convert.ToInt32(dtgridSalas.Rows[LinhaSelecionada].Cells[0].Value);
            txtId.Text = dtgridSalas.Rows[LinhaSelecionada].Cells[1].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow minhamae = dtgridSalas.Rows[LinhaSelecionada];
            minhamae.Cells[0].Value = txtId.Text;
            minhamae.Cells[1].Value = txtNomeSala.Text;
            minhamae.Cells[2].Value = numCumputadores.Value;
            minhamae.Cells[3].Value = numCadeira.Value;
            minhamae.Cells[4].Value = chkLab.Checked;
            minhamae.Cells[5].Value = chkDisponivel.Checked;
        }

        private void chkLab_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}