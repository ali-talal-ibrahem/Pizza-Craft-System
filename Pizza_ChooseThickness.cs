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

        public Pizza_ChooseThickness()
        {
            InitializeComponent();
        }

        public Pizza_ChooseThickness(double Price)
        {
            InitializeComponent();
            this.PizzaPrice = Price;
        }

    }
}
