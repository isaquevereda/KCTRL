using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using KCTRL5.conn;
using KCTRL5.classes;


namespace KCTRL5.classes
{
    class devolver
    {
        public int id_reserva;
        public string res_user_id;
        public string res_prof_id;
        public string res_key_id;
        public string res_retirada;
        public string res_devol;



        public DataTable Dados(string query)
        {
            MySqlConnection conn = conexao.obterConexao();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dtList = new DataTable();
                adp.Fill(dtList);

                conexao.FecharConexao();
                return dtList;

            }
            catch (Exception e)
            {
                throw e;
            }
        }







        public static void devolverChave(devolver devolver)
        {
            try
            {
                MySqlConnection conn = conexao.obterConexao();
                String query = "UPDATE cad_reserva SET res_devol=@DEVOL  WHERE res_retirada=@RETIRADA";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DEVOL", devolver.res_devol);
                cmd.ExecuteNonQuery();
                conexao.FecharConexao();


            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

























    }
}
