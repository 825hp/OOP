using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            float columnWidth = tableLayoutPanel1.Width / tableLayoutPanel1.ColumnCount;
            foreach (ColumnStyle style in tableLayoutPanel1.ColumnStyles)
            {
                style.SizeType = SizeType.Absolute; // Установка фиксированного размера для равной ширины
                style.Width = columnWidth; // Установка ширины для каждого столбца
            }
        }

        
    }
}
