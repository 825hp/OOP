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


namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private string _name;
        private string _info;
        private string _cost;
        private Category _category;

        public ItemsTab()
        {
            InitializeComponent();
            foreach (Category c in Enum.GetValues(typeof(Category)))
            {
                comboBox_Category.Items.Add(c);
            }
        }
        

        private void Add_Click(object sender, EventArgs e)
        {

            try
            {
                if (listBox_Items.SelectedIndex != -1)
                {

                    float floatValue;

                    if (float.TryParse(_cost, out floatValue))
                    {

                        int index = listBox_Items.SelectedIndex;
                        _items[index].CategoryOfItem = _category;
                        try
                        {
                            _items[index].Name = _name;
                        }
                        catch
                        {
                            textBox_Name.BackColor = Color.Red;
                            throw;
                        }
                        try
                        {
                            _items[index].Info = _info;
                        }
                        catch
                        {
                            textBox_Description.BackColor = Color.Red;
                            throw;
                        }
                        try
                        {
                            _items[index].Cost = floatValue;
                        }
                        catch
                        {
                            textBox_Cost.BackColor = Color.Red;
                            throw;
                        }
                        
                        listBox_Items.Items[index] = _name;
                        textBox_Cost.ReadOnly = true;
                        textBox_Name.ReadOnly = true;
                        textBox_Description.ReadOnly = true;
                        comboBox_Category.BackColor = Color.White;
                        comboBox_Category.SelectedIndex = -1;
                        comboBox_Category.Text = "";
                        textBox_Cost.BackColor = Color.White;
                        textBox_Name.BackColor = Color.White;
                        textBox_Description.BackColor = Color.White;
                    }
                    else
                    {
                        textBox_Cost.BackColor = Color.Red;
                        throw new Exception("Не удалось преобразовать во float");
                    }

                }


                else
                {
                    Item newItem = new Item("Item", "Your description", 0, Category.None);
                    _items.Add(newItem);
                    newItem.Name = newItem.Name + newItem.Id.ToString();
                    listBox_Items.Items.Add(newItem.Name);
                }
                ClearInputs();
                listBox_Items.SelectedIndex = -1;
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
                    textBox_Cost.BackColor = Color.White;
                    textBox_Name.BackColor = Color.White;
                    textBox_Description.BackColor = Color.White;
                    comboBox_Category.BackColor = Color.White;
                    comboBox_Category.SelectedIndex = -1;
                    comboBox_Category.Text = "";
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
                
                if (_items[index].Cost == 0)
                {
                    textBox_Cost.BackColor = Color.Red;
                }
                if (_items[index].CategoryOfItem == Category.None)
                {
                    comboBox_Category.BackColor = Color.Red;
                }
                textBox_Cost.ReadOnly = false;
                textBox_Name.ReadOnly = false;
                textBox_Description.ReadOnly = false;

                comboBox_Category.Text = _items[index].CategoryOfItem.ToString();
                textBox_ID.Text = _items[index].Id.ToString();
                textBox_Name.Text = _items[index].Name;
                textBox_Description.Text = _items[index].Info;
                textBox_Cost.Text = _items[index].Cost.ToString();
                _category = _items[index].CategoryOfItem;
                _name = textBox_Name.Text;
                _info = textBox_Description.Text;
                _cost = textBox_Cost.Text;
                label_Error.Visible = false;
            }
        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Category.SelectedIndex != -1)
            {
                int index = comboBox_Category.SelectedIndex;
                _category = (Category)comboBox_Category.Items[index];
            }
        }
    }
}

