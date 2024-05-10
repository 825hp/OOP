using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.View.Controls;
namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        public static List<Customer> _customers { get; set; }
        private string _fullname;
        private Address _address;
        
        
        public CustomersTab()
        {
            InitializeComponent();
        }
        private void ClearInputs()
        {
            textBox_ID.Text = "";
            textBox_FullName.Text = "";
            
            label_Error.Visible = false;
            _fullname = "";
            addressControl1.ClearTexBox();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox_Customers.SelectedIndex != -1)
                {
                    int index = listBox_Customers.SelectedIndex;
                    try
                    {
                        _customers[index].Fullname = _fullname;
                    }
                    catch
                    {
                        textBox_FullName.BackColor = Color.Red;
                        throw;
                    }
                    try
                    {
                        _address = addressControl1.GetAddress;
                        _customers[index].Address = _address;
                    }
                    catch
                    {
                        
                        throw;
                    }


                    listBox_Customers.Items[index] = _fullname;
                    textBox_FullName.ReadOnly = true;
                    
                    textBox_FullName.BackColor = Color.White;
                    
                }


                else
                {
                    _address = new Address();
                    Customer newCustomer = new Customer("Customer", _address);
                    _customers.Add(newCustomer);
                    newCustomer.Fullname = newCustomer.Fullname + newCustomer.Id.ToString();
                    listBox_Customers.Items.Add(newCustomer.Fullname);
                    
                }
                
                ClearInputs();
                listBox_Customers.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                label_Error.Text = ex.Message;
                label_Error.Visible = true;
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            {
                int index = listBox_Customers.SelectedIndex;
                if (index != -1)
                {
                    _customers.RemoveAt(index);
                    listBox_Customers.Items.RemoveAt(index);
                    ClearInputs();
                    textBox_FullName.BackColor = Color.White;
                    
                    
                }

            }
        }

        private void textBox_FullName_TextChanged(object sender, EventArgs e)
        {
            _fullname = textBox_FullName.Text;
        }

        

        private void listBox_Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Customers.SelectedIndex != -1)
            {
                int index = listBox_Customers.SelectedIndex;

                textBox_FullName.ReadOnly = false;

                addressControl1.SetAddress = _customers[index].Address;
                textBox_ID.Text = _customers[index].Id.ToString();
                textBox_FullName.Text = _customers[index].Fullname;
                
                
                _fullname = textBox_FullName.Text;
                
                
                label_Error.Visible = false;
            }
        }

        private void discountAddButton_Click(object sender, EventArgs e)
        {
            if (listBox_Customers.SelectedIndex != -1)
            {
                var form = new AddDiscountForm();
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int index = listBox_Customers.SelectedIndex;
                    Category category = form.Category;
                    _customers[index].Discounts.Add(new PercentDiscount(category));

                    discountListBox.Items.Clear();
                    for (int i = 0; i < _customers[index].Discounts.Count; i++)
                    {
                        discountListBox.Items.Add(_customers[index].Discounts[i].Info);
                    }


                }
            }
            
        }

        private void removeDiscountButton_Click(object sender, EventArgs e)
        {
            if (listBox_Customers.SelectedIndex != -1)
            {
                if (discountListBox.SelectedIndex != 0)
                {
                    _customers[listBox_Customers.SelectedIndex].Discounts.RemoveAt(discountListBox.SelectedIndex);
                    discountListBox.Items.Clear();
                    for (int i = 0; i < _customers[listBox_Customers.SelectedIndex].Discounts.Count; i++)
                    {
                        discountListBox.Items.Add(_customers[listBox_Customers.SelectedIndex].Discounts[i].Info);
                    }
                }
            }
        }
    }
}
