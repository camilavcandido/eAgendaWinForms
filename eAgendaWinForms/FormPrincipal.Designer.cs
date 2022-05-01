using System;
namespace eAgendaWinForms
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCompromissos = new System.Windows.Forms.Button();
            this.buttonContatos = new System.Windows.Forms.Button();
            this.buttonTarefas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuTelaTarefas = new System.Windows.Forms.ToolStripButton();
            this.btnMenuTelaContatos = new System.Windows.Forms.ToolStripButton();
            this.btnMenuTelaCompromissos = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.buttonCompromissos);
            this.panel1.Controls.Add(this.buttonContatos);
            this.panel1.Controls.Add(this.buttonTarefas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 366);
            this.panel1.TabIndex = 6;
            // 
            // buttonCompromissos
            // 
            this.buttonCompromissos.BackColor = System.Drawing.Color.Transparent;
            this.buttonCompromissos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCompromissos.FlatAppearance.BorderSize = 2;
            this.buttonCompromissos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonCompromissos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompromissos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCompromissos.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCompromissos.Location = new System.Drawing.Point(511, 235);
            this.buttonCompromissos.Name = "buttonCompromissos";
            this.buttonCompromissos.Size = new System.Drawing.Size(176, 80);
            this.buttonCompromissos.TabIndex = 3;
            this.buttonCompromissos.Text = "Compromissos";
            this.buttonCompromissos.UseVisualStyleBackColor = false;
            this.buttonCompromissos.Click += new System.EventHandler(this.buttonCompromissos_Click);
            // 
            // buttonContatos
            // 
            this.buttonContatos.BackColor = System.Drawing.Color.Transparent;
            this.buttonContatos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonContatos.FlatAppearance.BorderSize = 2;
            this.buttonContatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonContatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContatos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonContatos.ForeColor = System.Drawing.Color.Transparent;
            this.buttonContatos.Location = new System.Drawing.Point(268, 235);
            this.buttonContatos.Name = "buttonContatos";
            this.buttonContatos.Size = new System.Drawing.Size(176, 80);
            this.buttonContatos.TabIndex = 2;
            this.buttonContatos.Text = "Contatos";
            this.buttonContatos.UseVisualStyleBackColor = false;
            this.buttonContatos.Click += new System.EventHandler(this.buttonContatos_Click);
            // 
            // buttonTarefas
            // 
            this.buttonTarefas.BackColor = System.Drawing.Color.Transparent;
            this.buttonTarefas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTarefas.FlatAppearance.BorderSize = 2;
            this.buttonTarefas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTarefas.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTarefas.ForeColor = System.Drawing.Color.Transparent;
            this.buttonTarefas.Location = new System.Drawing.Point(25, 235);
            this.buttonTarefas.Name = "buttonTarefas";
            this.buttonTarefas.Size = new System.Drawing.Size(176, 80);
            this.buttonTarefas.TabIndex = 1;
            this.buttonTarefas.Text = "Tarefas";
            this.buttonTarefas.UseVisualStyleBackColor = false;
            this.buttonTarefas.Click += new System.EventHandler(this.buttonTarefas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(206, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "eAgenda";
            // 
            // btnMenuTelaTarefas
            // 
            this.btnMenuTelaTarefas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMenuTelaTarefas.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuTelaTarefas.Image")));
            this.btnMenuTelaTarefas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenuTelaTarefas.Name = "btnMenuTelaTarefas";
            this.btnMenuTelaTarefas.Size = new System.Drawing.Size(47, 22);
            this.btnMenuTelaTarefas.Text = "Tarefas";
            this.btnMenuTelaTarefas.Click += new System.EventHandler(this.btnMenuTelaTarefas_Click);
            // 
            // btnMenuTelaContatos
            // 
            this.btnMenuTelaContatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMenuTelaContatos.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuTelaContatos.Image")));
            this.btnMenuTelaContatos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenuTelaContatos.Name = "btnMenuTelaContatos";
            this.btnMenuTelaContatos.Size = new System.Drawing.Size(59, 22);
            this.btnMenuTelaContatos.Text = "Contatos";
            this.btnMenuTelaContatos.Click += new System.EventHandler(this.btnMenuTelaContatos_Click);
            // 
            // btnMenuTelaCompromissos
            // 
            this.btnMenuTelaCompromissos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMenuTelaCompromissos.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuTelaCompromissos.Image")));
            this.btnMenuTelaCompromissos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMenuTelaCompromissos.Name = "btnMenuTelaCompromissos";
            this.btnMenuTelaCompromissos.Size = new System.Drawing.Size(91, 22);
            this.btnMenuTelaCompromissos.Text = "Compromissos";
            this.btnMenuTelaCompromissos.Click += new System.EventHandler(this.btnMenuTelaCompromissos_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuTelaTarefas,
            this.btnMenuTelaContatos,
            this.btnMenuTelaCompromissos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(734, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(734, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda 2.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTarefas;
        private System.Windows.Forms.Button buttonCompromissos;
        private System.Windows.Forms.Button buttonContatos;
        private System.Windows.Forms.ToolStripButton btnMenuTelaTarefas;
        private System.Windows.Forms.ToolStripButton btnMenuTelaContatos;
        private System.Windows.Forms.ToolStripButton btnMenuTelaCompromissos;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}
