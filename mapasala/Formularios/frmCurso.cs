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
        BindingSource dados;
        public frmCurso()
        {
            InitializeComponent();
            dados = new BindingSource();
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

            dados.Add(curso);
        }
    }
}
