using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zd3_Shaidullin.types;

namespace zd3_Shaidullin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Stall> dataList = new List<Stall>() { };

        private void viewTable()
        {
            stallsDataGrid.AutoGenerateColumns = false;
            stallsDataGrid.Rows.Clear();
            stallsDataGrid.Columns.Add("Column1","Column1");
            stallsDataGrid.Columns.Add("Column2","Column2");
            stallsDataGrid.Columns.Add("Column3","Column3");
            stallsDataGrid.Columns.Add("Column4","Column4");
            stallsDataGrid.Columns.Add("Column5","Column5");
            stallsDataGrid.Columns.Add("Column6","Column6");
            stallsDataGrid.Columns.Add("Column7","Column7");

            foreach (Stall item in dataList)
            {
                int idx = stallsDataGrid.Rows.Add();

                stallsDataGrid.Rows[idx].Cells["Column1"].Value = item.Name;
                stallsDataGrid.Rows[idx].Cells["Column2"].Value = item.Address;
                stallsDataGrid.Rows[idx].Cells["Column3"].Value = item.SalesCount;
                stallsDataGrid.Rows[idx].Cells["Column4"].Value = item.SalesTotal;
                stallsDataGrid.Rows[idx].Cells["Column5"].Value = item.P;
                stallsDataGrid.Rows[idx].Cells["Column6"].Value = item.DaySpProduct;
                stallsDataGrid.Rows[idx].Cells["Column7"].Value = item.HitProduct;

            }

        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            viewTable();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string name = name_box.Text;
            string address = address_box.Text;
            int salesCount = int.Parse(salesCount_box.Text);
            double salesTotal = double.Parse(salesTotal_box.Text);
            int p = int.Parse(p_box.Text);
            string daySpProduct = daySpProduct_box.Text;
            string hitProduct = hitProduct_box.Text;
            
            Stall stall = new Stall(name, address, salesCount, salesTotal, p, daySpProduct, hitProduct);
            dataList.Add(stall);
            viewTable();



        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (stallsDataGrid.SelectedRows.Count > 0)
            {
                int selectedRow = stallsDataGrid.CurrentCell.RowIndex;
                dataList.RemoveAt(selectedRow);
                stallsDataGrid.Refresh();
            }
            viewTable();
        }
    }
}