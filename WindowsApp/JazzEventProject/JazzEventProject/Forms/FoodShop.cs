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
        InvoiceDataHelper InvoiceData = new InvoiceDataHelper();
        List<Items> ListOfSoldFood = new List<Items>();
        List<Items> ListOFFoods = new List<Items>();
        decimal subtotal = 0;


        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            Form frmFoodlist = new FoodList();
            frmFoodlist.Show();
        }

        private void FoodShop_Load(object sender, EventArgs e)
        {
            tbCurrentDate.Text = DateTime.Now.ToString("d/M/yyyy");
            ListOFFoods = ItemData.GetAllFoods();
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
                Items selectedItem = null;
                if(ItemData.CheckUniqueItem(ListOfSoldFood,id) == true)
                {
                    selectedItem = ItemData.GetAFood(id, ListOFFoods);
                    ItemData.SellFood(selectedItem.ID, quantity, ListOFFoods);
                    ListOfSoldFood.Add(selectedItem); 
                }
                else
                {
                    selectedItem = ItemData.GetAFood(id, ListOfSoldFood);
                    ItemData.SellFood(selectedItem.ID, quantity,ListOfSoldFood);
                }
                subtotal += selectedItem.Price * quantity;
                //Add row into the datagridview
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(dataGridViewFood);
                newrow.Cells[0].Value = selectedItem.ID;
                newrow.Cells[1].Value = selectedItem.Name;
                newrow.Cells[2].Value = quantity;
                newrow.Cells[3].Value = selectedItem.Price;
                newrow.Cells[4].Value = selectedItem.Price * quantity;
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

        /// <summary>
        /// Update table F_Invoice, Food_Invoice
        /// Update food instances in list of sold items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Update the quantity of sold food in database
            foreach (var f in ListOfSoldFood)
            {
                int i = ItemData.UpdateAFood(f.ID,ListOfSoldFood);
            }

            int foodID = InvoiceData.GenerateInvoiceID();
            string soldDate = (DateTime.Now).ToString("dd-MM-yyyy");
            int AccountID = 1; // This one will be provide by RFID after the scaning functionality completed

            int nbofInvoice = InvoiceData.AddAFoodInvoice(foodID, soldDate, AccountID);
            MessageBox.Show(nbofInvoice.ToString());
        }

       

       
       
    }
}
