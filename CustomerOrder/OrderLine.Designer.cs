namespace CustomerOrder
{
    partial class OrderLine
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productName = new System.Windows.Forms.Label();
            this.qtyOrdered = new System.Windows.Forms.Label();
            this.priceEach = new System.Windows.Forms.Label();
            this.totalTitle = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(77, 26);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(93, 17);
            this.productName.TabIndex = 1;
            this.productName.Text = "productName";
            // 
            // qtyOrdered
            // 
            this.qtyOrdered.AutoSize = true;
            this.qtyOrdered.Location = new System.Drawing.Point(256, 26);
            this.qtyOrdered.Name = "qtyOrdered";
            this.qtyOrdered.Size = new System.Drawing.Size(80, 17);
            this.qtyOrdered.TabIndex = 2;
            this.qtyOrdered.Text = "qtyOrdered";
            // 
            // priceEach
            // 
            this.priceEach.AutoSize = true;
            this.priceEach.Location = new System.Drawing.Point(363, 26);
            this.priceEach.Name = "priceEach";
            this.priceEach.Size = new System.Drawing.Size(71, 17);
            this.priceEach.TabIndex = 3;
            this.priceEach.Text = "priceEach";
            // 
            // totalTitle
            // 
            this.totalTitle.AutoSize = true;
            this.totalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTitle.Location = new System.Drawing.Point(521, 26);
            this.totalTitle.Name = "totalTitle";
            this.totalTitle.Size = new System.Drawing.Size(50, 17);
            this.totalTitle.TabIndex = 4;
            this.totalTitle.Text = "Total:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(573, 26);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(35, 17);
            this.total.TabIndex = 5;
            this.total.Text = "total";
            // 
            // OrderLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalTitle);
            this.Controls.Add(this.priceEach);
            this.Controls.Add(this.qtyOrdered);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderLine";
            this.Size = new System.Drawing.Size(668, 72);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label qtyOrdered;
        private System.Windows.Forms.Label priceEach;
        private System.Windows.Forms.Label totalTitle;
        private System.Windows.Forms.Label total;
    }
}
