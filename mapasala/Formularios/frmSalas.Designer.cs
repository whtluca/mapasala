﻿
namespace mapasala.Formularios
{
    partial class frmSalas
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeSala = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkLab = new System.Windows.Forms.CheckBox();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numCadeiras = new System.Windows.Forms.NumericUpDown();
            this.numCumputadores = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCumputadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(107, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(37, 20);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome da sala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "N° Computadores";
            // 
            // txtNomeSala
            // 
            this.txtNomeSala.Location = new System.Drawing.Point(150, 36);
            this.txtNomeSala.Name = "txtNomeSala";
            this.txtNomeSala.Size = new System.Drawing.Size(82, 20);
            this.txtNomeSala.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "N° Cadeiras";
            // 
            // chkLab
            // 
            this.chkLab.AutoSize = true;
            this.chkLab.Location = new System.Drawing.Point(437, 36);
            this.chkLab.Name = "chkLab";
            this.chkLab.Size = new System.Drawing.Size(85, 17);
            this.chkLab.TabIndex = 8;
            this.chkLab.Text = "Laoboratório";
            this.chkLab.UseVisualStyleBackColor = true;
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.Location = new System.Drawing.Point(523, 36);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(75, 17);
            this.chkDisponivel.TabIndex = 9;
            this.chkDisponivel.Text = "Disponivel";
            this.chkDisponivel.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(604, 30);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // numCadeiras
            // 
            this.numCadeiras.Location = new System.Drawing.Point(331, 35);
            this.numCadeiras.Name = "numCadeiras";
            this.numCadeiras.Size = new System.Drawing.Size(87, 20);
            this.numCadeiras.TabIndex = 11;
            // 
            // numCumputadores
            // 
            this.numCumputadores.Location = new System.Drawing.Point(238, 36);
            this.numCumputadores.Name = "numCumputadores";
            this.numCumputadores.Size = new System.Drawing.Size(87, 20);
            this.numCumputadores.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 377);
            this.dataGridView1.TabIndex = 13;
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numCumputadores);
            this.Controls.Add(this.numCadeiras);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.chkLab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeSala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Name = "frmSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalas";
            ((System.ComponentModel.ISupportInitialize)(this.numCadeiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCumputadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeSala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkLab;
        private System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numCadeiras;
        private System.Windows.Forms.NumericUpDown numCumputadores;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}