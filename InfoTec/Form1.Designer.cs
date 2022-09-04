namespace InfoTec
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
            this.NovoProduto = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.LabelPreco = new System.Windows.Forms.Label();
            this.LabelQtd = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.preco = new System.Windows.Forms.TextBox();
            this.qtd = new System.Windows.Forms.NumericUpDown();
            this.cadastroBtn = new System.Windows.Forms.Button();
            this.LabelDescricao = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.TextBox();
            this.LabelConfig = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qtd)).BeginInit();
            this.SuspendLayout();
            // 
            // NovoProduto
            // 
            this.NovoProduto.AutoSize = true;
            this.NovoProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.NovoProduto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoProduto.Location = new System.Drawing.Point(73, 38);
            this.NovoProduto.Name = "NovoProduto";
            this.NovoProduto.Size = new System.Drawing.Size(191, 32);
            this.NovoProduto.TabIndex = 0;
            this.NovoProduto.Text = "Novo Produto";
            this.NovoProduto.Click += new System.EventHandler(this.NovoProduto_Click);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNome.Location = new System.Drawing.Point(43, 116);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(52, 17);
            this.LabelNome.TabIndex = 1;
            this.LabelNome.Text = "Nome:";
            this.LabelNome.Click += new System.EventHandler(this.LabelNome_Click);
            // 
            // LabelPreco
            // 
            this.LabelPreco.AutoSize = true;
            this.LabelPreco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPreco.Location = new System.Drawing.Point(43, 345);
            this.LabelPreco.Name = "LabelPreco";
            this.LabelPreco.Size = new System.Drawing.Size(49, 17);
            this.LabelPreco.TabIndex = 2;
            this.LabelPreco.Text = "Preço:";
            this.LabelPreco.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelQtd
            // 
            this.LabelQtd.AutoSize = true;
            this.LabelQtd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQtd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelQtd.Location = new System.Drawing.Point(43, 400);
            this.LabelQtd.Name = "LabelQtd";
            this.LabelQtd.Size = new System.Drawing.Size(91, 17);
            this.LabelQtd.TabIndex = 3;
            this.LabelQtd.Text = "Quantidade:";
            this.LabelQtd.Click += new System.EventHandler(this.label3_Click);
            // 
            // nome
            // 
            this.nome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(46, 136);
            this.nome.MaxLength = 50;
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(235, 21);
            this.nome.TabIndex = 4;
            // 
            // preco
            // 
            this.preco.AutoCompleteCustomSource.AddRange(new string[] {
            "R$"});
            this.preco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preco.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preco.Location = new System.Drawing.Point(46, 365);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(73, 21);
            this.preco.TabIndex = 5;
            this.preco.TextChanged += new System.EventHandler(this.modeloProd_TextChanged);
            // 
            // qtd
            // 
            this.qtd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.qtd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.qtd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(46, 420);
            this.qtd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(73, 21);
            this.qtd.TabIndex = 6;
            this.qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qtd.ValueChanged += new System.EventHandler(this.qntdProd_ValueChanged);
            // 
            // cadastroBtn
            // 
            this.cadastroBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.cadastroBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastroBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroBtn.ForeColor = System.Drawing.Color.White;
            this.cadastroBtn.Location = new System.Drawing.Point(79, 477);
            this.cadastroBtn.Name = "cadastroBtn";
            this.cadastroBtn.Size = new System.Drawing.Size(180, 45);
            this.cadastroBtn.TabIndex = 7;
            this.cadastroBtn.Text = "Cadastrar";
            this.cadastroBtn.UseVisualStyleBackColor = false;
            this.cadastroBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelDescricao
            // 
            this.LabelDescricao.AutoSize = true;
            this.LabelDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescricao.Location = new System.Drawing.Point(43, 253);
            this.LabelDescricao.Name = "LabelDescricao";
            this.LabelDescricao.Size = new System.Drawing.Size(76, 17);
            this.LabelDescricao.TabIndex = 8;
            this.LabelDescricao.Text = "Descrição:";
            this.LabelDescricao.Click += new System.EventHandler(this.label1_Click);
            // 
            // descricao
            // 
            this.descricao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.descricao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Location = new System.Drawing.Point(46, 273);
            this.descricao.MaxLength = 255;
            this.descricao.Multiline = true;
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(235, 56);
            this.descricao.TabIndex = 9;
            // 
            // LabelConfig
            // 
            this.LabelConfig.AutoSize = true;
            this.LabelConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConfig.Location = new System.Drawing.Point(43, 172);
            this.LabelConfig.Name = "LabelConfig";
            this.LabelConfig.Size = new System.Drawing.Size(156, 17);
            this.LabelConfig.TabIndex = 10;
            this.LabelConfig.Text = "Configuração técnica:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(46, 193);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 43);
            this.textBox1.TabIndex = 11;
            // 
            // aviso
            // 
            this.aviso.AutoSize = true;
            this.aviso.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aviso.ForeColor = System.Drawing.Color.Red;
            this.aviso.Location = new System.Drawing.Point(43, 91);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(210, 16);
            this.aviso.TabIndex = 12;
            this.aviso.Text = "Por favor, preencha todos os campos";
            this.aviso.Visible = false;
            this.aviso.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 561);
            this.Controls.Add(this.aviso);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelConfig);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.LabelDescricao);
            this.Controls.Add(this.cadastroBtn);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.LabelQtd);
            this.Controls.Add(this.LabelPreco);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.NovoProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "TelaCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.qtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NovoProduto;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Label LabelPreco;
        private System.Windows.Forms.Label LabelQtd;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox preco;
        private System.Windows.Forms.NumericUpDown qtd;
        private System.Windows.Forms.Button cadastroBtn;
        private System.Windows.Forms.Label LabelDescricao;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label LabelConfig;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label aviso;
    }
}

