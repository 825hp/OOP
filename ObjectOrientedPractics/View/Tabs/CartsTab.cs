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
using static System.Net.Mime.MediaTypeNames;


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
                //textBox_Cart.Text += listBox_Items.SelectedItem.ToString()+ "\r\n";
                listBox_Cart.Items.Add(listBox_Items.SelectedItem);
                label_Amount.Text = label_Amount.Text.Trim(new Char[] { 'R', 'U', 'B' });
                double current = Double.Parse(label_Amount.Text)+ Double.Parse(items2[listBox_Items.SelectedIndex].Cost.ToString());
                label_Amount.Text = current.ToString()+" RUB";

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

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            listBox_Cart.Items.Clear();
            label_Amount.Text = "0 RUB";
        }

        private void button_RemoveItem_Click(object sender, EventArgs e)
        {
            if (listBox_Cart.SelectedIndex != -1)
            {
                string text = listBox_Cart.Items[listBox_Cart.SelectedIndex].ToString();
                int indexOfSpace = text.IndexOf(' ');
                string textAfterSpace = text.Substring(indexOfSpace + 1);
                double cost1;
                double.TryParse(string.Join("", textAfterSpace.Where(c => char.IsDigit(c))), out cost1);
                
                label_Amount.Text = label_Amount.Text.Trim(new Char[] { 'R', 'U', 'B' });
                double current = Double.Parse(label_Amount.Text) - cost1;
                label_Amount.Text = current.ToString() + " RUB";
                listBox_Cart.Items.Remove(listBox_Cart.Items[listBox_Cart.SelectedIndex]);
                
            }
        }
    }
}
