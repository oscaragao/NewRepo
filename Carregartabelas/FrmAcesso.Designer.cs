namespace Carregartabelas
{
    partial class FrmAcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcesso));
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCatalago = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnEntra = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.Location = new System.Drawing.Point(2, 28);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(43, 13);
            this.lblBanco.TabIndex = 4;
            this.lblBanco.Text = "Banco";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(2, 50);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário";
            // 
            // txtCatalago
            // 
            this.txtCatalago.Location = new System.Drawing.Point(83, 21);
            this.txtCatalago.MaxLength = 30;
            this.txtCatalago.Name = "txtCatalago";
            this.txtCatalago.Size = new System.Drawing.Size(198, 20);
            this.txtCatalago.TabIndex = 1;
            this.txtCatalago.TextChanged += new System.EventHandler(this.txtCatalago_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(83, 47);
            this.txtUser.MaxLength = 15;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(198, 20);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // btnEntra
            // 
            this.btnEntra.Image = ((System.Drawing.Image)(resources.GetObject("btnEntra.Image")));
            this.btnEntra.Location = new System.Drawing.Point(293, 21);
            this.btnEntra.Name = "btnEntra";
            this.btnEntra.Size = new System.Drawing.Size(48, 46);
            this.btnEntra.TabIndex = 3;
            this.btnEntra.UseVisualStyleBackColor = true;
            this.btnEntra.Click += new System.EventHandler(this.btnEntra_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(89, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTexto.Location = new System.Drawing.Point(12, 82);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(246, 17);
            this.lblTexto.TabIndex = 7;
            this.lblTexto.Text = "** O Banco de Dados usando o SQL SERVER.";
            this.lblTexto.UseCompatibleTextRendering = true;
            this.lblTexto.Click += new System.EventHandler(this.lblTexto_Click);
            // 
            // FrmAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 110);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEntra);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtCatalago);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblBanco);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCatalago;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnEntra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTexto;
    }
}