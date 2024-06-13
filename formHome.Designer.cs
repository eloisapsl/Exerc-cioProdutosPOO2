namespace estudosProvaB2
{
    partial class formHome
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
            label1 = new Label();
            label2 = new Label();
            btnAdicionar = new Button();
            btnRemover = new Button();
            dgvProdutos = new DataGridView();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(39, 24);
            label1.Name = "label1";
            label1.Size = new Size(242, 22);
            label1.TabIndex = 0;
            label1.Text = "Entre no sistema para realizar ações...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 64);
            label2.Name = "label2";
            label2.Size = new Size(235, 37);
            label2.TabIndex = 1;
            label2.Text = "Estoque de Produtos";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Enabled = false;
            btnAdicionar.Font = new Font("Poppins SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(39, 260);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Enabled = false;
            btnRemover.Font = new Font("Poppins SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(134, 260);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(39, 104);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(476, 150);
            dgvProdutos.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Poppins", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(440, 22);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 306);
            Controls.Add(btnLogin);
            Controls.Add(dgvProdutos);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formHome";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        public Button btnAdicionar;
        public Button btnRemover;
        public DataGridView dgvProdutos;
        public Button btnLogin;
        public Label label1;
    }
}
