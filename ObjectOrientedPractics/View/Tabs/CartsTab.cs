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
        List<Item> items2 = new List<Item>();
        public CartsTab()
        {
            InitializeComponent();
        }

        private void button_AddToCart_Click(object sender, EventArgs e)
        {
            if (listBox_Items.SelectedIndex != -1)
            {
                textBox_Cart.Text += listBox_Items.SelectedItem.ToString()+ "\r\n";
            }
        }

        

        private void comboBox_Customers_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_Customers.Items.Clear();
            for (int i = 0; i < customers2.Count; i++)
            {
                comboBox_Customers.Items.Add(customers2[i].Fullname);
            }
        }

        private void comboBox_Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            items2.Clear();
            for (int i = 0; i < ItemsTab._items.Count; i++)
            {
                if (ItemsTab._items[i].Cost != 0 && ItemsTab._items[i].CategoryOfItem != 0)
                {
                    items2.Add(ItemsTab._items[i]);
                    
                }
            }
            if (comboBox_Customers.SelectedIndex != -1) 
            {
                listBox_Items.Items.Clear();
                for (int i = 0; i < items2.Count; i++)
                {
                    listBox_Items.Items.Add(items2[i].Name+" price:"+items2[i].Cost.ToString()+"RUB");
                }
                
            }
        }
    }
}
