namespace CalculatorGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_hello = new System.Windows.Forms.Button();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.tbox_number1 = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_backs = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_negate = new System.Windows.Forms.Button();
            this.btn_sqr = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_one = new CustomControls.RJControls.RJButton();
            this.btn_two = new CustomControls.RJControls.RJButton();
            this.btn_three = new CustomControls.RJControls.RJButton();
            this.btn_four = new CustomControls.RJControls.RJButton();
            this.btn_five = new CustomControls.RJControls.RJButton();
            this.btn_six = new CustomControls.RJControls.RJButton();
            this.btn_seven = new CustomControls.RJControls.RJButton();
            this.btn_eight = new CustomControls.RJControls.RJButton();
            this.btn_nine = new CustomControls.RJControls.RJButton();
            this.btn_zero = new CustomControls.RJControls.RJButton();
            this.btn_dot = new CustomControls.RJControls.RJButton();
            this.btn_equal = new CustomControls.RJControls.RJButton();
            this.btn_add = new CustomControls.RJControls.RJButton();
            this.btn_subs = new CustomControls.RJControls.RJButton();
            this.btn_multypl = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_delone = new CustomControls.RJControls.RJButton();
            this.btn_div = new CustomControls.RJControls.RJButton();
            this.btn_square2 = new CustomControls.RJControls.RJButton();
            this.btn_c = new CustomControls.RJControls.RJButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_hello
            // 
            this.btn_hello.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hello.Location = new System.Drawing.Point(255, 188);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(75, 23);
            this.btn_hello.TabIndex = 0;
            this.btn_hello.Text = "=";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_hello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lbl_hello.Location = new System.Drawing.Point(7, 0);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(21, 21);
            this.lbl_hello.TabIndex = 1;
            this.lbl_hello.Text = "+";
            // 
            // tbox_number1
            // 
            this.tbox_number1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tbox_number1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_number1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbox_number1.ForeColor = System.Drawing.Color.White;
            this.tbox_number1.Location = new System.Drawing.Point(513, 46);
            this.tbox_number1.Multiline = true;
            this.tbox_number1.Name = "tbox_number1";
            this.tbox_number1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbox_number1.Size = new System.Drawing.Size(209, 38);
            this.tbox_number1.TabIndex = 2;
            this.tbox_number1.TextChanged += new System.EventHandler(this.tbox_number1_TextChanged);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_plus.Location = new System.Drawing.Point(255, 159);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 23);
            this.btn_plus.TabIndex = 3;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(174, 72);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(12, 159);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 6;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(93, 159);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 23);
            this.btn_2.TabIndex = 7;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(174, 159);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 23);
            this.btn_3.TabIndex = 8;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(12, 130);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 23);
            this.btn_4.TabIndex = 9;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(93, 130);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 23);
            this.btn_5.TabIndex = 10;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(174, 130);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 23);
            this.btn_6.TabIndex = 11;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(12, 101);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 23);
            this.btn_7.TabIndex = 12;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(93, 101);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 23);
            this.btn_8.TabIndex = 13;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(174, 101);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 23);
            this.btn_9.TabIndex = 14;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_minus.Location = new System.Drawing.Point(255, 130);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 23);
            this.btn_minus.TabIndex = 15;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_backs
            // 
            this.btn_backs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_backs.Location = new System.Drawing.Point(255, 72);
            this.btn_backs.Name = "btn_backs";
            this.btn_backs.Size = new System.Drawing.Size(75, 23);
            this.btn_backs.TabIndex = 16;
            this.btn_backs.Text = "Backspace";
            this.btn_backs.UseVisualStyleBackColor = true;
            this.btn_backs.Click += new System.EventHandler(this.btn_backs_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(93, 188);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 23);
            this.btn_0.TabIndex = 17;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_point
            // 
            this.btn_point.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_point.Location = new System.Drawing.Point(174, 188);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(75, 23);
            this.btn_point.TabIndex = 18;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_multiply.Location = new System.Drawing.Point(255, 101);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(75, 23);
            this.btn_multiply.TabIndex = 19;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_negate
            // 
            this.btn_negate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_negate.Location = new System.Drawing.Point(12, 188);
            this.btn_negate.Name = "btn_negate";
            this.btn_negate.Size = new System.Drawing.Size(75, 23);
            this.btn_negate.TabIndex = 20;
            this.btn_negate.Text = "+/-";
            this.btn_negate.UseVisualStyleBackColor = true;
            this.btn_negate.Click += new System.EventHandler(this.btn_negate_Click);
            // 
            // btn_sqr
            // 
            this.btn_sqr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sqr.Location = new System.Drawing.Point(93, 72);
            this.btn_sqr.Name = "btn_sqr";
            this.btn_sqr.Size = new System.Drawing.Size(75, 23);
            this.btn_sqr.TabIndex = 21;
            this.btn_sqr.Text = "x^2";
            this.btn_sqr.UseVisualStyleBackColor = true;
            this.btn_sqr.Click += new System.EventHandler(this.btn_sqr_Click);
            // 
            // btn_division
            // 
            this.btn_division.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_division.Location = new System.Drawing.Point(12, 72);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(75, 23);
            this.btn_division.TabIndex = 22;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_one
            // 
            this.btn_one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_one.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_one.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_one.BorderRadius = 5;
            this.btn_one.BorderSize = 0;
            this.btn_one.FlatAppearance.BorderSize = 0;
            this.btn_one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one.ForeColor = System.Drawing.Color.White;
            this.btn_one.Location = new System.Drawing.Point(470, 221);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(70, 44);
            this.btn_one.TabIndex = 23;
            this.btn_one.Text = "1";
            this.btn_one.TextColor = System.Drawing.Color.White;
            this.btn_one.UseVisualStyleBackColor = false;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // btn_two
            // 
            this.btn_two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_two.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_two.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_two.BorderRadius = 5;
            this.btn_two.BorderSize = 0;
            this.btn_two.FlatAppearance.BorderSize = 0;
            this.btn_two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_two.ForeColor = System.Drawing.Color.White;
            this.btn_two.Location = new System.Drawing.Point(546, 221);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(70, 44);
            this.btn_two.TabIndex = 24;
            this.btn_two.Text = "2";
            this.btn_two.TextColor = System.Drawing.Color.White;
            this.btn_two.UseVisualStyleBackColor = false;
            this.btn_two.Click += new System.EventHandler(this.btn_two_Click);
            // 
            // btn_three
            // 
            this.btn_three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_three.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_three.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_three.BorderRadius = 5;
            this.btn_three.BorderSize = 0;
            this.btn_three.FlatAppearance.BorderSize = 0;
            this.btn_three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_three.ForeColor = System.Drawing.Color.White;
            this.btn_three.Location = new System.Drawing.Point(622, 221);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(70, 44);
            this.btn_three.TabIndex = 25;
            this.btn_three.Text = "3";
            this.btn_three.TextColor = System.Drawing.Color.White;
            this.btn_three.UseVisualStyleBackColor = false;
            this.btn_three.Click += new System.EventHandler(this.btn_three_Click);
            // 
            // btn_four
            // 
            this.btn_four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_four.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_four.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_four.BorderRadius = 5;
            this.btn_four.BorderSize = 0;
            this.btn_four.FlatAppearance.BorderSize = 0;
            this.btn_four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_four.ForeColor = System.Drawing.Color.White;
            this.btn_four.Location = new System.Drawing.Point(470, 171);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(70, 44);
            this.btn_four.TabIndex = 26;
            this.btn_four.Text = "4";
            this.btn_four.TextColor = System.Drawing.Color.White;
            this.btn_four.UseVisualStyleBackColor = false;
            this.btn_four.Click += new System.EventHandler(this.btn_four_Click);
            // 
            // btn_five
            // 
            this.btn_five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_five.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_five.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_five.BorderRadius = 5;
            this.btn_five.BorderSize = 0;
            this.btn_five.FlatAppearance.BorderSize = 0;
            this.btn_five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_five.ForeColor = System.Drawing.Color.White;
            this.btn_five.Location = new System.Drawing.Point(546, 171);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(70, 44);
            this.btn_five.TabIndex = 27;
            this.btn_five.Text = "5";
            this.btn_five.TextColor = System.Drawing.Color.White;
            this.btn_five.UseVisualStyleBackColor = false;
            this.btn_five.Click += new System.EventHandler(this.btn_five_Click);
            // 
            // btn_six
            // 
            this.btn_six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_six.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_six.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_six.BorderRadius = 5;
            this.btn_six.BorderSize = 0;
            this.btn_six.FlatAppearance.BorderSize = 0;
            this.btn_six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_six.ForeColor = System.Drawing.Color.White;
            this.btn_six.Location = new System.Drawing.Point(622, 171);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(70, 44);
            this.btn_six.TabIndex = 28;
            this.btn_six.Text = "6";
            this.btn_six.TextColor = System.Drawing.Color.White;
            this.btn_six.UseVisualStyleBackColor = false;
            this.btn_six.Click += new System.EventHandler(this.btn_six_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_seven.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_seven.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_seven.BorderRadius = 5;
            this.btn_seven.BorderSize = 0;
            this.btn_seven.FlatAppearance.BorderSize = 0;
            this.btn_seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seven.ForeColor = System.Drawing.Color.White;
            this.btn_seven.Location = new System.Drawing.Point(470, 121);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(70, 44);
            this.btn_seven.TabIndex = 29;
            this.btn_seven.Text = "7";
            this.btn_seven.TextColor = System.Drawing.Color.White;
            this.btn_seven.UseVisualStyleBackColor = false;
            this.btn_seven.Click += new System.EventHandler(this.btn_seven_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_eight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_eight.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_eight.BorderRadius = 5;
            this.btn_eight.BorderSize = 0;
            this.btn_eight.FlatAppearance.BorderSize = 0;
            this.btn_eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eight.ForeColor = System.Drawing.Color.White;
            this.btn_eight.Location = new System.Drawing.Point(546, 121);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(70, 44);
            this.btn_eight.TabIndex = 30;
            this.btn_eight.Text = "8";
            this.btn_eight.TextColor = System.Drawing.Color.White;
            this.btn_eight.UseVisualStyleBackColor = false;
            this.btn_eight.Click += new System.EventHandler(this.btn_eight_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_nine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_nine.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_nine.BorderRadius = 5;
            this.btn_nine.BorderSize = 0;
            this.btn_nine.FlatAppearance.BorderSize = 0;
            this.btn_nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nine.ForeColor = System.Drawing.Color.White;
            this.btn_nine.Location = new System.Drawing.Point(622, 121);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(70, 44);
            this.btn_nine.TabIndex = 31;
            this.btn_nine.Text = "9";
            this.btn_nine.TextColor = System.Drawing.Color.White;
            this.btn_nine.UseVisualStyleBackColor = false;
            this.btn_nine.Click += new System.EventHandler(this.btn_nine_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_zero.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_zero.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_zero.BorderRadius = 5;
            this.btn_zero.BorderSize = 0;
            this.btn_zero.FlatAppearance.BorderSize = 0;
            this.btn_zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zero.ForeColor = System.Drawing.Color.White;
            this.btn_zero.Location = new System.Drawing.Point(546, 271);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(70, 44);
            this.btn_zero.TabIndex = 32;
            this.btn_zero.Text = "0";
            this.btn_zero.TextColor = System.Drawing.Color.White;
            this.btn_zero.UseVisualStyleBackColor = false;
            this.btn_zero.Click += new System.EventHandler(this.btn_zero_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_dot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_dot.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dot.BorderRadius = 5;
            this.btn_dot.BorderSize = 0;
            this.btn_dot.FlatAppearance.BorderSize = 0;
            this.btn_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dot.ForeColor = System.Drawing.Color.White;
            this.btn_dot.Location = new System.Drawing.Point(622, 271);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(70, 44);
            this.btn_dot.TabIndex = 33;
            this.btn_dot.Text = ".";
            this.btn_dot.TextColor = System.Drawing.Color.White;
            this.btn_dot.UseVisualStyleBackColor = false;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btn_equal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btn_equal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_equal.BorderRadius = 5;
            this.btn_equal.BorderSize = 0;
            this.btn_equal.FlatAppearance.BorderSize = 0;
            this.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equal.ForeColor = System.Drawing.Color.White;
            this.btn_equal.Location = new System.Drawing.Point(696, 271);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(70, 44);
            this.btn_equal.TabIndex = 34;
            this.btn_equal.Text = "=";
            this.btn_equal.TextColor = System.Drawing.Color.White;
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_add.BorderRadius = 5;
            this.btn_add.BorderSize = 0;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(696, 221);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(70, 44);
            this.btn_add.TabIndex = 35;
            this.btn_add.Text = "+";
            this.btn_add.TextColor = System.Drawing.Color.White;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_subs
            // 
            this.btn_subs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_subs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_subs.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_subs.BorderRadius = 5;
            this.btn_subs.BorderSize = 0;
            this.btn_subs.FlatAppearance.BorderSize = 0;
            this.btn_subs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subs.ForeColor = System.Drawing.Color.White;
            this.btn_subs.Location = new System.Drawing.Point(696, 171);
            this.btn_subs.Name = "btn_subs";
            this.btn_subs.Size = new System.Drawing.Size(70, 44);
            this.btn_subs.TabIndex = 36;
            this.btn_subs.Text = "-";
            this.btn_subs.TextColor = System.Drawing.Color.White;
            this.btn_subs.UseVisualStyleBackColor = false;
            this.btn_subs.Click += new System.EventHandler(this.btn_subs_Click);
            // 
            // btn_multypl
            // 
            this.btn_multypl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_multypl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_multypl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_multypl.BorderRadius = 5;
            this.btn_multypl.BorderSize = 0;
            this.btn_multypl.FlatAppearance.BorderSize = 0;
            this.btn_multypl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multypl.ForeColor = System.Drawing.Color.White;
            this.btn_multypl.Location = new System.Drawing.Point(696, 121);
            this.btn_multypl.Name = "btn_multypl";
            this.btn_multypl.Size = new System.Drawing.Size(70, 44);
            this.btn_multypl.TabIndex = 37;
            this.btn_multypl.Text = "X";
            this.btn_multypl.TextColor = System.Drawing.Color.White;
            this.btn_multypl.UseVisualStyleBackColor = false;
            this.btn_multypl.Click += new System.EventHandler(this.btn_multypl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(34, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "=";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lbl_hello);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(694, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(58, 28);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // btn_delone
            // 
            this.btn_delone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_delone.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_delone.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_delone.BorderRadius = 5;
            this.btn_delone.BorderSize = 0;
            this.btn_delone.FlatAppearance.BorderSize = 0;
            this.btn_delone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delone.ForeColor = System.Drawing.Color.White;
            this.btn_delone.Location = new System.Drawing.Point(696, 72);
            this.btn_delone.Name = "btn_delone";
            this.btn_delone.Size = new System.Drawing.Size(70, 44);
            this.btn_delone.TabIndex = 40;
            this.btn_delone.Text = "<-";
            this.btn_delone.TextColor = System.Drawing.Color.White;
            this.btn_delone.UseVisualStyleBackColor = false;
            this.btn_delone.Click += new System.EventHandler(this.btn_delone_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_div.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_div.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_div.BorderRadius = 5;
            this.btn_div.BorderSize = 0;
            this.btn_div.FlatAppearance.BorderSize = 0;
            this.btn_div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_div.ForeColor = System.Drawing.Color.White;
            this.btn_div.Location = new System.Drawing.Point(546, 71);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(70, 44);
            this.btn_div.TabIndex = 41;
            this.btn_div.Text = "/";
            this.btn_div.TextColor = System.Drawing.Color.White;
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_square2
            // 
            this.btn_square2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_square2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_square2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_square2.BorderRadius = 5;
            this.btn_square2.BorderSize = 0;
            this.btn_square2.FlatAppearance.BorderSize = 0;
            this.btn_square2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_square2.ForeColor = System.Drawing.Color.White;
            this.btn_square2.Location = new System.Drawing.Point(470, 72);
            this.btn_square2.Name = "btn_square2";
            this.btn_square2.Size = new System.Drawing.Size(70, 44);
            this.btn_square2.TabIndex = 42;
            this.btn_square2.Text = "x^2";
            this.btn_square2.TextColor = System.Drawing.Color.White;
            this.btn_square2.UseVisualStyleBackColor = false;
            this.btn_square2.Click += new System.EventHandler(this.btn_square2_Click);
            // 
            // btn_c
            // 
            this.btn_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_c.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_c.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_c.BorderRadius = 5;
            this.btn_c.BorderSize = 0;
            this.btn_c.FlatAppearance.BorderSize = 0;
            this.btn_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_c.ForeColor = System.Drawing.Color.White;
            this.btn_c.Location = new System.Drawing.Point(620, 72);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(70, 44);
            this.btn_c.TabIndex = 43;
            this.btn_c.Text = "C";
            this.btn_c.TextColor = System.Drawing.Color.White;
            this.btn_c.UseVisualStyleBackColor = false;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(776, 440);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_square2);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_delone);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_multypl);
            this.Controls.Add(this.btn_subs);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_nine);
            this.Controls.Add(this.btn_eight);
            this.Controls.Add(this.btn_seven);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_sqr);
            this.Controls.Add(this.btn_negate);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_backs);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.tbox_number1);
            this.Controls.Add(this.btn_hello);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_hello;
        private Label lbl_hello;
        private TextBox tbox_number1;
        private Button btn_plus;
        private Button btn_clear;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_minus;
        private Button btn_backs;
        private Button btn_0;
        private Button btn_point;
        private Button btn_multiply;
        private Button btn_negate;
        private Button btn_sqr;
        private Button btn_division;
        private CustomControls.RJControls.RJButton btn_one;
        private CustomControls.RJControls.RJButton btn_two;
        private CustomControls.RJControls.RJButton btn_three;
        private CustomControls.RJControls.RJButton btn_four;
        private CustomControls.RJControls.RJButton btn_five;
        private CustomControls.RJControls.RJButton btn_six;
        private CustomControls.RJControls.RJButton btn_seven;
        private CustomControls.RJControls.RJButton btn_eight;
        private CustomControls.RJControls.RJButton btn_nine;
        private CustomControls.RJControls.RJButton btn_zero;
        private CustomControls.RJControls.RJButton btn_dot;
        private CustomControls.RJControls.RJButton btn_equal;
        private CustomControls.RJControls.RJButton btn_add;
        private CustomControls.RJControls.RJButton btn_subs;
        private CustomControls.RJControls.RJButton btn_multypl;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJButton btn_delone;
        private CustomControls.RJControls.RJButton btn_div;
        private CustomControls.RJControls.RJButton btn_square2;
        private CustomControls.RJControls.RJButton btn_c;
    }
}