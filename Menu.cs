using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revisao_da_prova
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_divisao_Click(object sender, EventArgs e)
        {
            Divisao dv = new Divisao(); 
            dv.ShowDialog();
        }

        private void bt_Multi_Click(object sender, EventArgs e)
        {
            Multiplicacao Mt = new Multiplicacao();
            Mt.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if(radioButton1.Checked )
            {
                sexo = radioButton1.Text;
            }else if(radioButton2.Checked )
            {
                sexo = radioButton2.Text;
            }

            MessageBox.Show(sexo);
        }
    }
}
