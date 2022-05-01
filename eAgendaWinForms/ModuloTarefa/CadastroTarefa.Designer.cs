namespace eAgendaWinForms.ModuloTarefa
{
    partial class CadastroTarefa
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtnBaixa = new System.Windows.Forms.RadioButton();
            this.radioBtnMedia = new System.Windows.Forms.RadioButton();
            this.radioBtnAlta = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(79, 27);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(61, 23);
            this.txtNumero.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(69, 70);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(352, 23);
            this.txtTitulo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Título:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(386, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 39);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(281, 175);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(72, 39);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prioridade:";
            // 
            // radioBtnBaixa
            // 
            this.radioBtnBaixa.AutoSize = true;
            this.radioBtnBaixa.Checked = true;
            this.radioBtnBaixa.Location = new System.Drawing.Point(3, 3);
            this.radioBtnBaixa.Name = "radioBtnBaixa";
            this.radioBtnBaixa.Size = new System.Drawing.Size(53, 19);
            this.radioBtnBaixa.TabIndex = 0;
            this.radioBtnBaixa.TabStop = true;
            this.radioBtnBaixa.Text = "Baixa";
            this.radioBtnBaixa.UseVisualStyleBackColor = true;
            // 
            // radioBtnMedia
            // 
            this.radioBtnMedia.AutoSize = true;
            this.radioBtnMedia.Location = new System.Drawing.Point(3, 28);
            this.radioBtnMedia.Name = "radioBtnMedia";
            this.radioBtnMedia.Size = new System.Drawing.Size(58, 19);
            this.radioBtnMedia.TabIndex = 1;
            this.radioBtnMedia.Text = "Média";
            this.radioBtnMedia.UseVisualStyleBackColor = true;
            // 
            // radioBtnAlta
            // 
            this.radioBtnAlta.AutoSize = true;
            this.radioBtnAlta.Location = new System.Drawing.Point(3, 53);
            this.radioBtnAlta.Name = "radioBtnAlta";
            this.radioBtnAlta.Size = new System.Drawing.Size(46, 19);
            this.radioBtnAlta.TabIndex = 2;
            this.radioBtnAlta.Text = "Alta";
            this.radioBtnAlta.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtnAlta);
            this.panel1.Controls.Add(this.radioBtnMedia);
            this.panel1.Controls.Add(this.radioBtnBaixa);
            this.panel1.Location = new System.Drawing.Point(19, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 84);
            this.panel1.TabIndex = 13;
            // 
            // CadastroTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 226);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "CadastroTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroTarefa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBtnBaixa;
        private System.Windows.Forms.RadioButton radioBtnMedia;
        private System.Windows.Forms.RadioButton radioBtnAlta;
        private System.Windows.Forms.Panel panel1;
    }
}