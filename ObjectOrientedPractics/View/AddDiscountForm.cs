using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    public partial class AddDiscountForm : Form
    {
        private Category _Category;

        public Category Category
        {
            get { return _Category; }
        }
        public AddDiscountForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Category)).Cast<Category>().Skip(1).ToList();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _Category = (Category)comboBox1.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
