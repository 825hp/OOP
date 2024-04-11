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
        
        public static List<Customer> customers2 { get; set; }
        public static List<Order> orders = new List<Order>();
        private List<Item> itemsInCart = new List<Item>();
        public static List<Item> _items { get; set; }
        private List<Item> items2 = new List<Item>();
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
                itemsInCart.Add(items2[listBox_Items.SelectedIndex]);
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
        public void update_combo()
        {
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
                        listBox_Items.Items.Add(items2[i].Name + " price:" + items2[i].Cost.ToString() + "RUB");
                    }

                }
            }
        }
        public void comboBox_Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_combo();
            clearCart();
        }
        private void clearCart()
        {
            listBox_Cart.Items.Clear();
            itemsInCart.Clear();
            label_Amount.Text = "0 RUB";
        }
        private void buttonClearCart_Click(object sender, EventArgs e)
        {
            clearCart();
        }

        private void button_RemoveItem_Click(object sender, EventArgs e)
        {
            if (listBox_Cart.SelectedIndex != -1)
            {
                itemsInCart.Remove(itemsInCart[listBox_Cart.SelectedIndex]);
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

        private void button_CreateOrder_Click(object sender, EventArgs e)
        {
            if (listBox_Cart.Items.Count!=0)
            {
                
                Order newOrder = new Order();
                
                for (int i = 0; i < itemsInCart.Count; i++)
                {
                    //создаваь новый элемент item
                    Item itemOfCart = itemsInCart[i];
                    newOrder.Cart.Items3.Add(itemOfCart);
                }
                
                newOrder.Date = DateTime.Now;
                newOrder.Address = customers2[comboBox_Customers.SelectedIndex].Address;
                newOrder.OrderStatus = (OrderStatus)0;
                newOrder.Fullname = customers2[comboBox_Customers.SelectedIndex].Fullname;
                string current1 = label_Amount.Text.Trim(new Char[] { 'R', 'U', 'B' });
                double current = Double.Parse(current1);
                newOrder.Cart.Amount = current;
                orders.Add(newOrder);
                
                clearCart();
            }
        }
    }
}
