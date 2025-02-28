
namespace WinFormsApp1
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            TxtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtSenha = new TextBox();
            BtnLogin = new Button();
            SuspendLayout();
            // 
            // TxtUsuario
            // 
            TxtUsuario.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUsuario.Location = new Point(93, 12);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(100, 22);
            TxtUsuario.TabIndex = 0;
            TxtUsuario.TextChanged += TxtUsuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 16);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 43);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            label2.Click += label2_Click;
            // 
            // TxtSenha
            // 
            TxtSenha.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSenha.Location = new Point(93, 40);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PasswordChar = '°';
            TxtSenha.Size = new Size(100, 22);
            TxtSenha.TabIndex = 5;
            TxtSenha.TextChanged += textBox2_TextChanged_1;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(106, 68);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 23);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 117);
            Controls.Add(BtnLogin);
            Controls.Add(TxtSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox TxtUsuario;
        private Label label1;
        private Label label2;
        private TextBox TxtSenha;
        private Button BtnLogin;
    }
}