namespace ExercEventos
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
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnInstituicoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(136)))), ((int)(((byte)(57)))));
            this.btnEventos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(54)))));
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEventos.Location = new System.Drawing.Point(50, 65);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(139, 56);
            this.btnEventos.TabIndex = 0;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnInstituicoes
            // 
            this.btnInstituicoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(136)))), ((int)(((byte)(57)))));
            this.btnInstituicoes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(54)))));
            this.btnInstituicoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstituicoes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstituicoes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInstituicoes.Location = new System.Drawing.Point(222, 65);
            this.btnInstituicoes.Name = "btnInstituicoes";
            this.btnInstituicoes.Size = new System.Drawing.Size(139, 56);
            this.btnInstituicoes.TabIndex = 1;
            this.btnInstituicoes.Text = "Instituições";
            this.btnInstituicoes.UseVisualStyleBackColor = false;
            this.btnInstituicoes.Click += new System.EventHandler(this.btnInstituicoes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(409, 179);
            this.Controls.Add(this.btnInstituicoes);
            this.Controls.Add(this.btnEventos);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnInstituicoes;
    }
}

