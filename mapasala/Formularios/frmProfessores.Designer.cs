
namespace mapasala.Formularios
{
    partial class frmProfessores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntSalvar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgridProfs = new System.Windows.Forms.DataGridView();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridProfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.SuspendLayout();
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(450, 27);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 23);
            this.bntSalvar.TabIndex = 0;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(152, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(258, 30);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(100, 20);
            this.txtApelido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apelido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            // 
            // dtgridProfs
            // 
            this.dtgridProfs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridProfs.Location = new System.Drawing.Point(12, 99);
            this.dtgridProfs.Name = "dtgridProfs";
            this.dtgridProfs.Size = new System.Drawing.Size(776, 339);
            this.dtgridProfs.TabIndex = 7;
            this.dtgridProfs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridProfs_CellClick);
            this.dtgridProfs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridProfs_CellContentClick);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(377, 33);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 8;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(26, 32);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(120, 20);
            this.numId.TabIndex = 9;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(531, 27);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(612, 28);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(693, 29);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.dtgridProfs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.bntSalvar);
            this.Name = "frmProfessores";
            this.Text = "frmProfessores";
            this.Load += new System.EventHandler(this.frmProfessores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridProfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgridProfs;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
    }
}