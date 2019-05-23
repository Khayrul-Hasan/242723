using CoffeeShopHomeForm.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopHomeForm
{
    public partial class CoffeeShopHomeForm : Form
    {
        int price_black = 120;
        int price_cold = 100;
        int price_hot = 90;
        int price_regular = 80; 
        int total;

        public int Total { get => total; set => total = value; }
        public CoffeeShopHomeForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CustomerOrderInformation customerOrderInformation = new CustomerOrderInformation();

            customerOrderInformation.CustomerName = customerNameTextBox.Text;
            string name = customerNameTextBox.Text;
         
            int quantity;
            if (CoffeeTypeComboBox.Text== "Black Coffee")
                {
                Total = Convert.ToInt32(QuantityTextBox.Text) * price_black;
            }

            else if (CoffeeTypeComboBox.Text == "Cold Coffee") 
            {
                Total = Convert.ToInt32(QuantityTextBox.Text) * price_cold;
            }
            else if (CoffeeTypeComboBox.Text == "Hot Coffee") 
            {
                Total = Convert.ToInt32(QuantityTextBox.Text) * price_hot;
            }
            else if (CoffeeTypeComboBox.Text == "Regular Coffee") 
            {
                Total = Convert.ToInt32(QuantityTextBox.Text) * price_regular;
            }
            if (customerNameTextBox.Text=="")
            {
                customerNameTextBox.BackColor = Color.Red;
                return;
            }
            else
            {
                customerNameTextBox.BackColor = Color.White;
            }
            if (mobileNumberTextBox.Text == "")
            {
                mobileNumberTextBox.BackColor = Color.Red;
                return;
            }
            if (AddressTextBox.Text == "")
            {
                AddressTextBox.BackColor = Color.Red;
                return;
            }
            if (CoffeeTypeComboBox.Text == "")
                {
                CoffeeTypeComboBox.BackColor = Color.Red;
                return;
            }
            if (QuantityTextBox.Text == "")
            {
                QuantityTextBox.BackColor = Color.Red;
                MessageBox.Show("Please input quantity!");
                return;
            }
            else if (!int.TryParse(QuantityTextBox.Text, out quantity))
            {
                MessageBox.Show("Invalid quantity!");
                return;
            }
            purchaseDetails.Text = ("Customer Name: "+ customerNameTextBox.Text +"\r\n" + "Contact Number: "+ mobileNumberTextBox.Text + "\r\n" +
                "Address: "+ AddressTextBox.Text + "\r\n" + 
                "Coffee Type: "+ CoffeeTypeComboBox.Text +"\r\n" + "Quantity: "+ QuantityTextBox.Text +"\r\n" + "Total Price: "+ Total);
            
        }

        private void CustomerNameTextBox(object sender, EventArgs e)
        {
            customerNameTextBox.BackColor = Color.White;
        }

        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            customerNameTextBox.BackColor = Color.White;
        }

        private void MobileTextBox_TextChanged(object sender, EventArgs e)
        {
            mobileNumberTextBox.BackColor = Color.White;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            AddressTextBox.BackColor = Color.White;
        }

        private void CoffeeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CoffeeTypeComboBox.BackColor = Color.White;
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            int quantity;
            if (!int.TryParse(QuantityTextBox.Text, out quantity))
            {
                QuantityTextBox.BackColor = Color.Red;
                MessageBox.Show("Invalid quantity!");
                return;
            }
            else
            {
                QuantityTextBox.BackColor = Color.White;
            }
        }
    }
}
