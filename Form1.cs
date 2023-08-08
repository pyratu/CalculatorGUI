namespace CalculatorGUI
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool cnt = false;
        private void btn_hello_Click(object sender, EventArgs e)
        {
            lbl_hello.Text=Evaluate(tbox_number1.Text).ToString();
            cnt = false;
        }
        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0 && Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1]))
                tbox_number1.Text = tbox_number1.Text + "+";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = "";
            lbl_hello.Text = "";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "4";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "3";
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "9";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if(tbox_number1.Text.Length > 0 && Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1]))
            tbox_number1.Text = tbox_number1.Text + "-";
        }

        private void btn_backs_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text.Remove(tbox_number1.Text.Length - 1);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "0";
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0 &&cnt==false&& Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1]))
            {
                tbox_number1.Text = tbox_number1.Text + ".";
                cnt = true;
            }
 
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0 && Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1]))
            tbox_number1.Text = tbox_number1.Text + "*";
        }
    }

}
