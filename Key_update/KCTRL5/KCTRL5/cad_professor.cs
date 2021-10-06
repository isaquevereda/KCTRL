using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace KCTRL5
{
    public partial class cad_professor : Form
    {
        public cad_professor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String nome_prof = txtNomeProf.Text;
            String end_prof = txtEnd.Text;
            String cel_prof = txtCel.Text;
            String email_prof = txtEmail.Text;


            if (nome_prof == "" || end_prof == "" || cel_prof == "" ||email_prof=="")
            {
                MessageBox.Show("Você não pode deixar os campos limpos", "ERRO");
                return;
            }

            string configuracao = "Server = localhost; Database = bd4; Uid = root; Pwd =;";
            MySqlConnection conexao = new MySqlConnection(configuracao);

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO cad_professor (nome_prof, end_prof, cel_prof, email_prof)" + " VALUES('" + nome_prof + "', '" + end_prof + "', '" + cel_prof + "', '" + email_prof + "')", conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Professor cadastrado com sucesso");
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar o professor");
            }






        }
    }
}
