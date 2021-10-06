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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            cad_user cad_user = new cad_user();
            cad_user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();


        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cad_professor cad_professor = new cad_professor();
            cad_professor.Show();
        }
    }
}
