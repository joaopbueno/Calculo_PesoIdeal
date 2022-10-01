namespace PesoIdeal
{
    partial class Form1
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
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesoIdeal = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(36, 108);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(167, 22);
            this.txtAltura.TabIndex = 0;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(226, 106);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(187, 24);
            this.cmbSexo.TabIndex = 1;
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.cmbSexo_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(36, 47);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(377, 22);
            this.txtNome.TabIndex = 2;
            // 
            // btnPesoIdeal
            // 
            this.btnPesoIdeal.BackColor = System.Drawing.Color.Transparent;
            this.btnPesoIdeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPesoIdeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesoIdeal.Location = new System.Drawing.Point(36, 155);
            this.btnPesoIdeal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesoIdeal.Name = "btnPesoIdeal";
            this.btnPesoIdeal.Size = new System.Drawing.Size(109, 30);
            this.btnPesoIdeal.TabIndex = 3;
            this.btnPesoIdeal.Text = "&Peso Ideal";
            this.btnPesoIdeal.UseVisualStyleBackColor = false;
            this.btnPesoIdeal.Click += new System.EventHandler(this.btnPesoIdeal_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(36, 196);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 30);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(36, 237);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 30);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Altura ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesoIdeal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtAltura);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnPesoIdeal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

