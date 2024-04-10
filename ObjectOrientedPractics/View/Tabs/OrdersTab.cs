using ObjectOrientedPractics.Model;
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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        public List<Order> orders2 = CartsTab.orders;
        public static List<Customer> Customers { get; set; }
        public OrdersTab()
        {
            InitializeComponent();
        }
        public void addToTable()
        {
            if (orders2.Count != 0)
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < orders2.Count; i++)
                {
                    
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);

                    
                    row.Cells[0].Value = orders2[i].Id;
                    row.Cells[1].Value = orders2[i].OrderStatus;
                    row.Cells[2].Value = orders2[i].Fullname;
                    row.Cells[3].Value = orders2[i].Address.City + ", " + orders2[i].Address.Street + ", " + orders2[i].Address.Building;
                    row.Cells[4].Value = orders2[i].Date;
                    row.Cells[5].Value = orders2[i].Cart.Amount;

                    
                    dataGridView1.Rows.Add(row);
                }
            }
            else
            {
                
                dataGridView1.Rows.Clear();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (orders2.Count-1 >= dataGridView1.CurrentCell.RowIndex)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                textBox_ID.Text = orders2[index].Id.ToString();
                comboBox_Status.Text = orders2[index].OrderStatus.ToString();
                textBoxCreated.Text = orders2[index].Date.ToString();
                addressControl1.SetAddress = orders2[index].Address;
                label_Amount.Text = orders2[index].Cart.Amount.ToString()+"RUB";
                label8.Text = orders2[index].Cart.Items3.Count.ToString();
                for (int i = 0; i < orders2[index].Cart.Items3.Count; i++)
                {
                    
                    listBox_Cart.Items.Add(orders2[index].Cart.Items3[i].Name+ " price:" + orders2[index].Cart.Items3[i].Cost.ToString()+ "RUB");
                }
            }
            
        }
    }
}
