﻿namespace Carregartabelas
{
    partial class FrmCarregaTabelas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarregaTabelas));
            this.btnclick = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.rdbPosicional = new System.Windows.Forms.RadioButton();
            this.rdbNposisional = new System.Windows.Forms.RadioButton();
            this.cboPatharquivo = new System.Windows.Forms.ComboBox();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtextensao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathArquivo = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.fbdProc = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnclick
            // 
            this.btnclick.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnclick.FlatAppearance.BorderSize = 2;
            this.btnclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclick.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclick.ForeColor = System.Drawing.Color.Red;
            this.btnclick.Location = new System.Drawing.Point(38, 141);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(165, 54);
            this.btnclick.TabIndex = 0;
            this.btnclick.Text = "Clique aqui!!!";
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(35, 77);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(267, 20);
            this.txtArquivo.TabIndex = 1;
            // 
            // rdbPosicional
            // 
            this.rdbPosicional.AutoSize = true;
            this.rdbPosicional.Checked = true;
            this.rdbPosicional.Location = new System.Drawing.Point(208, 141);
            this.rdbPosicional.Name = "rdbPosicional";
            this.rdbPosicional.Size = new System.Drawing.Size(73, 17);
            this.rdbPosicional.TabIndex = 2;
            this.rdbPosicional.TabStop = true;
            this.rdbPosicional.Text = "Posicional";
            this.rdbPosicional.UseVisualStyleBackColor = true;
            // 
            // rdbNposisional
            // 
            this.rdbNposisional.AutoSize = true;
            this.rdbNposisional.Location = new System.Drawing.Point(206, 164);
            this.rdbNposisional.Name = "rdbNposisional";
            this.rdbNposisional.Size = new System.Drawing.Size(96, 17);
            this.rdbNposisional.TabIndex = 3;
            this.rdbNposisional.TabStop = true;
            this.rdbNposisional.Text = "Não Posicional";
            this.rdbNposisional.UseVisualStyleBackColor = true;
            // 
            // cboPatharquivo
            // 
            this.cboPatharquivo.FormattingEnabled = true;
            this.cboPatharquivo.Location = new System.Drawing.Point(35, 37);
            this.cboPatharquivo.Name = "cboPatharquivo";
            this.cboPatharquivo.Size = new System.Drawing.Size(267, 21);
            this.cboPatharquivo.TabIndex = 4;
            this.cboPatharquivo.SelectedIndexChanged += new System.EventHandler(this.cboPatharquivo_SelectedIndexChanged);
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminho.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCaminho.Location = new System.Drawing.Point(35, 20);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(79, 13);
            this.lblCaminho.TabIndex = 5;
            this.lblCaminho.Text = "Path arquivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(35, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tabela Inserida";
            // 
            // txtextensao
            // 
            this.txtextensao.Location = new System.Drawing.Point(38, 115);
            this.txtextensao.Name = "txtextensao";
            this.txtextensao.Size = new System.Drawing.Size(103, 20);
            this.txtextensao.TabIndex = 7;
            this.txtextensao.TextChanged += new System.EventHandler(this.txtextensao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(35, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Extensão";
            // 
            // txtPathArquivo
            // 
            this.txtPathArquivo.Enabled = false;
            this.txtPathArquivo.Location = new System.Drawing.Point(189, 115);
            this.txtPathArquivo.Name = "txtPathArquivo";
            this.txtPathArquivo.Size = new System.Drawing.Size(113, 20);
            this.txtPathArquivo.TabIndex = 9;
            this.txtPathArquivo.TextChanged += new System.EventHandler(this.txtPathArquivo_TextChanged);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.Location = new System.Drawing.Point(308, 32);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(30, 26);
            this.btnProcurar.TabIndex = 9;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // FrmCarregaTabelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 207);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtPathArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtextensao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCaminho);
            this.Controls.Add(this.cboPatharquivo);
            this.Controls.Add(this.rdbNposisional);
            this.Controls.Add(this.rdbPosicional);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btnclick);
            this.Name = "FrmCarregaTabelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrega Tabelas 2020";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.RadioButton rdbPosicional;
        private System.Windows.Forms.RadioButton rdbNposisional;
        private System.Windows.Forms.ComboBox cboPatharquivo;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtextensao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathArquivo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.FolderBrowserDialog fbdProc;
    }
}

