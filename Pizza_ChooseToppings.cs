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
    public partial class Pizza_ChooseToppings : Form
    {
        double PizzaPrice = 0;

        public Pizza_ChooseToppings()
        {
            InitializeComponent();
        }

        public void UpdatePizzaPrice()
        {
            PizzaPrice = 0;

            if (chk_AddTomatoes.Checked) PizzaPrice += Convert.ToDouble(chk_AddTomatoes.Tag);
            if (chk_AddPepperoni.Checked) PizzaPrice += Convert.ToDouble(chk_AddPepperoni.Tag);
            if (chk_AddOnion.Checked) PizzaPrice += Convert.ToDouble(chk_AddOnion.Tag);
            if (chk_AddMushroom.Checked) PizzaPrice += Convert.ToDouble(chk_AddMushroom.Tag);
            if (chk_AddOregano.Checked) PizzaPrice += Convert.ToDouble(chk_AddOregano.Tag);
            if (chk_AddChesse.Checked) PizzaPrice += Convert.ToDouble(chk_AddChesse.Tag);

            lbl_Price.Text = PizzaPrice.ToString() + " $";
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePizzaPrice();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Form nextChooseSize = new Pizza_ChooseSize(PizzaPrice);

            nextChooseSize.ShowDialog();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}