using JazzEventProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazzEventProject
{
    public partial class FoodShop : Form
    {
        public FoodShop()
        {
            InitializeComponent();
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            Form frmFoodlist = new FoodLists();
            frmFoodlist.Show();
        }
    }
}
