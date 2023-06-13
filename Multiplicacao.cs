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
    public partial class Multiplicacao : Form
    {
        public Multiplicacao()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tx_valor1.Text);
            int b = Convert.ToInt32(tx_valor2.Text);

            int c = a * b;

            MessageBox.Show(c.ToString());
        }
    }
}
