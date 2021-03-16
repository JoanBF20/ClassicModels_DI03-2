namespace CustomerOrder
{
    partial class CustomerOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderNumber = new System.Windows.Forms.Label();
            this.orderDateTitle = new System.Windows.Forms.Label();
            this.requiredDateTitle = new System.Windows.Forms.Label();
            this.shippedDateTitle = new System.Windows.Forms.Label();
            this.statusTitle = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.Label();
            this.requiredDate = new System.Windows.Forms.Label();
            this.shippedDate = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // orderNumber
            // 
            this.orderNumber.AutoSize = true;
            this.orderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumber.Location = new System.Drawing.Point(13, 14);
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Size = new System.Drawing.Size(118, 20);
            this.orderNumber.TabIndex = 0;
            this.orderNumber.Text = "orderNumber";
            // 
            // orderDateTitle
            // 
            this.orderDateTitle.AutoSize = true;
            this.orderDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateTitle.Location = new System.Drawing.Point(14, 45);
            this.orderDateTitle.Name = "orderDateTitle";
            this.orderDateTitle.Size = new System.Drawing.Size(89, 17);
            this.orderDateTitle.TabIndex = 1;
            this.orderDateTitle.Text = "Order Date";
            // 
            // requiredDateTitle
            // 
            this.requiredDateTitle.AutoSize = true;
            this.requiredDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredDateTitle.Location = new System.Drawing.Point(183, 45);
            this.requiredDateTitle.Name = "requiredDateTitle";
            this.requiredDateTitle.Size = new System.Drawing.Size(113, 17);
            this.requiredDateTitle.TabIndex = 2;
            this.requiredDateTitle.Text = "Required Date";
            // 
            // shippedDateTitle
            // 
            this.shippedDateTitle.AutoSize = true;
            this.shippedDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippedDateTitle.Location = new System.Drawing.Point(383, 45);
            this.shippedDateTitle.Name = "shippedDateTitle";
            this.shippedDateTitle.Size = new System.Drawing.Size(106, 17);
            this.shippedDateTitle.TabIndex = 3;
            this.shippedDateTitle.Text = "Shipped Date";
            // 
            // statusTitle
            // 
            this.statusTitle.AutoSize = true;
            this.statusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTitle.Location = new System.Drawing.Point(579, 45);
            this.statusTitle.Name = "statusTitle";
            this.statusTitle.Size = new System.Drawing.Size(54, 17);
            this.statusTitle.TabIndex = 4;
            this.statusTitle.Text = "Status";
            // 
            // orderDate
            // 
            this.orderDate.AutoSize = true;
            this.orderDate.Location = new System.Drawing.Point(14, 62);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(72, 17);
            this.orderDate.TabIndex = 5;
            this.orderDate.Text = "orderDate";
            // 
            // requiredDate
            // 
            this.requiredDate.AutoSize = true;
            this.requiredDate.Location = new System.Drawing.Point(183, 62);
            this.requiredDate.Name = "requiredDate";
            this.requiredDate.Size = new System.Drawing.Size(91, 17);
            this.requiredDate.TabIndex = 6;
            this.requiredDate.Text = "requiredDate";
            // 
            // shippedDate
            // 
            this.shippedDate.AutoSize = true;
            this.shippedDate.Location = new System.Drawing.Point(383, 62);
            this.shippedDate.Name = "shippedDate";
            this.shippedDate.Size = new System.Drawing.Size(88, 17);
            this.shippedDate.TabIndex = 7;
            this.shippedDate.Text = "shippedDate";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(579, 62);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(46, 17);
            this.status.TabIndex = 8;
            this.status.Text = "status";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(739, 308);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.shippedDate);
            this.Controls.Add(this.requiredDate);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.statusTitle);
            this.Controls.Add(this.shippedDateTitle);
            this.Controls.Add(this.requiredDateTitle);
            this.Controls.Add(this.orderDateTitle);
            this.Controls.Add(this.orderNumber);
            this.Name = "CustomerOrder";
            this.Size = new System.Drawing.Size(777, 414);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderNumber;
        private System.Windows.Forms.Label orderDateTitle;
        private System.Windows.Forms.Label requiredDateTitle;
        private System.Windows.Forms.Label shippedDateTitle;
        private System.Windows.Forms.Label statusTitle;
        private System.Windows.Forms.Label orderDate;
        private System.Windows.Forms.Label requiredDate;
        private System.Windows.Forms.Label shippedDate;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
