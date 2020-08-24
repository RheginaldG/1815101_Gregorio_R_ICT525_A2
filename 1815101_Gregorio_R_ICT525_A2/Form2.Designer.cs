namespace _1815101_Gregorio_R_ICT525_A2
{
    partial class Form2
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
            this.dataCart = new System.Windows.Forms.DataGridView();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblfinaltotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCart
            // 
            this.dataCart.AllowUserToAddRows = false;
            this.dataCart.AllowUserToDeleteRows = false;
            this.dataCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCart.Location = new System.Drawing.Point(13, 13);
            this.dataCart.Name = "dataCart";
            this.dataCart.ReadOnly = true;
            this.dataCart.Size = new System.Drawing.Size(775, 343);
            this.dataCart.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(584, 409);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(132, 67);
            this.btnPlaceOrder.TabIndex = 1;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(102, 409);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(10, 13);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Location = new System.Drawing.Point(102, 436);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(10, 13);
            this.lblCustomerEmail.TabIndex = 6;
            this.lblCustomerEmail.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address:";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(102, 463);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(10, 13);
            this.lblCustomerAddress.TabIndex = 8;
            this.lblCustomerAddress.Text = ".";
            // 
            // lblfinaltotal
            // 
            this.lblfinaltotal.AutoSize = true;
            this.lblfinaltotal.Location = new System.Drawing.Point(403, 409);
            this.lblfinaltotal.Name = "lblfinaltotal";
            this.lblfinaltotal.Size = new System.Drawing.Size(10, 13);
            this.lblfinaltotal.TabIndex = 9;
            this.lblfinaltotal.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total Price:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblfinaltotal);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.dataCart);
            this.Name = "Form2";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCart;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblfinaltotal;
        private System.Windows.Forms.Label label2;
    }
}