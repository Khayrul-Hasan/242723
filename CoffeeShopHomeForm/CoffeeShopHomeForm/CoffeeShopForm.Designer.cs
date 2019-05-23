namespace CoffeeShopHomeForm
{
    partial class CoffeeShopHomeForm
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
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CoffeeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.purchaseDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(334, 68);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.customerNameTextBox.TabIndex = 0;
            this.customerNameTextBox.Text = "jh";
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.CustomerNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // mobileNumberTextBox
            // 
            this.mobileNumberTextBox.Location = new System.Drawing.Point(333, 107);
            this.mobileNumberTextBox.Name = "mobileNumberTextBox";
            this.mobileNumberTextBox.Size = new System.Drawing.Size(118, 20);
            this.mobileNumberTextBox.TabIndex = 2;
            this.mobileNumberTextBox.TextChanged += new System.EventHandler(this.MobileTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mobile Number";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(333, 153);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(118, 20);
            this.AddressTextBox.TabIndex = 4;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // CoffeeTypeComboBox
            // 
            this.CoffeeTypeComboBox.FormattingEnabled = true;
            this.CoffeeTypeComboBox.Items.AddRange(new object[] {
            "Black Coffee",
            "Cold Coffee",
            "Hot Coffee",
            "Regular Coffee"});
            this.CoffeeTypeComboBox.Location = new System.Drawing.Point(333, 226);
            this.CoffeeTypeComboBox.Name = "CoffeeTypeComboBox";
            this.CoffeeTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.CoffeeTypeComboBox.TabIndex = 6;
            this.CoffeeTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.CoffeeTypeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Coffee Type";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(333, 264);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.QuantityTextBox.TabIndex = 8;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(345, 313);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Customer Order Information";
            // 
            // purchaseDetails
            // 
            this.purchaseDetails.Location = new System.Drawing.Point(492, 68);
            this.purchaseDetails.Multiline = true;
            this.purchaseDetails.Name = "purchaseDetails";
            this.purchaseDetails.Size = new System.Drawing.Size(296, 268);
            this.purchaseDetails.TabIndex = 12;
            // 
            // CoffeeShopHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.purchaseDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CoffeeTypeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mobileNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameTextBox);
            this.Name = "CoffeeShopHomeForm";
            this.Text = "CoffeeShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mobileNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CoffeeTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox purchaseDetails;
    }
}

