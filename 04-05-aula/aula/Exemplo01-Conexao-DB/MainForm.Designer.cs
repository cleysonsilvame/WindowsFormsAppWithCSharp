namespace Exemplo01_Conexao_DB
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxCourses = new System.Windows.Forms.ListBox();
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCadastrarCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxCourses
            // 
            this.lbxCourses.FormattingEnabled = true;
            this.lbxCourses.Location = new System.Drawing.Point(32, 132);
            this.lbxCourses.Name = "lbxCourses";
            this.lbxCourses.Size = new System.Drawing.Size(262, 186);
            this.lbxCourses.TabIndex = 0;
            // 
            // lbxStudents
            // 
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.Location = new System.Drawing.Point(481, 132);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(262, 186);
            this.lbxStudents.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(350, 164);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Consultar";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCadastrarCurso
            // 
            this.btnCadastrarCurso.Location = new System.Drawing.Point(350, 266);
            this.btnCadastrarCurso.Name = "btnCadastrarCurso";
            this.btnCadastrarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCurso.TabIndex = 3;
            this.btnCadastrarCurso.Text = "Cadastrar Curso";
            this.btnCadastrarCurso.UseVisualStyleBackColor = true;
            this.btnCadastrarCurso.Click += new System.EventHandler(this.btnCadastrarCurso_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarCurso);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbxStudents);
            this.Controls.Add(this.lbxCourses);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCourses;
        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCadastrarCurso;
    }
}

