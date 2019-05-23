using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayForm
{
    public partial class ArrayForm : Form
    {
        public ArrayForm()
        {
            InitializeComponent();
           
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            const int size = 10;

            int[] firstNumber = new int[size];

            firstNumber[0] = 2;
            firstNumber[4] = 4;
            firstNumber[9] = 7;

            string message = "";
            for (int index = 0; index < firstNumber.Length; index++)
            {
                if (firstNumber[index] != 0)
                    message = message + "Value at Index  " + index + " is: " + firstNumber[index].ToString() +"\n";
            }
            showRichTextBox.Text = message;
        }
    }
}
