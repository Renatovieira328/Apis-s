namespace Apis_s
{
    partial class FrmCadrastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.TxtEmailEmpresa = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtTelefoneEmpresa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MaskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha";
            // 
            // TxtNomeEmpresa
            // 
            this.TxtNomeEmpresa.Location = new System.Drawing.Point(142, 24);
            this.TxtNomeEmpresa.Name = "TxtNomeEmpresa";
            this.TxtNomeEmpresa.Size = new System.Drawing.Size(100, 20);
            this.TxtNomeEmpresa.TabIndex = 6;
            // 
            // TxtEmailEmpresa
            // 
            this.TxtEmailEmpresa.Location = new System.Drawing.Point(142, 111);
            this.TxtEmailEmpresa.Name = "TxtEmailEmpresa";
            this.TxtEmailEmpresa.Size = new System.Drawing.Size(100, 20);
            this.TxtEmailEmpresa.TabIndex = 7;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(142, 209);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(100, 20);
            this.TxtSenha.TabIndex = 10;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // TxtTelefoneEmpresa
            // 
            this.TxtTelefoneEmpresa.Location = new System.Drawing.Point(142, 62);
            this.TxtTelefoneEmpresa.Name = "TxtTelefoneEmpresa";
            this.TxtTelefoneEmpresa.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefoneEmpresa.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cadratar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaskCNPJ
            // 
            this.MaskCNPJ.Location = new System.Drawing.Point(142, 163);
            this.MaskCNPJ.Name = "MaskCNPJ";
            this.MaskCNPJ.Size = new System.Drawing.Size(100, 20);
            this.MaskCNPJ.TabIndex = 13;
            // 
            // FrmCadrastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaskCNPJ);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtTelefoneEmpresa);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtEmailEmpresa);
            this.Controls.Add(this.TxtNomeEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadrastro";
            this.Text = "FrmCadrastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNomeEmpresa;
        private System.Windows.Forms.TextBox TxtEmailEmpresa;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtTelefoneEmpresa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox MaskCNPJ;
    }
}