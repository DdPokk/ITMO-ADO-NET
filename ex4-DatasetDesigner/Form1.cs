using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4_DatasetDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet NorthwindDataset1 = new NorthwindDataSet();
            NorthwindDataSetTableAdapters.CustomersTableAdapter 
            customersTableAdapter1 = new NorthwindDataSetTableAdapters.CustomersTableAdapter();
            customersTableAdapter1.Fill(NorthwindDataset1.Customers);

            foreach (NorthwindDataSet.CustomersRow NWCustomer in NorthwindDataset1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NWCustomer.CompanyName);
            }
        }
    }
}
