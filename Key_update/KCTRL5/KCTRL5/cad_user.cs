using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCTRL5
{
    public partial class cad_user : Form
    {
        public cad_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome_user = txtNome.Text;
            String login_user = txtLogin.Text;
            String senha_user = txtSenha.Text;


            if (nome_user =="" || login_user =="" || senha_user =="")
            {
                MessageBox.Show("Você não pode deixar os campos limpos", "ERRO");
                return;
            }

            string configuracao = "Server = localhost; Database = bd4; Uid = root; Pwd =;";
            MySqlConnection conexao = new MySqlConnection(configuracao);

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO cad_user (nome_user, login_user, senha_user)" + " VALUES('" + nome_user + "', '" + login_user + "', '" + senha_user + "')", conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso");
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar o usuário");
            }







        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
