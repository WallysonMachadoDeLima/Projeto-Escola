using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace System_Escola.Views
{
    /// <summary>
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nome = txtbox_nome.Text, razao = txtbox_razao.Text, cnpj = txtbox_cnpj.Text, incricaoestadual = txtbox_inscriacaoestadual.Text
                 , tipo = "Privado";

            if ((bool)rd_publico.IsChecked)
                tipo = "Publico";

            var conexao = new MySqlConnection("server=localhost;database=bd_escola;port=3360;user=root;password=root");

            try
            {
                conexao.Open();
                var comando = conexao.CreateCommand();

                comando.CommandText = "INSERT INTO bd_escola.escola (nome_esc, razao_social_esc, cnpj_esc, insc_estatual_esc, tipo_esc, " +
                    "data_criacao_esc, responsavel_esc, telefone_responsavel_esc, email_esc, telefone_esc, rua_esc, numero_esc, bairro_esc, complemento_esc," +
                    " cep_esc, cidade_esc, estado_esc) " +
                    "VALUES " +
                    "(@nome, @razao, @cnpj, @inscricao_est, @tipo, @data_criacao, @responsavel, @telefone_res, @email, @telefone_esc, @rua, @numero, @bairro, " +
                    "@complemento, @cep, @cidade, @estado);";

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@razao", razao);
                comando.Parameters.AddWithValue("@cnpj", cnpj);
                comando.Parameters.AddWithValue("@inscricao_est", incricaoestadual);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@data_criacao", dp_data);
                comando.Parameters.AddWithValue("@responsavel", txt_responsavel);
                comando.Parameters.AddWithValue("@telefone_res", txt_telefoneres);
                comando.Parameters.AddWithValue("@email", txt_email);
                comando.Parameters.AddWithValue("@telefone_esc", txt_telefone);
                comando.Parameters.AddWithValue("@rua", txt_rua);
                comando.Parameters.AddWithValue("@numero", txt_numero);
                comando.Parameters.AddWithValue("@bairro", txt_bairro);
                comando.Parameters.AddWithValue("@complemento", txt_complemento);
                comando.Parameters.AddWithValue("@cep", txt_cep);
                comando.Parameters.AddWithValue("@cidade", txt_cidade);
                comando.Parameters.AddWithValue("@estado", cb_estado);

                var resultado = comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
