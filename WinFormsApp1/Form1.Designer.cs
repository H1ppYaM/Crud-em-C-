
namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            Client = new TextBox();
            Tele = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Produto = new ComboBox();
            Valor = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            BtnAtt = new Button();
            BtnDlt = new Button();
            BtnPes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(250, 40);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 0;
            label1.Text = "Cadastros";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 100);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            label2.Click += label2_Click;
            // 
            // Client
            // 
            Client.Location = new Point(187, 96);
            Client.Name = "Client";
            Client.Size = new Size(169, 23);
            Client.TabIndex = 2;
            Client.TextChanged += Client_TextChanged;
            // 
            // Tele
            // 
            Tele.Location = new Point(187, 135);
            Tele.Name = "Tele";
            Tele.Size = new Size(169, 23);
            Tele.TabIndex = 4;
            Tele.TextChanged += Tele_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 139);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 3;
            label3.Text = "Telefone";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(85, 180);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 5;
            label4.Text = "Produto";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(85, 219);
            label5.Name = "label5";
            label5.Size = new Size(48, 19);
            label5.TabIndex = 7;
            label5.Text = "Valor";
            label5.Click += label5_Click;
            // 
            // Produto
            // 
            Produto.FormattingEnabled = true;
            Produto.Items.AddRange(new object[] { "Consumer", "Tarjeta de Crédito", "Point", "Merchant", "CBK" });
            Produto.Location = new Point(187, 176);
            Produto.Name = "Produto";
            Produto.Size = new Size(169, 23);
            Produto.TabIndex = 10;
            Produto.SelectedIndexChanged += Produto_SelectedIndexChanged;
            // 
            // Valor
            // 
            Valor.Location = new Point(187, 215);
            Valor.Name = "Valor";
            Valor.Size = new Size(169, 23);
            Valor.TabIndex = 11;
            Valor.TextChanged += Valor_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(187, 244);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 12;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnIns_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(526, 150);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnAtt
            // 
            BtnAtt.BackColor = Color.Blue;
            BtnAtt.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAtt.ForeColor = SystemColors.Window;
            BtnAtt.Location = new Point(281, 244);
            BtnAtt.Name = "BtnAtt";
            BtnAtt.Size = new Size(75, 32);
            BtnAtt.TabIndex = 14;
            BtnAtt.Text = "Atualizar";
            BtnAtt.UseVisualStyleBackColor = false;
            BtnAtt.Click += BtnAtt_Click;
            // 
            // BtnDlt
            // 
            BtnDlt.BackColor = Color.Blue;
            BtnDlt.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDlt.ForeColor = SystemColors.Window;
            BtnDlt.Location = new Point(480, 244);
            BtnDlt.Name = "BtnDlt";
            BtnDlt.Size = new Size(75, 32);
            BtnDlt.TabIndex = 15;
            BtnDlt.Text = "Deletar";
            BtnDlt.UseVisualStyleBackColor = false;
            BtnDlt.Click += BtnDlt_Click;
            // 
            // BtnPes
            // 
            BtnPes.BackColor = Color.Blue;
            BtnPes.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPes.ForeColor = SystemColors.Window;
            BtnPes.Location = new Point(362, 90);
            BtnPes.Name = "BtnPes";
            BtnPes.Size = new Size(75, 32);
            BtnPes.TabIndex = 16;
            BtnPes.Text = "Pesquisar";
            BtnPes.UseVisualStyleBackColor = false;
            BtnPes.Click += BtnPes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(584, 452);
            Controls.Add(BtnPes);
            Controls.Add(BtnDlt);
            Controls.Add(BtnAtt);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(Valor);
            Controls.Add(Produto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Tele);
            Controls.Add(label3);
            Controls.Add(Client);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PashKiwi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Client;
        private TextBox Tele;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox Produto;
        private TextBox Valor;
        private Button button1;
        private DataGridView dataGridView1;
        private Button BtnAtt;
        private Button BtnDlt;
        private Button BtnPes;
    }
}
