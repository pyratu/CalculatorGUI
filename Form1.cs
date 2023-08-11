using Myapp.Classes;
using System.Text;

namespace CalculatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            DarkTitleBarClass.UseImmersiveDarkMode(Handle, true);
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // OR FormBorderStyle.FixedDialog OR FormBorderStyle.Fixed3D
        }
        bool cnt = false;

        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        public static string ReplaceAt(string str, int index, int length, string replace)
        {
            return str.Remove(index, Math.Min(length, str.Length - index)).Insert(index, replace);
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0 && cnt == false && (Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1])) || tbox_number1.Text[tbox_number1.Text.Length - 1] == ')')
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
            if (tbox_number1.Text.Length > 0 && cnt == false && (Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1])) || tbox_number1.Text[tbox_number1.Text.Length - 1] == ')')
                tbox_number1.Text = tbox_number1.Text + "-";
        }

        private void btn_backs_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0)
                tbox_number1.Text = tbox_number1.Text.Remove(tbox_number1.Text.Length - 1);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "0";
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0 && cnt == false && (Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1])))
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

        private void btn_negate_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0 && Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1]))
            {
                string str = tbox_number1.Text;
                char c = str[str.Length - 1];
                int nr = c - '0';
                nr = nr * (-1);
                string strtmp = "(" + nr.ToString() + ")";
                str = ReplaceAt(str, str.Length - 1, 1, strtmp);
                tbox_number1.Text = str;
            }
        }
        private void btn_sqr_Click(object sender, EventArgs e)
        {
            string str = tbox_number1.Text;
            string strtmp = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/' || str[i] == '%' || str[i] == '(' || str[i] == ')')
                    break;
                strtmp = str[i].ToString() + strtmp;
            }
            int n;
            if (int.TryParse(strtmp, out n))
                tbox_number1.Text = (int.Parse(strtmp) * int.Parse(strtmp)).ToString();
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0 && Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1]))
                tbox_number1.Text = tbox_number1.Text + "/";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "1";
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "2";
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "3";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "0";
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "4";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "5";
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "6";
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "7";
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "8";
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + "9";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = tbox_number1.Text + ".";
            cnt = true;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            lbl_hello.Text = tbox_number1.Text;
            tbox_number1.Text = Evaluate(tbox_number1.Text).ToString();


        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0 && cnt == false && (Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1])) || tbox_number1.Text[tbox_number1.Text.Length - 1] == ')')
                tbox_number1.Text = tbox_number1.Text + "+";
        }

        private void btn_subs_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0 && cnt == false && (Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1])) || tbox_number1.Text[tbox_number1.Text.Length - 1] == ')')
                tbox_number1.Text = tbox_number1.Text + "-";
        }

        private void btn_multypl_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0 && Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1]))
                tbox_number1.Text = tbox_number1.Text + "*";
        }

        private void tbox_number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_square2_Click(object sender, EventArgs e)
        {
            string str = tbox_number1.Text;
            string strtmp = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/' || str[i] == '%' || str[i] == '(' || str[i] == ')')
                    break;
                strtmp = str[i].ToString() + strtmp;
            }
            int n;
            if (int.TryParse(strtmp, out n))
                tbox_number1.Text = (int.Parse(strtmp) * int.Parse(strtmp)).ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0 && Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1]))
                tbox_number1.Text = tbox_number1.Text + "/";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            tbox_number1.Text = "";
            lbl_hello.Text = "";
        }

        private void btn_delone_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0)
                tbox_number1.Text = tbox_number1.Text.Remove(tbox_number1.Text.Length - 1);
        }
        private void btn_neg_Click(object sender, EventArgs e)
        {
            if (tbox_number1.Text.Length > 0 && Char.IsDigit(tbox_number1.Text[tbox_number1.Text.Length - 1]))
            {
                string str = tbox_number1.Text;
                char c = str[str.Length - 1];
                int nr = c - '0';
                nr = nr * (-1);
                string strtmp = "(" + nr.ToString() + ")";
                str = ReplaceAt(str, str.Length - 1, 1, strtmp);
                tbox_number1.Text = str;
            }
        }
    }
}
