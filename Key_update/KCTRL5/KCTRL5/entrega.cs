using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KCTRL5.classes;
using MySql.Data.MySqlClient;

namespace KCTRL5
{


    public partial class entrega : Form
    {
        public string _strConn = "Server = localhost; Database = bd4; Uid = root; Pwd =;";
        MySqlConnection objConect = null;
        MySqlCommand ObjCommand = null;





        public entrega()
        {
            InitializeComponent();
        }

        public void listaGrid()
        {
            //string configuracao = "Server = localhost; Database = bd4; Uid = root; Pwd =;";
            //MySqlConnection conexao = new MySqlConnection(configuracao);

            string strSQL = "SELECT res_key_id as Sala, res_prof_id as Professor, res_retirada as Retirada, res_devol as Devolução FROM cad_reserva";

            objConect = new MySqlConnection(_strConn);
            ObjCommand = new MySqlCommand(strSQL, objConect); 

            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(ObjCommand);
                DataTable dtLista = new DataTable();
                objAdp.Fill(dtLista);
                 
                dgDados.DataSource = dtLista;

                
                //MySqlCommand comando = new MySqlCommand("SELECT * from cad_reserva)", conexao);
                //comando.ExecuteNonQuery();


            }
            catch
            {
                MessageBox.Show("Erro ao consultar");

            }

        }



        //public entrega(String Valor)
        //{
        //   InitializeComponent();
        //     label4.Text = Valor;
        //   }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void entrega_Load(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = ("Server = localhost; Database = bd4; Uid = root; Pwd =;");
            cn.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = cn;
            com.CommandText = "SELECT nome_prof FROM cad_professor";
            MySqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cmbProfessor.DisplayMember = "nome_prof";
            cmbProfessor.DataSource = dt;




            MySqlConnection cn2 = new MySqlConnection();
            cn2.ConnectionString = ("Server = localhost; Database = bd4; Uid = root; Pwd =;");
            cn2.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn2;
            comm.CommandText = "SELECT key_desc FROM cad_key";
            MySqlDataReader drr = comm.ExecuteReader();
            DataTable dtt = new DataTable();
            dtt.Load(drr);
            cmbKey.DisplayMember = "key_desc";
            cmbKey.DataSource = dtt;



            MySqlConnection cn3 = new MySqlConnection();
            cn3.ConnectionString = ("Server = localhost; Database = bd4; Uid = root; Pwd =;");
            cn3.Open();
            MySqlCommand commm = new MySqlCommand();
            commm.Connection = cn3;
            commm.CommandText = "SELECT nome_user FROM cad_user";
            MySqlDataReader drrr = commm.ExecuteReader();
            DataTable dttt = new DataTable();
            dttt.Load(drrr);

            listaGrid();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRet.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtDev.Text = DateTime.Now.ToString();



            //  try
            //{
            //devolver devolver = new devolver();
            //  devolver.res_retirada = txtRet.Text;


            //DialogResult resultado = MessageBox.Show("Confirmar a devolução desse chave", "Confirmar Devoluçao", MessageBoxButtons.YesNo,
            //  MessageBoxIcon.Question);
            //if (resultado == DialogResult.Yes)
            //{
            //devolver.devolverChave(devolver);
            //  MessageBox.Show(devolver.res_retirada + "Chave devolvida com sucesso");
            //}
            //else
            //{
            //  MessageBox.Show("Chave não devolvida");
            //  }

            //}
            //catch (MySqlException ex)
            //{
            //throw ex;
                
            //}
        








    }

    private void button3_Click(object sender, EventArgs e)
        {

        
            //int res_user_id = txtNome.Text;
            String res_key_id = cmbKey.Text;
            String res_prof_id = cmbProfessor.Text;
            String res_retirada = txtRet.Text;
            String res_devol = txtDev.Text;





                if (res_key_id == "" || res_prof_id == "" || res_retirada == "")
            {
                MessageBox.Show("Você não pode deixar os campos limpos", "ERRO");
                return;
            }

            string configuracao = "Server = localhost; Database = bd4; Uid = root; Pwd =;";
            MySqlConnection conexao = new MySqlConnection(configuracao);

            

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO cad_reserva (res_prof_id, res_key_id, res_retirada, res_devol)" + " VALUES('" + res_prof_id + "', '" + res_key_id + "', '" + res_retirada + "', '" + res_devol + "')", conexao);
                comando.ExecuteNonQuery();
                //MySqlDataAdapter da = new MySqlDataAdapter();

               // DataTable dt = new DataTable();
                //da.Fill(dt);
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                  //  cmbKey.Items.Add(dt.Rows[i][res_key_id]);
                //}


                MessageBox.Show("Reserva feita com sucesso");
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao reservar");
            }


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            string configuracao = "Server = localhost; Database = bd4; Uid = root; Pwd =;";
            MySqlConnection conexao = new MySqlConnection(configuracao);

            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("SELECT cad_reserva.res_prof_id, cad_key.key_desc from cad_reserva inner join cad_key on cad_reserva.res_key_id = cad_key.key_id )", conexao);
                comando.ExecuteNonQuery();
                //MessageBox.Show("Usuário cadastrado com sucesso");
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao consultar");
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtRet_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            listaGrid();

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            listaGrid();
        }
    }
}
