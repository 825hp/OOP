using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;
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
    public partial class MainForm : Form
    {
        private Store _store;
        public MainForm()
        {
            InitializeComponent();
            _store = new Store();


            CustomersTab._customers = _store.Customers;
            CartsTab.customers2 = _store.Customers;
            ItemsTab._items = _store.Items;
            CartsTab._items = _store.Items;
            OrdersTab.Customers = _store.Customers;
            
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            cartsTab1.update_combo();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            ordersTab1.addToTable();
        }
    }
}
