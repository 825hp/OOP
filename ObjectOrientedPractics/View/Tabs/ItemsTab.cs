using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ObjectOrientedPractics.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private string _name;
        private string _info;
        private string _cost;


        public ItemsTab()
        {
            InitializeComponent();
        }
        //private void Add_Click(object sender, EventArgs e)
        //{
        //    Item newItem = new Item("Item", " ", 0);
        //    _items.Add(newItem);
        //    listBox_Items.Items.Add(newItem.Name+newItem.Id.ToString());
        //}

        private void Add_Click(object sender, EventArgs e)
        {

            try
            {
                try
                {
                    if (listBox_Items.SelectedIndex != -1)
                    {
                        float floatValue;
                        if (float.TryParse(_cost, out floatValue))
                        {
                            int index = listBox_Items.SelectedIndex;
                            _items[index].Name = _name;
                            _items[index].Info = _info;
                            _items[index].Cost = floatValue;
                            listBox_Items.Items[index] = _name;
                        }
                        else
                        {
                            throw new Exception("Не удалось преобразовать во float");
                        }

                    }


                    else
                    {
                        Item newItem = new Item("Item", " ", 0);
                        _items.Add(newItem);
                        newItem.Name = newItem.Name + newItem.Id.ToString();
                        listBox_Items.Items.Add(newItem.Name);

                    }
                    ClearInputs();
                    listBox_Items.SelectedIndex = -1;
                }
                catch
                {

                    throw;
                }
            }
            catch (Exception ex)
            {
                label_Error.Text = ex.Message;
                label_Error.Visible = true;
            }
        }
        private void ClearInputs()
        {
            textBox_ID.Text = "";
            textBox_Name.Text = "";
            textBox_Description.Text = "";
            textBox_Cost.Text = "";
            label_Error.Visible = false;
            _name = "";
            _info = "";
            _cost = "";
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            {
                int index = listBox_Items.SelectedIndex;
                if (index != -1)
                {
                    _items.RemoveAt(index);
                    listBox_Items.Items.RemoveAt(index);
                    ClearInputs();
                }

            }
        }

        private void textBox_Cost_TextChanged(object sender, EventArgs e)
        {
            _cost = textBox_Cost.Text;
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            _name = textBox_Name.Text;
        }

        private void textBox_Description_TextChanged(object sender, EventArgs e)
        {
            _info = textBox_Description.Text;
        }

        private void listBox_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Items.SelectedIndex != -1)
            {
                int index = listBox_Items.SelectedIndex;
                textBox_ID.Text = _items[index].Id.ToString();
                textBox_Name.Text = _items[index].Name;
                textBox_Description.Text = _items[index].Info;
                textBox_Cost.Text = _items[index].Cost.ToString();
                _name = textBox_Name.Text;
                _info = textBox_Description.Text;
                _cost = textBox_Cost.Text;
                label_Error.Visible = false;
            }
        }
    }
}

