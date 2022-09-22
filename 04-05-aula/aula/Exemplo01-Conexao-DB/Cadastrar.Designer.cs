namespace Exemplo01_Conexao_DB
{
    partial class Cadastrar
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
            this.lblAbrev = new System.Windows.Forms.Label();
            this.txtAbrev = new System.Windows.Forms.TextBox();
            this.lblNomeCurso = new System.Windows.Forms.Label();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAbrev
            // 
            this.lblAbrev.AutoSize = true;
            this.lblAbrev.Location = new System.Drawing.Point(220, 111);
            this.lblAbrev.Name = "lblAbrev";
            this.lblAbrev.Size = new System.Drawing.Size(61, 13);
            this.lblAbrev.TabIndex = 0;
            this.lblAbrev.Text = "Abreviatura";
            // 
            // txtAbrev
            // 
            this.txtAbrev.Location = new System.Drawing.Point(363, 111);
            this.txtAbrev.Name = "txtAbrev";
            this.txtAbrev.Size = new System.Drawing.Size(100, 20);
            this.txtAbrev.TabIndex = 1;
            // 
            // lblNomeCurso
            // 
            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.Location = new System.Drawing.Point(220, 160);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(80, 13);
            this.lblNomeCurso.TabIndex = 2;
            this.lblNomeCurso.Text = "Nome do Curso";
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(363, 160);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCurso.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(388, 225);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.lblNomeCurso);
            this.Controls.Add(this.txtAbrev);
            this.Controls.Add(this.lblAbrev);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbrev;
        private System.Windows.Forms.TextBox txtAbrev;
        private System.Windows.Forms.Label lblNomeCurso;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Button btnAdicionar;
    }
}