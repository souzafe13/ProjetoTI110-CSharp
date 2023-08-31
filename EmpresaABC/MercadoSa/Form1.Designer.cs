
namespace MercadoSa
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ckbLivro = new System.Windows.Forms.CheckBox();
            this.cbbProdutos = new System.Windows.Forms.ComboBox();
            this.dtpCalendario = new System.Windows.Forms.DateTimePicker();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(57, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(195, 370);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 104);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // ckbLivro
            // 
            this.ckbLivro.AutoSize = true;
            this.ckbLivro.Location = new System.Drawing.Point(231, 54);
            this.ckbLivro.Name = "ckbLivro";
            this.ckbLivro.Size = new System.Drawing.Size(49, 17);
            this.ckbLivro.TabIndex = 3;
            this.ckbLivro.Text = "Livro";
            this.ckbLivro.UseVisualStyleBackColor = true;
            // 
            // cbbProdutos
            // 
            this.cbbProdutos.FormattingEnabled = true;
            this.cbbProdutos.Location = new System.Drawing.Point(309, 184);
            this.cbbProdutos.Name = "cbbProdutos";
            this.cbbProdutos.Size = new System.Drawing.Size(121, 21);
            this.cbbProdutos.TabIndex = 4;
            // 
            // dtpCalendario
            // 
            this.dtpCalendario.Location = new System.Drawing.Point(488, 296);
            this.dtpCalendario.Name = "dtpCalendario";
            this.dtpCalendario.Size = new System.Drawing.Size(264, 20);
            this.dtpCalendario.TabIndex = 5;
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(544, 83);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(120, 95);
            this.lstProdutos.TabIndex = 6;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(381, 353);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 7;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(381, 310);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 8;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.dtpCalendario);
            this.Controls.Add(this.cbbProdutos);
            this.Controls.Add(this.ckbLivro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox ckbLivro;
        private System.Windows.Forms.ComboBox cbbProdutos;
        private System.Windows.Forms.DateTimePicker dtpCalendario;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
    }
}

