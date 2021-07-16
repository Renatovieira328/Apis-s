namespace Apis_s
{
    partial class FrmFuncionario_Cadrastro
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
            this.TxtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.TxtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.Senha1 = new System.Windows.Forms.TextBox();
            this.Senha2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirme a Senha";
            // 
            // TxtNomeFuncionario
            // 
            this.TxtNomeFuncionario.Location = new System.Drawing.Point(109, 23);
            this.TxtNomeFuncionario.Name = "TxtNomeFuncionario";
            this.TxtNomeFuncionario.Size = new System.Drawing.Size(100, 20);
            this.TxtNomeFuncionario.TabIndex = 4;
            // 
            // TxtEmailFuncionario
            // 
            this.TxtEmailFuncionario.Location = new System.Drawing.Point(109, 56);
            this.TxtEmailFuncionario.Name = "TxtEmailFuncionario";
            this.TxtEmailFuncionario.Size = new System.Drawing.Size(100, 20);
            this.TxtEmailFuncionario.TabIndex = 5;
            // 
            // Senha1
            // 
            this.Senha1.Location = new System.Drawing.Point(109, 89);
            this.Senha1.Name = "Senha1";
            this.Senha1.Size = new System.Drawing.Size(100, 20);
            this.Senha1.TabIndex = 6;
            // 
            // Senha2
            // 
            this.Senha2.Location = new System.Drawing.Point(109, 122);
            this.Senha2.Name = "Senha2";
            this.Senha2.Size = new System.Drawing.Size(100, 20);
            this.Senha2.TabIndex = 7;
            this.Senha2.TextChanged += new System.EventHandler(this.Senha2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cadrastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmFuncionario_Cadrastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 195);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Senha2);
            this.Controls.Add(this.Senha1);
            this.Controls.Add(this.TxtEmailFuncionario);
            this.Controls.Add(this.TxtNomeFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmFuncionario_Cadrastro";
            this.Text = "FrmFuncionario_Cadrastro";
            this.Load += new System.EventHandler(this.FrmFuncionario_Cadrastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNomeFuncionario;
        private System.Windows.Forms.TextBox TxtEmailFuncionario;
        private System.Windows.Forms.TextBox Senha1;
        private System.Windows.Forms.TextBox Senha2;
        private System.Windows.Forms.Button button2;
    }
}