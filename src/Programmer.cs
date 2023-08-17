using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace CalculatorGUI
{
    public partial class Programmer : UserControl
    {
        string text = string.Empty;
        string currentChoice="DEC";
        public Programmer()
        {
            InitializeComponent();
        }
        private void btn_0p_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "0";
            UpdateConversions(currentChoice);
        }
        private void txbox_programmer_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_1p_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "1";
            UpdateConversions(currentChoice);
        }
        private void btn_clProgrammer_Click(object sender, EventArgs e)
        {
            clearcontrols();
        }
        private void clearcontrols()
        {
            txbox_programmer.Text = "";
            lbl_hexResult.Text = "";
            lbl_binResult.Text = "";
            lbl_octResult.Text = "";
            lbl_decResult.Text = "";
        }
        private void lettersEnable()
        {
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;
            btn_E.Enabled = true;
            btn_F.Enabled = true;
        }
        private void lettersDisable()
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_E.Enabled = false;
            btn_F.Enabled = false;
        }
        private void btn_hex_Click(object sender, EventArgs e)
        {
            currentChoice = "HEX";
            txbox_programmer.Text = lbl_hexResult.Text; // Set value from hex label to textbox
            UpdateConversions(currentChoice);
            enableForBin();
            lettersEnable();
        }
        private void btn_dec_Click(object sender, EventArgs e)
        {
            currentChoice = "DEC";
            txbox_programmer.Text = lbl_hexResult.Text;
            UpdateConversions(currentChoice);
            enableForBin();
            lettersDisable();
        }
        private void btn_oct_Click(object sender, EventArgs e)
        {
            currentChoice = "OCT";
            txbox_programmer.Text = lbl_octResult.Text; // Set value from oct label to textbox
            UpdateConversions(currentChoice);
            enableForBin();
            lettersDisable();
        }
        private void btn_bin_Click(object sender, EventArgs e)
        {
            currentChoice = "BIN";
            disableForBin();
            txbox_programmer.Text = lbl_binResult.Text; // Set value from bin label to textbox
            UpdateConversions(currentChoice);
            lettersDisable();
        }
        private void disableForBin()
        {
            btn_2p.Enabled = false;
            btn_3p.Enabled = false;
            btn_4p.Enabled = false;
            btn_5p.Enabled = false;
            btn_6p.Enabled = false;
            btn_7p.Enabled = false;
            btn_8p.Enabled = false;
            btn_9p.Enabled = false;
        }
        private void enableForBin()
        {
            btn_2p.Enabled = true;
            btn_3p.Enabled = true;
            btn_4p.Enabled = true;
            btn_5p.Enabled = true;
            btn_6p.Enabled = true;
            btn_7p.Enabled = true;
            btn_8p.Enabled = true;
            btn_9p.Enabled = true;
        }
        private void UpdateConversions(string selectedBase)
        {
                string inputText = txbox_programmer.Text;

                if (selectedBase == "DEC" && BigInteger.TryParse(inputText, out var bigNumber))
                {
                    lbl_decResult.Text = inputText;
                    lbl_hexResult.Text = bigNumber.ToString("X");
                    lbl_binResult.Text = Convert.ToString((long)bigNumber, 2);
                    lbl_octResult.Text = Convert.ToString((long)bigNumber, 8);
                }
                else if (selectedBase == "HEX" && BigInteger.TryParse(inputText, System.Globalization.NumberStyles.HexNumber, null, out bigNumber))
                {
                    lbl_hexResult.Text = inputText.ToUpper();
                    lbl_decResult.Text = bigNumber.ToString();
                    lbl_binResult.Text = Convert.ToString((long)bigNumber, 2);
                    lbl_octResult.Text = Convert.ToString((long)bigNumber, 8);
                }
                else if (selectedBase == "OCT" && BigInteger.TryParse(inputText, System.Globalization.NumberStyles.AllowLeadingSign, null, out bigNumber))
                {
                    lbl_octResult.Text = inputText;
                    lbl_decResult.Text = bigNumber.ToString();
                    lbl_hexResult.Text = bigNumber.ToString("X");
                    lbl_binResult.Text = Convert.ToString((long)bigNumber, 2);
                }
                else if (selectedBase == "BIN")
                {
                BigInteger binaryValue = BigInteger.Parse(inputText, System.Globalization.NumberStyles.AllowLeadingSign);
                    lbl_decResult.Text = BinaryToDecimal(inputText).ToString();
                    int decimalvalue = int.Parse(lbl_decResult.Text);
                    lbl_binResult.Text = inputText;
                    lbl_hexResult.Text = decimalvalue.ToString("X");
                    lbl_octResult.Text = Convert.ToString((long)decimalvalue, 8);
                }
                else
                {
                    txbox_programmer.Text = "";
                    lbl_decResult.Text = "";
                    lbl_hexResult.Text = "";
                    lbl_binResult.Text = "";
                    lbl_octResult.Text = "";
                }
            }
        private void btn_A_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "A";
            UpdateConversions(currentChoice);
        }
        private void btn_2p_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "2";
            UpdateConversions(currentChoice);
        }
        private void btn_5p_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "5";
            UpdateConversions(currentChoice);
        }
        private void btn_3p_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "3";
            UpdateConversions(currentChoice);
        }
        private void btn_7p_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "7";
            UpdateConversions(currentChoice);
        }
        private void btn_B_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "B";
            UpdateConversions(currentChoice);
        }
        private void btn_C_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "C";
            UpdateConversions(currentChoice);
        }
        private void btn_D_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "D";
            UpdateConversions(currentChoice);
        }
        private void btn_E_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "E";
            UpdateConversions(currentChoice);
        }
        private void btn_F_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "F";
            UpdateConversions(currentChoice);
        }
        private void btn_4p_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "4";
            UpdateConversions(currentChoice);
        }
        private void btn_6p_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "6";
            UpdateConversions(currentChoice);
        }
        private void btn_8p_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "8";
            UpdateConversions(currentChoice);
        }
        private void btn_9p_Click(object sender, EventArgs e)
        {
            txbox_programmer.Text = txbox_programmer.Text + "9";
            UpdateConversions(currentChoice);
        }
        private void btn_delonep_Click(object sender, EventArgs e)
        {
            if (txbox_programmer.Text.Length > 1)
            {
                txbox_programmer.Text = txbox_programmer.Text.Remove(txbox_programmer.Text.Length - 1);
                UpdateConversions(currentChoice);
            }
            else
            {
                txbox_programmer.Text = "";
                clearcontrols();
            }
        }
        public BigInteger BinaryToDecimal(string binary)
        {

            BigInteger result = BigInteger.Parse(binary);
            
            BigInteger decimalValue = 0;
            // initializing base1 value to 1, i.e 2^0 
            int base1 = 1;

            while (result > 0)
            {
                BigInteger reminder = result % 10;
                result = result / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            return decimalValue;
        }
    }
}
