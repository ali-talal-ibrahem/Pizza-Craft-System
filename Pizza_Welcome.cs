using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCraft
{
    public partial class Pizza_Welcome : Form
    {
        public Pizza_Welcome()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Form Start = new Pizza_SelectOrderType();
            Start.ShowDialog();
        }

        private void btn_Start_MouseEnter(object sender, EventArgs e)
        {
            btn_Start.ForeColor = Color.Yellow;
        }

        private void btn_Start_MouseLeave(object sender, EventArgs e)
        {
            btn_Start.ForeColor = Color.White;
        }

        
    }
}
