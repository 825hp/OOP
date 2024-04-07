using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;


namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {


        List<Customer> customers2 = CustomersTab._customers;
        public CartsTab()
        {
            InitializeComponent();
            
        }

        private void button_AddToCart_Click(object sender, EventArgs e)
        {
            
        }

        

        private void comboBox_Customers_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_Customers.Items.Clear();
            for (int i = 0; i < customers2.Count; i++)
            {
                comboBox_Customers.Items.Add(customers2[i].Fullname);
            }
        }
    }
}
