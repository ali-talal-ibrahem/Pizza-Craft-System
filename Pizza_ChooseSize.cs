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
    public partial class Pizza_ChooseSize : Form
    {

        double PizzaPrice = 0;
        double FinalPrice = 0;

        public Pizza_ChooseSize()
        {
            InitializeComponent();
        }

        public Pizza_ChooseSize(double Price)
        {
            InitializeComponent();
            lbl_Middle.ForeColor = Color.OrangeRed;
            this.PizzaPrice = Price;
            this.FinalPrice = Price;
            lbl_Price.Text = PizzaPrice.ToString() + " $";
        }

        public void ChangeColorLabel(TrackBar bar) 
        {
            lbl_Large.ForeColor = Color.SaddleBrown;
            lbl_Middle.ForeColor = Color.SaddleBrown;
            lbl_Small.ForeColor = Color.SaddleBrown;

            if (bar.Value == 2)
            {
                lbl_Large.ForeColor = Color.OrangeRed;
            }
            else if (bar.Value == 1)
            {
                lbl_Middle.ForeColor = Color.OrangeRed;
            }
            else if (bar.Value == 0)
            {
                lbl_Small.ForeColor = Color.OrangeRed;
            }

        }

        public void ChangePicSize(TrackBar bar) 
        {
            pic_Large.Visible = false;
            pic_Middle.Visible = false;
            pic_Small.Visible = false;

            if (bar.Value == 2)
            {
                pic_Large.Visible = true;
            }
            else if (bar.Value == 1)
            {
                pic_Middle.Visible = true;
            }
            else if (bar.Value == 0)
            {
                pic_Small.Visible = true;
            }

        }

        public void ChangePizzaPrice(TrackBar Bar)
        {
            if (Bar.Value == 1)
            {
                FinalPrice = PizzaPrice;
            }
            else if (Bar.Value == 0)
            {
                FinalPrice = PizzaPrice - 1;
            }
            else if (Bar.Value == 2)
            {
                FinalPrice = PizzaPrice + 1;
            }
            lbl_Price.Text = FinalPrice.ToString() + " $";
        }



        public void UpdateSize(TrackBar bar)
        {
            ChangeColorLabel(bar);
            ChangePicSize(bar);
            ChangePizzaPrice(bar);
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateSize((TrackBar)sender);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Form NextChooseThickness = new Pizza_ChooseThickness(FinalPrice);
            NextChooseThickness.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Large_Click(object sender, EventArgs e)
        {

        }
    }
}
