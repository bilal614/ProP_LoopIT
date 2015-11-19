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
    public partial class MaterialList : Form
    {
        ItemDataHelper ItemData = new ItemDataHelper();
        public MaterialList()
        {
            InitializeComponent();
        }

        private void MaterialList_Load(object sender, EventArgs e)
        {
            List<Items> items = ItemData.GetAllMaterials();
            foreach (var i in items)
            {
                Material m = (Material)i;
                DataGridViewRow newrow = new DataGridViewRow();
                newrow.CreateCells(dataGridViewMaterials);
                newrow.Cells[0].Value = m.ID;
                newrow.Cells[1].Value = m.Name;
                newrow.Cells[2].Value = m.Price;
                newrow.Cells[3].Value = m.DepositAmount;
                newrow.Cells[4].Value = m.Quantity;
                newrow.Cells[5].Value = m.Description;
                dataGridViewMaterials.Rows.Add(newrow);
            }
        }
    }
}
