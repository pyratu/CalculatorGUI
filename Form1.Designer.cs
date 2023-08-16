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
            this.components = new System.ComponentModel.Container();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.tbox_number1 = new System.Windows.Forms.TextBox();
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
            this.btn_delone = new CustomControls.RJControls.RJButton();
            this.btn_div = new CustomControls.RJControls.RJButton();
            this.btn_square2 = new CustomControls.RJControls.RJButton();
            this.btn_c = new CustomControls.RJControls.RJButton();
            this.btn_neg = new CustomControls.RJControls.RJButton();
            this.btn_onepx = new CustomControls.RJControls.RJButton();
            this.btn_clrtxtbox = new CustomControls.RJControls.RJButton();
            this.btn_sideMenu = new CustomControls.RJControls.RJButton();
            this.sideMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_calcu = new CustomControls.RJControls.RJButton();
            this.btn_volume = new CustomControls.RJControls.RJButton();
            this.btn_length = new CustomControls.RJControls.RJButton();
            this.TimerAnim = new System.Windows.Forms.Timer(this.components);
            this.length1 = new CalculatorGUI.Length();
            this.sideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_hello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lbl_hello.Location = new System.Drawing.Point(36, 16);
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
            this.tbox_number1.Location = new System.Drawing.Point(36, 40);
            this.tbox_number1.Multiline = true;
            this.tbox_number1.Name = "tbox_number1";
            this.tbox_number1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbox_number1.Size = new System.Drawing.Size(209, 38);
            this.tbox_number1.TabIndex = 2;
            this.tbox_number1.TextChanged += new System.EventHandler(this.tbox_number1_TextChanged);
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
            this.btn_one.Location = new System.Drawing.Point(10, 270);
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
            this.btn_two.Location = new System.Drawing.Point(86, 270);
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
            this.btn_three.Location = new System.Drawing.Point(162, 270);
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
            this.btn_four.Location = new System.Drawing.Point(10, 220);
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
            this.btn_five.Location = new System.Drawing.Point(86, 220);
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
            this.btn_six.Location = new System.Drawing.Point(162, 220);
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
            this.btn_seven.Location = new System.Drawing.Point(10, 170);
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
            this.btn_eight.Location = new System.Drawing.Point(86, 170);
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
            this.btn_nine.Location = new System.Drawing.Point(162, 170);
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
            this.btn_zero.Location = new System.Drawing.Point(86, 320);
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
            this.btn_dot.Location = new System.Drawing.Point(162, 320);
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
            this.btn_equal.Location = new System.Drawing.Point(236, 320);
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
            this.btn_add.Location = new System.Drawing.Point(236, 270);
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
            this.btn_subs.Location = new System.Drawing.Point(236, 220);
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
            this.btn_multypl.Location = new System.Drawing.Point(236, 170);
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
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "=";
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
            this.btn_delone.Location = new System.Drawing.Point(236, 71);
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
            this.btn_div.Location = new System.Drawing.Point(86, 120);
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
            this.btn_square2.Location = new System.Drawing.Point(10, 121);
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
            this.btn_c.Location = new System.Drawing.Point(160, 121);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(70, 44);
            this.btn_c.TabIndex = 43;
            this.btn_c.Text = "C";
            this.btn_c.TextColor = System.Drawing.Color.White;
            this.btn_c.UseVisualStyleBackColor = false;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_neg
            // 
            this.btn_neg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_neg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_neg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_neg.BorderRadius = 5;
            this.btn_neg.BorderSize = 0;
            this.btn_neg.FlatAppearance.BorderSize = 0;
            this.btn_neg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_neg.ForeColor = System.Drawing.Color.White;
            this.btn_neg.Location = new System.Drawing.Point(10, 320);
            this.btn_neg.Name = "btn_neg";
            this.btn_neg.Size = new System.Drawing.Size(70, 44);
            this.btn_neg.TabIndex = 44;
            this.btn_neg.Text = "+/-";
            this.btn_neg.TextColor = System.Drawing.Color.White;
            this.btn_neg.UseVisualStyleBackColor = false;
            this.btn_neg.Click += new System.EventHandler(this.btn_neg_Click);
            // 
            // btn_onepx
            // 
            this.btn_onepx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_onepx.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_onepx.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_onepx.BorderRadius = 5;
            this.btn_onepx.BorderSize = 0;
            this.btn_onepx.FlatAppearance.BorderSize = 0;
            this.btn_onepx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onepx.ForeColor = System.Drawing.Color.White;
            this.btn_onepx.Location = new System.Drawing.Point(10, 71);
            this.btn_onepx.Name = "btn_onepx";
            this.btn_onepx.Size = new System.Drawing.Size(70, 44);
            this.btn_onepx.TabIndex = 45;
            this.btn_onepx.Text = "1/x";
            this.btn_onepx.TextColor = System.Drawing.Color.White;
            this.btn_onepx.UseVisualStyleBackColor = false;
            this.btn_onepx.Click += new System.EventHandler(this.btn_onepx_Click);
            // 
            // btn_clrtxtbox
            // 
            this.btn_clrtxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_clrtxtbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_clrtxtbox.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_clrtxtbox.BorderRadius = 5;
            this.btn_clrtxtbox.BorderSize = 0;
            this.btn_clrtxtbox.FlatAppearance.BorderSize = 0;
            this.btn_clrtxtbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clrtxtbox.ForeColor = System.Drawing.Color.White;
            this.btn_clrtxtbox.Location = new System.Drawing.Point(236, 121);
            this.btn_clrtxtbox.Name = "btn_clrtxtbox";
            this.btn_clrtxtbox.Size = new System.Drawing.Size(70, 44);
            this.btn_clrtxtbox.TabIndex = 46;
            this.btn_clrtxtbox.Text = "CE";
            this.btn_clrtxtbox.TextColor = System.Drawing.Color.White;
            this.btn_clrtxtbox.UseVisualStyleBackColor = false;
            this.btn_clrtxtbox.Click += new System.EventHandler(this.btn_clrtxtbox_Click);
            // 
            // btn_sideMenu
            // 
            this.btn_sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_sideMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_sideMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_sideMenu.BorderRadius = 0;
            this.btn_sideMenu.BorderSize = 0;
            this.btn_sideMenu.FlatAppearance.BorderSize = 0;
            this.btn_sideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sideMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sideMenu.ForeColor = System.Drawing.Color.White;
            this.btn_sideMenu.Location = new System.Drawing.Point(9, 12);
            this.btn_sideMenu.Name = "btn_sideMenu";
            this.btn_sideMenu.Size = new System.Drawing.Size(21, 25);
            this.btn_sideMenu.TabIndex = 47;
            this.btn_sideMenu.Text = "≡";
            this.btn_sideMenu.TextColor = System.Drawing.Color.White;
            this.btn_sideMenu.UseVisualStyleBackColor = false;
            this.btn_sideMenu.Click += new System.EventHandler(this.btn_sideMenu_Click);
            // 
            // sideMenu
            // 
            this.sideMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sideMenu.Controls.Add(this.panel1);
            this.sideMenu.Location = new System.Drawing.Point(1, 43);
            this.sideMenu.MaximumSize = new System.Drawing.Size(205, 322);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(0, 0);
            this.sideMenu.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_calcu);
            this.panel1.Controls.Add(this.btn_volume);
            this.panel1.Controls.Add(this.btn_length);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(205, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 321);
            this.panel1.TabIndex = 49;
            // 
            // btn_calcu
            // 
            this.btn_calcu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_calcu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_calcu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_calcu.BorderRadius = 5;
            this.btn_calcu.BorderSize = 0;
            this.btn_calcu.FlatAppearance.BorderSize = 0;
            this.btn_calcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcu.ForeColor = System.Drawing.Color.White;
            this.btn_calcu.Location = new System.Drawing.Point(8, 3);
            this.btn_calcu.Name = "btn_calcu";
            this.btn_calcu.Size = new System.Drawing.Size(194, 44);
            this.btn_calcu.TabIndex = 52;
            this.btn_calcu.Text = "Calculator";
            this.btn_calcu.TextColor = System.Drawing.Color.White;
            this.btn_calcu.UseVisualStyleBackColor = false;
            this.btn_calcu.Click += new System.EventHandler(this.btn_calcu_Click);
            // 
            // btn_volume
            // 
            this.btn_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_volume.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_volume.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_volume.BorderRadius = 5;
            this.btn_volume.BorderSize = 0;
            this.btn_volume.FlatAppearance.BorderSize = 0;
            this.btn_volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volume.ForeColor = System.Drawing.Color.White;
            this.btn_volume.Location = new System.Drawing.Point(5, 103);
            this.btn_volume.Name = "btn_volume";
            this.btn_volume.Size = new System.Drawing.Size(194, 44);
            this.btn_volume.TabIndex = 49;
            this.btn_volume.Text = "Volume";
            this.btn_volume.TextColor = System.Drawing.Color.White;
            this.btn_volume.UseVisualStyleBackColor = false;
            // 
            // btn_length
            // 
            this.btn_length.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_length.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_length.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_length.BorderRadius = 5;
            this.btn_length.BorderSize = 0;
            this.btn_length.FlatAppearance.BorderSize = 0;
            this.btn_length.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_length.ForeColor = System.Drawing.Color.White;
            this.btn_length.Location = new System.Drawing.Point(6, 53);
            this.btn_length.Name = "btn_length";
            this.btn_length.Size = new System.Drawing.Size(194, 44);
            this.btn_length.TabIndex = 51;
            this.btn_length.Text = "Length";
            this.btn_length.TextColor = System.Drawing.Color.White;
            this.btn_length.UseVisualStyleBackColor = false;
            this.btn_length.Click += new System.EventHandler(this.btn_length_Click);
            // 
            // TimerAnim
            // 
            this.TimerAnim.Enabled = true;
            this.TimerAnim.Interval = 10;
            this.TimerAnim.Tick += new System.EventHandler(this.TimerAnim_Tick);
            // 
            // length1
            // 
            this.length1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.length1.Location = new System.Drawing.Point(0, 0);
            this.length1.Name = "length1";
            this.length1.Size = new System.Drawing.Size(320, 378);
            this.length1.TabIndex = 49;
            this.length1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(332, 376);
            this.Controls.Add(this.btn_sideMenu);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.length1);
            this.Controls.Add(this.btn_clrtxtbox);
            this.Controls.Add(this.btn_onepx);
            this.Controls.Add(this.btn_neg);
            this.Controls.Add(this.lbl_hello);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_square2);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_delone);
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
            this.Controls.Add(this.tbox_number1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_hello;
        private TextBox tbox_number1;
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
        private CustomControls.RJControls.RJButton btn_delone;
        private CustomControls.RJControls.RJButton btn_div;
        private CustomControls.RJControls.RJButton btn_square2;
        private CustomControls.RJControls.RJButton btn_c;
        private CustomControls.RJControls.RJButton btn_neg;
        private CustomControls.RJControls.RJButton btn_onepx;
        private CustomControls.RJControls.RJButton btn_clrtxtbox;
        private CustomControls.RJControls.RJButton btn_sideMenu;
        private FlowLayoutPanel sideMenu;
        private Panel panel1;
        private CustomControls.RJControls.RJButton btn_volume;
        private System.Windows.Forms.Timer TimerAnim;
        private CustomControls.RJControls.RJButton btn_length;
        private Length length1;
        private CustomControls.RJControls.RJButton btn_calcu;
    }
}