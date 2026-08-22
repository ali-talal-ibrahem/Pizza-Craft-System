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
    public partial class Pizza_ChooseThickness : Form
    {

        double PizzaPrice = 0;
        double FinalPrice = 0;

        public Pizza_ChooseThickness()
        {
            InitializeComponent();
        }

        public Pizza_ChooseThickness(double Price)
        {
            InitializeComponent();
            this.PizzaPrice = Price;
            this.FinalPrice = Price;
            lbl_Thin.ForeColor = Color.OrangeRed;
            lbl_Price.Text = PizzaPrice.ToString() + " $";
        }


        public void ChangeColorLabel(Button btn)
        {
            lbl_Thin.ForeColor = Color.SaddleBrown;
            lbl_Thick.ForeColor = Color.SaddleBrown;

            if (btn.Name == "btn_Thin")
            {
                lbl_Thin.ForeColor = Color.OrangeRed;
            }
            else if (btn.Name == "btn_Thick")
            {
                lbl_Thick.ForeColor = Color.OrangeRed;
            }
 
        }

        public void ChangePizzaPrice(Button btn)
        {
            if (btn.Name == "btn_Thin")
            {
                FinalPrice = PizzaPrice;
            }
            else if (btn.Name == "btn_Thick")
            {
                FinalPrice = PizzaPrice + 1;
            }
            lbl_Price.Text = FinalPrice.ToString() + " $";
        }


        public void UpdateThickness(Button btn)
        {
            ChangeColorLabel(btn);
            ChangePizzaPrice(btn);

        }

        private void btn_Click(object sender, EventArgs e)
        {
            UpdateThickness((Button)sender);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Form InvoiceForm = new Pizza_OrderInvoice();
            InvoiceForm.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
