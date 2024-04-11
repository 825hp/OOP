namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox_Cart = new System.Windows.Forms.ListBox();
            this.buttonClearCart = new System.Windows.Forms.Button();
            this.button_RemoveItem = new System.Windows.Forms.Button();
            this.button_CreateOrder = new System.Windows.Forms.Button();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Customers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AddToCart = new System.Windows.Forms.Button();
            this.listBox_Items = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 530);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox_Cart);
            this.panel3.Controls.Add(this.buttonClearCart);
            this.panel3.Controls.Add(this.button_RemoveItem);
            this.panel3.Controls.Add(this.button_CreateOrder);
            this.panel3.Controls.Add(this.label_Amount);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox_Customers);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(276, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 524);
            this.panel3.TabIndex = 0;
            // 
            // listBox_Cart
            // 
            this.listBox_Cart.FormattingEnabled = true;
            this.listBox_Cart.Location = new System.Drawing.Point(3, 84);
            this.listBox_Cart.Name = "listBox_Cart";
            this.listBox_Cart.Size = new System.Drawing.Size(315, 160);
            this.listBox_Cart.TabIndex = 9;
            // 
            // buttonClearCart
            // 
            this.buttonClearCart.Location = new System.Drawing.Point(220, 294);
            this.buttonClearCart.Name = "buttonClearCart";
            this.buttonClearCart.Size = new System.Drawing.Size(98, 38);
            this.buttonClearCart.TabIndex = 8;
            this.buttonClearCart.Text = "Clear Cart";
            this.buttonClearCart.UseVisualStyleBackColor = true;
            this.buttonClearCart.Click += new System.EventHandler(this.buttonClearCart_Click);
            // 
            // button_RemoveItem
            // 
            this.button_RemoveItem.Location = new System.Drawing.Point(116, 294);
            this.button_RemoveItem.Name = "button_RemoveItem";
            this.button_RemoveItem.Size = new System.Drawing.Size(98, 38);
            this.button_RemoveItem.TabIndex = 7;
            this.button_RemoveItem.Text = "Remove Item";
            this.button_RemoveItem.UseVisualStyleBackColor = true;
            this.button_RemoveItem.Click += new System.EventHandler(this.button_RemoveItem_Click);
            // 
            // button_CreateOrder
            // 
            this.button_CreateOrder.Location = new System.Drawing.Point(3, 294);
            this.button_CreateOrder.Name = "button_CreateOrder";
            this.button_CreateOrder.Size = new System.Drawing.Size(98, 38);
            this.button_CreateOrder.TabIndex = 6;
            this.button_CreateOrder.Text = "Create Order";
            this.button_CreateOrder.UseVisualStyleBackColor = true;
            this.button_CreateOrder.Click += new System.EventHandler(this.button_CreateOrder_Click);
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Amount.Location = new System.Drawing.Point(3, 267);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(68, 24);
            this.label_Amount.TabIndex = 5;
            this.label_Amount.Text = "0 RUB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cart:";
            // 
            // comboBox_Customers
            // 
            this.comboBox_Customers.FormattingEnabled = true;
            this.comboBox_Customers.Location = new System.Drawing.Point(72, 26);
            this.comboBox_Customers.Name = "comboBox_Customers";
            this.comboBox_Customers.Size = new System.Drawing.Size(204, 21);
            this.comboBox_Customers.TabIndex = 1;
            this.comboBox_Customers.SelectedIndexChanged += new System.EventHandler(this.comboBox_Customers_SelectedIndexChanged);
            this.comboBox_Customers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_Customers_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_AddToCart);
            this.panel2.Controls.Add(this.listBox_Items);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 524);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items";
            // 
            // button_AddToCart
            // 
            this.button_AddToCart.Location = new System.Drawing.Point(3, 481);
            this.button_AddToCart.Name = "button_AddToCart";
            this.button_AddToCart.Size = new System.Drawing.Size(98, 38);
            this.button_AddToCart.TabIndex = 1;
            this.button_AddToCart.Text = "Add To Cart";
            this.button_AddToCart.UseVisualStyleBackColor = true;
            this.button_AddToCart.Click += new System.EventHandler(this.button_AddToCart_Click);
            // 
            // listBox_Items
            // 
            this.listBox_Items.FormattingEnabled = true;
            this.listBox_Items.Location = new System.Drawing.Point(3, 29);
            this.listBox_Items.Name = "listBox_Items";
            this.listBox_Items.Size = new System.Drawing.Size(261, 446);
            this.listBox_Items.TabIndex = 0;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(606, 536);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox_Items;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Customers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddToCart;
        private System.Windows.Forms.Button buttonClearCart;
        private System.Windows.Forms.Button button_RemoveItem;
        private System.Windows.Forms.Button button_CreateOrder;
        private System.Windows.Forms.ListBox listBox_Cart;
    }
}
