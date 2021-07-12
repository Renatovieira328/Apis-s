namespace Apis_s
{
    partial class FrmPagina_inicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmListar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmCadrastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtCep = new System.Windows.Forms.TextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtComplemento = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtLogradouro = new System.Windows.Forms.TextBox();
            this.TxtUF = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmFuncionarios,
            this.TsmRelatorio,
            this.TsmConfiguracoes,
            this.TsmAjuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsmFuncionarios
            // 
            this.TsmFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmListar,
            this.TsmCadrastrar});
            this.TsmFuncionarios.Name = "TsmFuncionarios";
            this.TsmFuncionarios.Size = new System.Drawing.Size(87, 20);
            this.TsmFuncionarios.Text = "&Funcionarios";
            // 
            // TsmListar
            // 
            this.TsmListar.Name = "TsmListar";
            this.TsmListar.Size = new System.Drawing.Size(180, 22);
            this.TsmListar.Text = "&Listar";
            this.TsmListar.Click += new System.EventHandler(this.TsmListar_Click);
            // 
            // TsmCadrastrar
            // 
            this.TsmCadrastrar.Name = "TsmCadrastrar";
            this.TsmCadrastrar.Size = new System.Drawing.Size(180, 22);
            this.TsmCadrastrar.Text = "Ca&drastrar";
            this.TsmCadrastrar.Click += new System.EventHandler(this.TsmCadrastrar_Click);
            // 
            // TsmRelatorio
            // 
            this.TsmRelatorio.Name = "TsmRelatorio";
            this.TsmRelatorio.Size = new System.Drawing.Size(71, 20);
            this.TsmRelatorio.Text = "&Relatorios";
            // 
            // TsmConfiguracoes
            // 
            this.TsmConfiguracoes.Name = "TsmConfiguracoes";
            this.TsmConfiguracoes.Size = new System.Drawing.Size(96, 20);
            this.TsmConfiguracoes.Text = "&Configurações";
            // 
            // TsmAjuda
            // 
            this.TsmAjuda.Name = "TsmAjuda";
            this.TsmAjuda.Size = new System.Drawing.Size(50, 20);
            this.TsmAjuda.Text = "&Ajuda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 149);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endereco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Media de Avaliações";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 5;
            // 
            // TxtCep
            // 
            this.TxtCep.Location = new System.Drawing.Point(225, 100);
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(83, 20);
            this.TxtCep.TabIndex = 6;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(331, 126);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(105, 20);
            this.TxtCidade.TabIndex = 7;
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.Location = new System.Drawing.Point(456, 100);
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(77, 20);
            this.TxtComplemento.TabIndex = 8;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(225, 126);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(100, 20);
            this.TxtBairro.TabIndex = 9;
            // 
            // TxtLogradouro
            // 
            this.TxtLogradouro.Location = new System.Drawing.Point(314, 100);
            this.TxtLogradouro.Name = "TxtLogradouro";
            this.TxtLogradouro.Size = new System.Drawing.Size(136, 20);
            this.TxtLogradouro.TabIndex = 10;
            // 
            // TxtUF
            // 
            this.TxtUF.Location = new System.Drawing.Point(442, 126);
            this.TxtUF.Name = "TxtUF";
            this.TxtUF.Size = new System.Drawing.Size(37, 20);
            this.TxtUF.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 12;
            // 
            // FrmPagina_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 205);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TxtUF);
            this.Controls.Add(this.TxtLogradouro);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtComplemento);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtCep);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmPagina_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem TsmListar;
        private System.Windows.Forms.ToolStripMenuItem TsmCadrastrar;
        private System.Windows.Forms.ToolStripMenuItem TsmRelatorio;
        private System.Windows.Forms.ToolStripMenuItem TsmConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem TsmAjuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtCep;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtComplemento;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtLogradouro;
        private System.Windows.Forms.TextBox TxtUF;
        private System.Windows.Forms.TextBox textBox2;
    }
}