namespace estudosProvaB2
{
    partial class formAdicionar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCadastrar = new Button();
            txbNome = new TextBox();
            txbMarca = new TextBox();
            txbQuant = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 14);
            label1.Name = "label1";
            label1.Size = new Size(210, 37);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            label2.Location = new Point(21, 59);
            label2.Name = "label2";
            label2.Size = new Size(50, 22);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            label3.Location = new Point(21, 115);
            label3.Name = "label3";
            label3.Size = new Size(52, 22);
            label3.TabIndex = 2;
            label3.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold);
            label4.Location = new Point(21, 169);
            label4.Name = "label4";
            label4.Size = new Size(85, 22);
            label4.TabIndex = 3;
            label4.Text = "Quantidade:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Poppins SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(183, 209);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(113, 59);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(237, 23);
            txbNome.TabIndex = 5;
            // 
            // txbMarca
            // 
            txbMarca.Location = new Point(113, 118);
            txbMarca.Name = "txbMarca";
            txbMarca.Size = new Size(237, 23);
            txbMarca.TabIndex = 6;
            // 
            // txbQuant
            // 
            txbQuant.Location = new Point(113, 169);
            txbQuant.Name = "txbQuant";
            txbQuant.Size = new Size(237, 23);
            txbQuant.TabIndex = 7;
            // 
            // formAdicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 264);
            Controls.Add(txbQuant);
            Controls.Add(txbMarca);
            Controls.Add(txbNome);
            Controls.Add(btnCadastrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formAdicionar";
            Text = "Adicionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCadastrar;
        private TextBox txbNome;
        private TextBox txbMarca;
        private TextBox txbQuant;
    }
}