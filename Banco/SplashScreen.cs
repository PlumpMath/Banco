using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_Sair_Click(object sender, EventArgs e)
        {
            DialogResult resposta_log = MessageBox.Show("Deseja Sair?","Exit Royal Bank", MessageBoxButtons.YesNo);
            if (resposta_log == DialogResult.Yes){Application.Exit(); ;}
            else { return; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_Enviar_Click(object sender, EventArgs e)
        {
            int id_log = int.Parse(iden_log.Text);
            string password_log = senha_log.Text;



        }
    }
}
