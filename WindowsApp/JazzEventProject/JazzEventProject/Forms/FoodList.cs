using JazzEventProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazzEventProject.Forms
{
    public partial class FoodList : Form
    {
        public FoodList()
        {
            InitializeComponent();
        }
        ItemDataHelper itemData = new ItemDataHelper();
        private void FoodLists_Load(object sender, EventArgs e)
        {
            List<Items> listofFood = itemData.GetAllFoods();
            dataGridViewFoodList.DataSource = listofFood;
        }
    }
}
