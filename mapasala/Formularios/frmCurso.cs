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
    public partial class frmCurso : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmCurso()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(CursoEntidades).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "Desenvolvimento de sistemas", "manha", true);
            dados.Rows.Add(2, "Itinerario Formativo", "manha", true);
            dados.Rows.Add(3, "Administraçao", "integarl", false);

            dtgridCurso.DataSource = dados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CursoEntidades curso = new CursoEntidades();
            curso.Id = Convert.ToInt32(numId.Text);
            curso.Nome = txtNomeCurso.Text;
            curso.Turno = txtTurno.Text;
            curso.Ativo = chkAtivo.Checked;

            dados.Rows.Add(curso.Linha());

            LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            numId.Value = 0;
            txtNomeCurso.Text = "";
            txtTurno.Text = "";
        }

        private void dtgridCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNomeCurso.Text = dtgridCurso.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtTurno.Text = dtgridCurso.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            numId.Value = Convert.ToInt32(dtgridCurso.Rows[LinhaSelecionada].Cells[0].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtgridCurso.Rows.RemoveAt(LinhaSelecionada);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow minhamae = dtgridCurso.Rows[LinhaSelecionada];
            minhamae.Cells[0].Value = numId.Value;
            minhamae.Cells[1].Value = txtNomeCurso.Text;
            minhamae.Cells[2].Value = txtTurno.Text;
        }
    }
