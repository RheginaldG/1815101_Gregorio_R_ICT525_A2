namespace _1815101_Gregorio_R_ICT525_A2
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblitemsLeft = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.numItems = new System.Windows.Forms.NumericUpDown();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            this.grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItems)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnCreate);
            this.grpInfo.Controls.Add(this.txtAddress);
            this.grpInfo.Controls.Add(this.txtEmail);
            this.grpInfo.Controls.Add(this.txtName);
            this.grpInfo.Controls.Add(this.labelAddress);
            this.grpInfo.Controls.Add(this.labelEmail);
            this.grpInfo.Controls.Add(this.labelName);
            this.grpInfo.Location = new System.Drawing.Point(4, 6);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(845, 193);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Customer Details";
            this.grpInfo.Enter += new System.EventHandler(this.grpInfo_Enter);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(712, 26);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 64);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create Order";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(368, 23);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(337, 151);
            this.txtAddress.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(44, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(44, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 10;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(314, 23);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Address:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(6, 77);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.label1);
            this.grpItem.Controls.Add(this.lblitemsLeft);
            this.grpItem.Controls.Add(this.lblItemPrice);
            this.grpItem.Controls.Add(this.numItems);
            this.grpItem.Controls.Add(this.cmbItem);
            this.grpItem.Controls.Add(this.label6);
            this.grpItem.Controls.Add(this.label5);
            this.grpItem.Controls.Add(this.labelPrice);
            this.grpItem.Controls.Add(this.labelItem);
            this.grpItem.Location = new System.Drawing.Point(4, 205);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(845, 222);
            this.grpItem.TabIndex = 1;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Item List";
            this.grpItem.Enter += new System.EventHandler(this.grpItem_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "$";
            // 
            // lblitemsLeft
            // 
            this.lblitemsLeft.AutoSize = true;
            this.lblitemsLeft.Location = new System.Drawing.Point(368, 122);
            this.lblitemsLeft.Name = "lblitemsLeft";
            this.lblitemsLeft.Size = new System.Drawing.Size(13, 13);
            this.lblitemsLeft.TabIndex = 7;
            this.lblitemsLeft.Text = "0";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Location = new System.Drawing.Point(368, 65);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(22, 13);
            this.lblItemPrice.TabIndex = 6;
            this.lblItemPrice.Text = "0.0";
            this.lblItemPrice.Click += new System.EventHandler(this.lblItemPrice_Click);
            // 
            // numItems
            // 
            this.numItems.Location = new System.Drawing.Point(368, 180);
            this.numItems.Name = "numItems";
            this.numItems.Size = new System.Drawing.Size(455, 20);
            this.numItems.TabIndex = 5;
            this.numItems.ValueChanged += new System.EventHandler(this.numItems_ValueChanged);
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(368, 16);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(455, 21);
            this.cmbItem.TabIndex = 4;
            this.cmbItem.Text = "Please Select an item:";
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "No of Items needed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Items Left:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(304, 65);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(57, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Item Price:";
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(331, 24);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(30, 13);
            this.labelItem.TabIndex = 0;
            this.labelItem.Text = "Item:";
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Location = new System.Drawing.Point(548, 440);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(91, 37);
            this.btnAddtoCart.TabIndex = 2;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(655, 440);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(87, 37);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View to Cart";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 492);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.grpInfo);
            this.Name = "Form1";
            this.Text = "Make an Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label lblitemsLeft;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.NumericUpDown numItems;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
    }
}

