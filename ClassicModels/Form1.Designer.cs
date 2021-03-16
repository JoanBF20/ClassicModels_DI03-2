namespace ClassicModels
{
    partial class Form1
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
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.ordersComboBox = new System.Windows.Forms.ComboBox();
            this.totalTitle = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.customerOrder1 = new CustomerOrder.CustomerOrder();
            this.customerTitle = new System.Windows.Forms.Label();
            this.orderNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customersComboBox
            // 
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(115, 21);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(242, 24);
            this.customersComboBox.TabIndex = 0;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.customersComboBox_SelectedIndexChanged);
            // 
            // ordersComboBox
            // 
            this.ordersComboBox.FormattingEnabled = true;
            this.ordersComboBox.Location = new System.Drawing.Point(645, 21);
            this.ordersComboBox.Name = "ordersComboBox";
            this.ordersComboBox.Size = new System.Drawing.Size(121, 24);
            this.ordersComboBox.TabIndex = 1;
            this.ordersComboBox.SelectedIndexChanged += new System.EventHandler(this.ordersComboBox_SelectedIndexChanged);
            // 
            // totalTitle
            // 
            this.totalTitle.AutoSize = true;
            this.totalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTitle.Location = new System.Drawing.Point(594, 473);
            this.totalTitle.Name = "totalTitle";
            this.totalTitle.Size = new System.Drawing.Size(50, 17);
            this.totalTitle.TabIndex = 3;
            this.totalTitle.Text = "Total:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(642, 473);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(35, 17);
            this.total.TabIndex = 4;
            this.total.Text = "total";
            // 
            // customerOrder1
            // 
            this.customerOrder1.AutoScroll = true;
            this.customerOrder1.Location = new System.Drawing.Point(13, 52);
            this.customerOrder1.Name = "customerOrder1";
            this.customerOrder1.Size = new System.Drawing.Size(775, 414);
            this.customerOrder1.TabIndex = 2;
            // 
            // customerTitle
            // 
            this.customerTitle.AutoSize = true;
            this.customerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTitle.Location = new System.Drawing.Point(30, 24);
            this.customerTitle.Name = "customerTitle";
            this.customerTitle.Size = new System.Drawing.Size(81, 17);
            this.customerTitle.TabIndex = 5;
            this.customerTitle.Text = "Customer:";
            // 
            // orderNumber
            // 
            this.orderNumber.AutoSize = true;
            this.orderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumber.Location = new System.Drawing.Point(521, 24);
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Size = new System.Drawing.Size(116, 17);
            this.orderNumber.TabIndex = 6;
            this.orderNumber.Text = "Order Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.orderNumber);
            this.Controls.Add(this.customerTitle);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalTitle);
            this.Controls.Add(this.customerOrder1);
            this.Controls.Add(this.ordersComboBox);
            this.Controls.Add(this.customersComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Customer Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.ComboBox ordersComboBox;
        private CustomerOrder.CustomerOrder customerOrder1;
        private System.Windows.Forms.Label totalTitle;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label customerTitle;
        private System.Windows.Forms.Label orderNumber;
    }
}

