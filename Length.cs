using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class Length : UserControl
    {
        public Length()
        {
            InitializeComponent();
        }

        private void btn_toconvert_Click(object sender, EventArgs e)
        {
            double result = LengthConvertor.Convert(Double.Parse(txbox_from.Text), combo_form.Text, combo_to.Text);
            txbox_to.Text = result.ToString();
        }

        private void txbox_from_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_form_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
