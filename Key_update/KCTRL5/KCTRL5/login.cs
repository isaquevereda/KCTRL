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
using KCTRL5.conn;

namespace KCTRL5
{
    public partial class login : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=bd4; Uid=root; Pwd=;");
        int i;
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // i= 0;
            con.Open();
            
            
            MySqlCommand cmd = new MySqlCommand("SELECT login_user, senha_user FROM cad_user WHERE  login_user=@login_user AND senha_user=@senha_user", con);

            cmd.Parameters.AddWithValue("@login_user", txtLogin.Text);
            cmd.Parameters.AddWithValue("@senha_user", txtSenha.Text);


            MySqlDataReader sdr = cmd.ExecuteReader();
           
            if (sdr.Read())
            {
                MessageBox.Show("Login realizado com sucesso!");
                menu menu = new menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido");
            }
            con.Close();

            // cmd.ExecuteNonQuery();
            // DataTable dt = new DataTable();
            //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //da.Fill(dt);
            //i = Convert.ToInt32(dt.Rows.Count.ToString());

            // if (i==1)
            //{

            //menu menu = new menu();
            //menu.Show();
            //MessageBox.Show("");
            //}
            // else
            //{
            // MessageBox.Show("Usuário ou senha inválido");
            //}


            // con.Close();

        }
    }
}
