namespace estudosProvaB2
{
    partial class formLogin
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
            btnEntrar = new Button();
            cbxTermos = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbSenha = new TextBox();
            txbUser = new TextBox();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Poppins SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(160, 188);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // cbxTermos
            // 
            cbxTermos.AutoSize = true;
            cbxTermos.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxTermos.Location = new Point(102, 152);
            cbxTermos.Name = "cbxTermos";
            cbxTermos.Size = new Size(216, 26);
            cbxTermos.TabIndex = 1;
            cbxTermos.Text = "Estou ciente e desejo continuar.";
            cbxTermos.UseVisualStyleBackColor = true;
            cbxTermos.CheckedChanged += cbxTermos_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            label1.Location = new Point(27, 61);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 2;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold);
            label2.Location = new Point(27, 120);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 18);
            label3.Name = "label3";
            label3.Size = new Size(74, 37);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(102, 123);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(233, 23);
            txbSenha.TabIndex = 5;
            // 
            // txbUser
            // 
            txbUser.Location = new Point(102, 64);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(233, 23);
            txbUser.TabIndex = 6;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 279);
            Controls.Add(txbUser);
            Controls.Add(txbSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxTermos);
            Controls.Add(btnEntrar);
            Name = "formLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private CheckBox cbxTermos;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbSenha;
        private TextBox txbUser;
    }
}