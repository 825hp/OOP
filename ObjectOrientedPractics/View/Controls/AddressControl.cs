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

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {

        private Address _address;

        public AddressControl()
        {
            InitializeComponent();
            _address = new Address();
        }
        public Address GetAddress
        {
            get
            {
                Address _address1 = new Address();
                try
                {
                    _address1.Index = textBox_Index.Text;
                }
                catch
                {
                    textBox_Index.BackColor = Color.Red;
                    throw;
                }
                try
                {
                    _address1.Country = textBox_Country.Text;
                }
                catch
                {
                    textBox_Country.BackColor = Color.Red;
                    throw;
                }
                try
                {
                    _address1.City = textBox_City.Text;
                }
                catch
                {
                    textBox_City.BackColor = Color.Red;
                    throw;
                }
                try
                {
                    _address1.Street = textBox_Street.Text;
                }
                catch
                {
                    textBox_Street.BackColor = Color.Red;
                    throw;
                }
                try
                {
                    _address1.Building = textBox_Building.Text;
                }
                catch
                {
                    textBox_Building.BackColor = Color.Red;
                    throw;
                }
                try
                {
                    _address1.Apartment = textBox_Apartment.Text;
                }
                catch
                {
                    textBox_Apartment.BackColor = Color.Red;
                    throw;
                }
                return _address1;
            }

        }

        public Address SetAddress
        {
            set
            {
                _address = value;
                UpdateUI();
            }
        }



        private void UpdateUI()
        {
            textBox_Index.Text = _address.Index;
            textBox_Country.Text = _address.Country;
            textBox_City.Text = _address.City;
            textBox_Street.Text = _address.Street;
            textBox_Building.Text = _address.Building;
            textBox_Apartment.Text = _address.Apartment;
        }
        public void ClearTexBox()
        {
            textBox_Index.BackColor = Color.White;
            textBox_Country.BackColor = Color.White;
            textBox_City.BackColor = Color.White;
            textBox_Street.BackColor = Color.White;
            textBox_Building.BackColor = Color.White;
            textBox_Apartment.BackColor = Color.White;
            textBox_Index.Text = "";
            textBox_Country.Text = "";
            textBox_City.Text = "";
            textBox_Street.Text = "";
            textBox_Building.Text = "";
            textBox_Apartment.Text = "";
            
        }
    }
}
