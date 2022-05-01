namespace eAgendaWinForms.ModuloCompromisso
{
    partial class CadastroCompromisso
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.txtLocalCompromisso = new System.Windows.Forms.TextBox();
            this.txtAssuntoCompromisso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoraTermino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataCompromisso = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listContatosCompromisso = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(587, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 39);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(509, 342);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(72, 39);
            this.btnGravar.TabIndex = 24;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cadastro de Compromisso";
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(47, 241);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.PlaceholderText = "00:00";
            this.txtHoraInicio.Size = new System.Drawing.Size(71, 23);
            this.txtHoraInicio.TabIndex = 21;
            // 
            // txtLocalCompromisso
            // 
            this.txtLocalCompromisso.Location = new System.Drawing.Point(48, 132);
            this.txtLocalCompromisso.Name = "txtLocalCompromisso";
            this.txtLocalCompromisso.Size = new System.Drawing.Size(236, 23);
            this.txtLocalCompromisso.TabIndex = 19;
            // 
            // txtAssuntoCompromisso
            // 
            this.txtAssuntoCompromisso.Location = new System.Drawing.Point(48, 84);
            this.txtAssuntoCompromisso.Name = "txtAssuntoCompromisso";
            this.txtAssuntoCompromisso.Size = new System.Drawing.Size(213, 23);
            this.txtAssuntoCompromisso.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Relacionado com o contato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Local";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Assunto";
            // 
            // txtHoraTermino
            // 
            this.txtHoraTermino.Location = new System.Drawing.Point(143, 241);
            this.txtHoraTermino.Name = "txtHoraTermino";
            this.txtHoraTermino.PlaceholderText = "00:00";
            this.txtHoraTermino.Size = new System.Drawing.Size(71, 23);
            this.txtHoraTermino.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Termino";
            // 
            // txtDataCompromisso
            // 
            this.txtDataCompromisso.Location = new System.Drawing.Point(49, 182);
            this.txtDataCompromisso.MinDate = new System.DateTime(2022, 4, 30, 22, 26, 45, 0);
            this.txtDataCompromisso.Name = "txtDataCompromisso";
            this.txtDataCompromisso.Size = new System.Drawing.Size(235, 23);
            this.txtDataCompromisso.TabIndex = 28;
            this.txtDataCompromisso.Value = new System.DateTime(2022, 4, 30, 22, 26, 45, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listContatosCompromisso);
            this.panel1.Location = new System.Drawing.Point(304, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 259);
            this.panel1.TabIndex = 29;
            // 
            // listContatosCompromisso
            // 
            this.listContatosCompromisso.Dock = System.Windows.Forms.DockStyle.Top;
            this.listContatosCompromisso.FormattingEnabled = true;
            this.listContatosCompromisso.ItemHeight = 15;
            this.listContatosCompromisso.Location = new System.Drawing.Point(0, 0);
            this.listContatosCompromisso.Name = "listContatosCompromisso";
            this.listContatosCompromisso.Size = new System.Drawing.Size(363, 259);
            this.listContatosCompromisso.TabIndex = 0;
            // 
            // CadastroCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 393);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDataCompromisso);
            this.Controls.Add(this.txtHoraTermino);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.txtLocalCompromisso);
            this.Controls.Add(this.txtAssuntoCompromisso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroCompromisso";
            this.Text = "Cadastro de Compromisso";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.TextBox txtLocalCompromisso;
        private System.Windows.Forms.TextBox txtAssuntoCompromisso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoraTermino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtDataCompromisso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listContatosCompromisso;
    }
}