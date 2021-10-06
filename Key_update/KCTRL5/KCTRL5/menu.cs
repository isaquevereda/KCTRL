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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            entrega entrega = new entrega();
            entrega.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cad_professor cad_professor = new cad_professor();
            cad_professor.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
