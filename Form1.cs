using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEX_DEX_BIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void convertToDecimal_Click(object sender, EventArgs e)
        {
            int decimalValue = Convert.ToInt32(decimalTextBox.Text);
            binaryTextBox.Text = Convert.ToString(getBinary(decimalValue));
            string hex = new string(getHex(decimalValue));
            hexadecimalTextBox.Text = hex;
        }

        int getBinary(int x)
        {
            int remainder = 0,binary =  0,pos = 1;
            while(x != 0)
            {
                remainder = x % 2;
                x /= 2;
                binary += remainder * pos;
                pos *= 10;
            }
            return binary;
        }

        char[] getHex(int n)
        {
            char[] hexaDeciNum = new char[100];

            // counter for hexadecimal number array 
            int i = 0;
            while (n != 0)
            {
                // temporary variable to  
                // store remainder 
                int temp = 0;

                // storing remainder in temp 
                // variable. 
                temp = n % 16;

                // check if temp < 10 
                if (temp < 10)
                {
                    hexaDeciNum[i] = (char)(temp + 48);
                    i++;
                }
                else
                {
                    hexaDeciNum[i] = (char)(temp + 55);
                    i++;
                }

                n = n / 16;
            }
            char[] hex = new char[100];
            int k = 0;
            for (int j = i - 1; j >= 0; j--)
            {
                hex[k] = hexaDeciNum[j];
                k++;
            }                
                return hex;
        }
    }
}
