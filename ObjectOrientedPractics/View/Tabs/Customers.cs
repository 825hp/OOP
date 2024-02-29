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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class Customers : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private string _fullname;
        private string _address;
        
        public Customers()
        {
            InitializeComponent();
        }
        private void ClearInputs()
        {
            textBox_ID.Text = "";
            textBox_FullName.Text = "";
            textBox_Address.Text = "";
            label_Error.Visible = false;
            _fullname = "";
            _address = "";
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
                        _customers[index].Address = _address;
                    }
                    catch
                    {
                        textBox_Address.BackColor = Color.Red;
                        throw;
                    }


                    listBox_Customers.Items[index] = _fullname;
                    textBox_FullName.ReadOnly = true;
                    textBox_Address.ReadOnly = true;
                    textBox_FullName.BackColor = Color.White;
                    textBox_Address.BackColor = Color.White;
                }


                else
                {
                    Customer newCustomer = new Customer("Customer", "Address");
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
                    textBox_Address.BackColor = Color.White;
                    
                }

            }
        }

        private void textBox_FullName_TextChanged(object sender, EventArgs e)
        {
            _fullname = textBox_FullName.Text;
        }

        private void textBox_Address_TextChanged(object sender, EventArgs e)
        {
            _address = textBox_Address.Text;
        }

        private void listBox_Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Customers.SelectedIndex != -1)
            {
                int index = listBox_Customers.SelectedIndex;

                textBox_FullName.ReadOnly = false;
                textBox_Address.ReadOnly = false;

                textBox_ID.Text = _customers[index].Id.ToString();
                textBox_FullName.Text = _customers[index].Fullname;
                textBox_Address.Text = _customers[index].Address;
                
                _fullname = textBox_FullName.Text;
                _address = textBox_Address.Text;
                
                label_Error.Visible = false;
            }
        }
    }
}
