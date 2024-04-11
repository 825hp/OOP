namespace ObjectOrientedPractics.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cartsTab1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(866, 734);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Carts";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // cartsTab1
            // 
            this.cartsTab1.Location = new System.Drawing.Point(3, 6);
            this.cartsTab1.Name = "cartsTab1";
            this.cartsTab1.Size = new System.Drawing.Size(606, 536);
            this.cartsTab1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.customersTab1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 734);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            this.customersTab1.Location = new System.Drawing.Point(3, 3);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.Size = new System.Drawing.Size(752, 635);
            this.customersTab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.itemsTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 734);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Items = null;
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(757, 742);
            this.itemsTab1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 760);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ordersTab1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(866, 734);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Orders";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // ordersTab1
            // 
            this.ordersTab1.Location = new System.Drawing.Point(3, 3);
            this.ordersTab1.Name = "ordersTab1";
            this.ordersTab1.Size = new System.Drawing.Size(853, 542);
            this.ordersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 763);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage3;
        private Tabs.CartsTab cartsTab1;
        private System.Windows.Forms.TabPage tabPage2;
        private Tabs.CustomersTab customersTab1;
        private System.Windows.Forms.TabPage tabPage1;
        private Tabs.ItemsTab itemsTab1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private Tabs.OrdersTab ordersTab1;
    }
}