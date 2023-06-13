﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revisao_da_prova
{
    public partial class Divisao : Form
    {
        public Divisao()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tx_valor1.Text);
                int b = Convert.ToInt32(tx_valor2.Text);

                int c = a / b;

                lb_resultado.Text = c.ToString();
                //MessageBox.Show(c.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao dividir");
            }   
            finally
            {
                MessageBox.Show("Vai executar da mesma forma");
            }

        }
    }
}
