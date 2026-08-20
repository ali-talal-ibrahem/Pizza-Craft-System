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
    public partial class Pizza_SelectOrderType : Form
    {
        public Pizza_SelectOrderType()
        {
            InitializeComponent();
        }


        public void btn_ChangeSizeAndFontColor_MouseEnter(Button btn)
        {
            btn.Size = new Size(232, 350);
            btn.ForeColor = Color.Yellow;
        }

        public void btn_ChangeSizeAndFontColor_MouseLeave(Button btn)
        {
            btn.Size = new Size(222, 340);
            btn.ForeColor = Color.White;
        }


        public void DirectionTo(Button btn)
        { 
            if(btn.Name == "btn_Toppings")
            {
                Form ToppingsPage = new Pizza_ChooseToppings();
                ToppingsPage.ShowDialog();
            }
            else if(btn.Name == "btn_ReadyMade")
            {
                Form ReadyMadePage = new Pizza_ChooseYourType();
                ReadyMadePage.ShowDialog();
            }
        }


        private void btn_Choose_MouseEnter(object sender, EventArgs e)
        {
            btn_ChangeSizeAndFontColor_MouseEnter((Button)sender);
        }

        private void btn_Choose_MouseLeave(object sender, EventArgs e)
        {
            btn_ChangeSizeAndFontColor_MouseLeave((Button) sender);
        }

        private void btn_Choose_Click(object sender, EventArgs e)
        {
            DirectionTo((Button) sender);
        }
    }
}
