using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KCTRL5.conn
{
    class conexao
    {
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection
                ("Server=localhost;Database=bd4;Uid=root;Pwd=;");


            try
            {
                conn.Open();
            }
            catch (SqlException)
            {
                conn = null;
                MessageBox.Show("Não foi possível estabelecer conexão");
            }
            return conn;
        }


        public static void FecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }

        }

    }
}
