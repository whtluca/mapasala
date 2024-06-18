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
    public partial class frmProfessores : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmProfessores()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "Alexandre", "galvani", true);
            dados.Rows.Add(2, "Elisio", "Elisio", true);
            dados.Rows.Add(3, "Eliete", "Eliete", false);

            dtgridProfs.DataSource = dados;
        }

        private void frmProfessores_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade professor = new ProfessoresEntidade();
            professor.Id = Convert.ToInt32(numId.Value);
            professor.Nome = txtNome.Text;
            professor.Apelido = txtApelido.Text;
            professor.Ativo = chkAtivo.Checked;

            dados.Rows.Add(professor.Linha());

            LimparCampos();
        }

        private void dtgridProfs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgridProfs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNome.Text = dtgridProfs.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtApelido.Text = dtgridProfs.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            numId.Value = Convert.ToInt32(dtgridProfs.Rows[LinhaSelecionada].Cells[0].Value)
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            numId.Value = 0;
            txtNome.Text = "";
            txtApelido.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dtgridProfs.Rows.RemoveAt(LinhaSelecionada);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow meupai = dtgridProfs.Rows[LinhaSelecionada];
            meupai.Cells[0].Value = numId.Value;
            meupai.Cells[1].Value = txtNome.Text;
            meupai.Cells[2].Value = txtApelido.Text;
        }
    }
