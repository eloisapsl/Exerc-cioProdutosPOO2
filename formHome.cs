using System.Data;
using System.Data.SqlClient;

namespace estudosProvaB2
{
    public partial class formHome : Form
    {
        public List<Produto> listaProdutos;
        public SqlConnection conexao;
        public formHome()
        {
            InitializeComponent();
            listaProdutos = new List<Produto>();

            conexao = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=novodb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            AtualizarLista();

         

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin(this);
            login.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            formAdicionar add = new formAdicionar(this);
            add.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int selecionado = dgvProdutos.SelectedRows[0].Index;
            string produtoNome = listaProdutos[selecionado].nome;

            var deletar = conexao.CreateCommand();
            deletar.CommandText = "DELETE FROM Produto WHERE Nome = @nome ;";

            var paramId = new SqlParameter("nome", produtoNome);

            deletar.Parameters.Add(paramId);

            deletar.ExecuteNonQuery();
            MessageBox.Show("Produto deletado do banco!");

            listaProdutos.RemoveAt(selecionado);

            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = listaProdutos;
            dgvProdutos.Refresh();
        }

        public void AtualizarLista()
        {
            try
            {
                conexao.Open();
                var comando = conexao.CreateCommand();
                comando.CommandText = "SELECT * FROM Produto;";

                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    Produto p = new Produto();  
                    p.nome = Convert.ToString(leitor["Nome"]);
                    p.marca = Convert.ToString(leitor["Marca"]);
                    p.quantidade = Convert.ToString(leitor["Quantidade"]);

                    listaProdutos.Add(p);
                }

                leitor.Close();

                MessageBox.Show("Lista atualizada com o banco.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lista não foi atualizada com o banco!");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
