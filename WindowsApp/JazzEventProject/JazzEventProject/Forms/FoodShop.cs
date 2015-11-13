using JazzEventProject.Classes;
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

        //Variables declaration 
        ItemDataHelper ItemData = new ItemDataHelper();
        List<Items> ListOfSoldFood = new List<Items>();
        decimal subtotal = 0;


        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            Form frmFoodlist = new FoodList();
            frmFoodlist.Show();
        }

        private void FoodShop_Load(object sender, EventArgs e)
        {
            tbCurrentDate.Text = DateTime.Now.ToString("d/M/yyyy");
        }


        /// <summary>
        /// This catches the press enter key event and add the selected item to the gridview
        /// Update the quantity of selected food 
        /// Added the selected food into the list of sold foods. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbQuantity_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int id = Convert.ToInt32(tbFoodID.Text);
                int quantity = Convert.ToInt32(tbQuantity.Text);
                ItemData.SellFood(id, quantity);
               
                Items  selectedITem = ItemData.GetAFood(id);
                if(ItemData.CheckUniqueItem(ListOfSoldFood,id) == true)
                {
                    ListOfSoldFood.Add(selectedITem);
                }
                else
                {
                    foreach(var tempItem in ListOfSoldFood)
                    {
                        if(tempItem.ID == selectedITem.ID)
                        {
                            ItemData.SellFood(tempItem.ID, quantity);
                        }
                    }
                }
                ListOfSoldFood.Add(selectedITem);
                subtotal += selectedITem.Price * quantity;
                //Add row into the datagridview
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(dataGridViewFood);
                newrow.Cells[0].Value = selectedITem.ID;
                newrow.Cells[1].Value = selectedITem.Name;
                newrow.Cells[2].Value = quantity;
                newrow.Cells[3].Value = selectedITem.Price;
                newrow.Cells[4].Value = selectedITem.Price * quantity;
                dataGridViewFood.Rows.Add(newrow);

                UpdateToTal();
            }

        }

        /// <summary>
        /// Update the total and subtotal showing on form
        /// </summary>
        private void UpdateToTal()
        {
            decimal VAT = subtotal * (decimal)0.21;
            lbSubTotal.Text = "€ " + subtotal.ToString();
            lbVAT.Text = "€ " + VAT.ToString("#.##");
            lbTotal.Text = "€" + (subtotal + VAT).ToString("#.##");
        }


        //Refresh textboxes
        private void tbFoodID_Enter(object sender, EventArgs e)
        {
            tbFoodID.Text = "";
        }

        private void tbQuantity_Enter(object sender, EventArgs e)
        {
            tbQuantity.Text = "";
        }

       

       
       
    }
}
