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
    public partial class Pizza_ChooseYourType : Form
    {

        double PizzaPrice = 0;

        public Pizza_ChooseYourType()
        {
            InitializeComponent();
        }

        private void Pizza_ChooseYourType_Load(object sender, EventArgs e)
        {
            PizzaPrice = Convert.ToDouble(btn_Margherita.Tag);
            btn_Margherita.ForeColor = Color.Yellow;
            lbl_Price.Text = PizzaPrice.ToString() + " $";
        }

        public void btn_ChangeSize_MouseEnter(Button btn)
        {
            btn.Size = new Size(227, 46);
        }

        public void btn_ChangeSize_MouseLeave(Button btn)
        {
            btn.Size = new Size(222, 41);
        }

        private void ResetPizzaButtonsColor()
        {
            btn_Margherita.ForeColor = Color.White;
            btn_Chicken.ForeColor = Color.White;
            btn_Pepperoni.ForeColor = Color.White;
            btn_FourCheese.ForeColor = Color.White;
            btn_SupremeMeat.ForeColor = Color.White;
            btn_SupremeVeggie.ForeColor = Color.White;
        }

        public void ChangePhotoPizzaAndFontColor(Button btn)
        {

            ResetPizzaButtonsColor();

            btn.ForeColor = Color.Yellow;

            switch (btn.Name)
            {
                case "btn_Margherita":
                    pic_Pizza.BackgroundImage = Properties.Resources.MargheritaPizza;
                    break;
                case "btn_Chicken":
                    pic_Pizza.BackgroundImage = Properties.Resources.ChickenPizza;
                    break;
                case "btn_Pepperoni":
                    pic_Pizza.BackgroundImage = Properties.Resources.PepperoniPizza;
                    break;
                case "btn_FourCheese":
                    pic_Pizza.BackgroundImage = Properties.Resources.FourCheesePizza;
                    break;
                case "btn_SupremeMeat":
                    pic_Pizza.BackgroundImage = Properties.Resources.SupremeMeatPizza;
                    break;
                case "btn_SupremeVeggie":
                    pic_Pizza.BackgroundImage = Properties.Resources.VeggieSupremePizza;
                    break;
            }

        }

        public void UpdatePizzaPrice(Button btn)
        {
            switch (btn.Name)
            {
                case "btn_Margherita":
                    PizzaPrice = Convert.ToDouble(btn.Tag);
                    break;
                case "btn_Chicken":
                    PizzaPrice = Convert.ToDouble(btn.Tag);
                    break;
                case "btn_Pepperoni":
                    PizzaPrice = Convert.ToDouble(btn.Tag);
                    break;
                case "btn_FourCheese":
                    PizzaPrice = Convert.ToDouble(btn.Tag);
                    break;
                case "btn_SupremeMeat":
                    PizzaPrice = Convert.ToDouble(btn.Tag);
                    break;
                case "btn_SupremeVeggie":
                    PizzaPrice = Convert.ToDouble(btn.Tag);
                    break;
            }

            lbl_Price.Text = PizzaPrice.ToString() + " $ ";

        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            btn_ChangeSize_MouseEnter((Button)sender);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            btn_ChangeSize_MouseLeave((Button)sender);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ChangePhotoPizzaAndFontColor((Button)sender);
            UpdatePizzaPrice((Button)sender);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Form SizePage = new Pizza_ChooseSize();
            SizePage.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
