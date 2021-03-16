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
            this.customerOrder1 = new CustomerOrder.CustomerOrder();
            this.SuspendLayout();
            // 
            // customersComboBox
            // 
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(13, 13);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(242, 24);
            this.customersComboBox.TabIndex = 0;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.customersComboBox_SelectedIndexChanged);
            // 
            // ordersComboBox
            // 
            this.ordersComboBox.FormattingEnabled = true;
            this.ordersComboBox.Location = new System.Drawing.Point(330, 13);
            this.ordersComboBox.Name = "ordersComboBox";
            this.ordersComboBox.Size = new System.Drawing.Size(121, 24);
            this.ordersComboBox.TabIndex = 1;
            this.ordersComboBox.SelectedIndexChanged += new System.EventHandler(this.ordersComboBox_SelectedIndexChanged);
            // 
            // customerOrder1
            // 
            this.customerOrder1.Location = new System.Drawing.Point(13, 44);
            this.customerOrder1.Name = "customerOrder1";
            this.customerOrder1.Size = new System.Drawing.Size(775, 394);
            this.customerOrder1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerOrder1);
            this.Controls.Add(this.ordersComboBox);
            this.Controls.Add(this.customersComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.ComboBox ordersComboBox;
        private CustomerOrder.CustomerOrder customerOrder1;
    }
}

