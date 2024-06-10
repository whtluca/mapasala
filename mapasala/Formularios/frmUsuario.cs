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
    public partial class frmUsuario : Form
    {
        BindingSource dados;
        public frmUsuario()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtgridUsuarios.DataSource = dados;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioEntidade usuario = new UsuarioEntidade();
            usuario.Id = Convert.ToInt32(numId.Value);
            usuario.Nome = txtNome.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Ativo = chkAtivo.Checked;

            dados.Add(usuario);

        }
    }
}
