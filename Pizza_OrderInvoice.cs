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
    public partial class Pizza_OrderInvoice : Form
    {

        double PizzaPrice = 0;

        public Pizza_OrderInvoice()
        {
            InitializeComponent();
        }

        public Pizza_OrderInvoice(double Price)
        {
            InitializeComponent();
            this.PizzaPrice = Price;
            lbl_Price.Text = PizzaPrice.ToString() + " $";
        }

        private void btn_DoneOrder_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show(
        "Are you sure about paying for the order ?",
        "Payment confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );


            if (confirmResult == DialogResult.Yes)
            {

                MessageBox.Show(
                    "The transaction was completed successfully and the amount paid was : " + PizzaPrice.ToString() + " $",
                    "Payment made",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
        }

        private void btn_CancelOrder_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel the order and return to the main page ?",
                "Order Cancellation Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );


            if (result == DialogResult.Yes)
            {
                Pizza_SelectOrderType mainForm = null;

                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is Pizza_SelectOrderType)
                    {
                        mainForm = (Pizza_SelectOrderType)openForm;
                        break;
                    }
                }

                if (mainForm != null)
                {
                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    Pizza_SelectOrderType newMainForm = new Pizza_SelectOrderType();
                    newMainForm.Show();
                    this.Close();
                }
            }
        }
    }
}
