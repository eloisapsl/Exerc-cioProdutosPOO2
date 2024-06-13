﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudosProvaB2
{
    public partial class formAdicionar : Form
    {
        public formHome origem;
        public formAdicionar(formHome origem)
        {
            InitializeComponent();
            this.origem = origem;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int proxID = origem.listaProdutos.Count + 1;
            Produto novo = new Produto( txbNome.Text, txbMarca.Text, txbQuant.Text);

            var inserir = origem.conexao.CreateCommand();
            inserir.CommandText = "INSERT INTO Produto (Nome, Marca, Quantidade)" + "VALUES (@nome, @marca, @quantidade)";

            var paramNome = new SqlParameter("nome", novo.nome);
            var paramMarca = new SqlParameter("marca", novo.marca);
            var paramQuant = new SqlParameter("quantidade", novo.quantidade);

            inserir.Parameters.Add(paramNome);
            inserir.Parameters.Add(paramMarca);
            inserir.Parameters.Add(paramQuant);

            inserir.ExecuteNonQuery();
            Console.WriteLine("Produto inserido no banco!");

            origem.listaProdutos.Add(novo);

            origem.dgvProdutos.DataSource = null;
            origem.dgvProdutos.DataSource = origem.listaProdutos;
            origem.dgvProdutos.Refresh();

            this.Close();

        }
    }
}
