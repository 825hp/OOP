namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.textBoxCreated = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Cart = new System.Windows.Forms.ListBox();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grid_id_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_status_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_name_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_date_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_PRTime = new System.Windows.Forms.TextBox();
            this.textBox_PRDate = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_PRDate);
            this.panel1.Controls.Add(this.textBox_PRTime);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBox_Status);
            this.panel1.Controls.Add(this.textBoxCreated);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBox_Cart);
            this.panel1.Controls.Add(this.label_Amount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addressControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 536);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Location = new System.Drawing.Point(470, 73);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Status.TabIndex = 19;
            this.comboBox_Status.SelectedIndexChanged += new System.EventHandler(this.comboBox_Status_SelectedIndexChanged);
            // 
            // textBoxCreated
            // 
            this.textBoxCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreated.Location = new System.Drawing.Point(470, 50);
            this.textBoxCreated.Name = "textBoxCreated";
            this.textBoxCreated.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreated.TabIndex = 18;
            // 
            // textBox_ID
            // 
            this.textBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ID.Location = new System.Drawing.Point(470, 28);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Created:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(405, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Order";
            // 
            // listBox_Cart
            // 
            this.listBox_Cart.FormattingEnabled = true;
            this.listBox_Cart.Location = new System.Drawing.Point(402, 296);
            this.listBox_Cart.Name = "listBox_Cart";
            this.listBox_Cart.Size = new System.Drawing.Size(315, 160);
            this.listBox_Cart.TabIndex = 13;
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Amount.Location = new System.Drawing.Point(405, 479);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(68, 24);
            this.label_Amount.TabIndex = 12;
            this.label_Amount.Text = "0 RUB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(405, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(405, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Order Items:";
            // 
            // addressControl1
            // 
            this.addressControl1.Location = new System.Drawing.Point(401, 150);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(398, 127);
            this.addressControl1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 530);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_id_order,
            this.grid_status_order,
            this.grid_name_customer,
            this.grid_address,
            this.grid_date_order,
            this.grid_amount});
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(384, 510);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // grid_id_order
            // 
            this.grid_id_order.HeaderText = "ID";
            this.grid_id_order.Name = "grid_id_order";
            this.grid_id_order.ReadOnly = true;
            // 
            // grid_status_order
            // 
            this.grid_status_order.HeaderText = "OrderStatus";
            this.grid_status_order.Name = "grid_status_order";
            this.grid_status_order.ReadOnly = true;
            // 
            // grid_name_customer
            // 
            this.grid_name_customer.HeaderText = "Customer Full Name";
            this.grid_name_customer.Name = "grid_name_customer";
            this.grid_name_customer.ReadOnly = true;
            // 
            // grid_address
            // 
            this.grid_address.HeaderText = "Delivery Addres";
            this.grid_address.Name = "grid_address";
            this.grid_address.ReadOnly = true;
            // 
            // grid_date_order
            // 
            this.grid_date_order.HeaderText = "Created";
            this.grid_date_order.Name = "grid_date_order";
            this.grid_date_order.ReadOnly = true;
            // 
            // grid_amount
            // 
            this.grid_amount.HeaderText = "Amount";
            this.grid_amount.Name = "grid_amount";
            this.grid_amount.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(610, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Priority Options";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(610, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Date:";
            // 
            // textBox_PRTime
            // 
            this.textBox_PRTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_PRTime.Location = new System.Drawing.Point(649, 28);
            this.textBox_PRTime.Name = "textBox_PRTime";
            this.textBox_PRTime.Size = new System.Drawing.Size(100, 20);
            this.textBox_PRTime.TabIndex = 21;
            // 
            // textBox_PRDate
            // 
            this.textBox_PRDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_PRDate.Location = new System.Drawing.Point(649, 50);
            this.textBox_PRDate.Name = "textBox_PRDate";
            this.textBox_PRDate.Size = new System.Drawing.Size(100, 20);
            this.textBox_PRDate.TabIndex = 22;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(808, 542);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Controls.AddressControl addressControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox_Cart;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCreated;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_id_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_status_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_name_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_date_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_amount;
        private System.Windows.Forms.TextBox textBox_PRDate;
        private System.Windows.Forms.TextBox textBox_PRTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
