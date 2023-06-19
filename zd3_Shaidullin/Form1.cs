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
            stallsDataGrid.DataSource = null;
            stallsDataGrid.DataSource = dataList;
            // stallsDataGrid.Columns.Add("Q", "Q");
            // stallsDataGrid.Columns.Add("Qp", "Qp");
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
                dataList.RemoveAt(selectedRow - 1);
                stallsDataGrid.Refresh();
            }
            viewTable();
        }
    }
}