namespace CalculatorGUI
{
    partial class Length
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbox_from = new System.Windows.Forms.TextBox();
            this.txbox_to = new System.Windows.Forms.TextBox();
            this.combo_to = new System.Windows.Forms.ComboBox();
            this.combo_form = new System.Windows.Forms.ComboBox();
            this.btn_toconvert = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // txbox_from
            // 
            this.txbox_from.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txbox_from.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbox_from.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbox_from.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbox_from.Location = new System.Drawing.Point(88, 15);
            this.txbox_from.Name = "txbox_from";
            this.txbox_from.Size = new System.Drawing.Size(205, 54);
            this.txbox_from.TabIndex = 0;
            this.txbox_from.Text = "0";
            this.txbox_from.TextChanged += new System.EventHandler(this.txbox_from_TextChanged);
            // 
            // txbox_to
            // 
            this.txbox_to.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txbox_to.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbox_to.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbox_to.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbox_to.Location = new System.Drawing.Point(88, 232);
            this.txbox_to.Name = "txbox_to";
            this.txbox_to.Size = new System.Drawing.Size(205, 54);
            this.txbox_to.TabIndex = 1;
            this.txbox_to.Text = "0";
            // 
            // combo_to
            // 
            this.combo_to.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_to.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_to.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.combo_to.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_to.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.combo_to.FormattingEnabled = true;
            this.combo_to.Items.AddRange(new object[] {
            "meters",
            "kilometers",
            "centimeters",
            "millimeters",
            "feet",
            "inches",
            "yards",
            "miles",
            "nautical miles"});
            this.combo_to.Location = new System.Drawing.Point(88, 311);
            this.combo_to.Name = "combo_to";
            this.combo_to.Size = new System.Drawing.Size(121, 23);
            this.combo_to.TabIndex = 2;
            // 
            // combo_form
            // 
            this.combo_form.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combo_form.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.combo_form.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_form.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.combo_form.FormattingEnabled = true;
            this.combo_form.Items.AddRange(new object[] {
            "meters",
            "kilometers",
            "centimeters",
            "millimeters",
            "feet",
            "inches",
            "yards",
            "miles",
            "nautical miles"});
            this.combo_form.Location = new System.Drawing.Point(88, 100);
            this.combo_form.Name = "combo_form";
            this.combo_form.Size = new System.Drawing.Size(121, 23);
            this.combo_form.TabIndex = 3;
            this.combo_form.SelectedIndexChanged += new System.EventHandler(this.combo_form_SelectedIndexChanged);
            // 
            // btn_toconvert
            // 
            this.btn_toconvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_toconvert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_toconvert.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_toconvert.BorderRadius = 0;
            this.btn_toconvert.BorderSize = 0;
            this.btn_toconvert.FlatAppearance.BorderSize = 0;
            this.btn_toconvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_toconvert.ForeColor = System.Drawing.Color.White;
            this.btn_toconvert.Location = new System.Drawing.Point(76, 175);
            this.btn_toconvert.Name = "btn_toconvert";
            this.btn_toconvert.Size = new System.Drawing.Size(150, 40);
            this.btn_toconvert.TabIndex = 4;
            this.btn_toconvert.Text = "Convert";
            this.btn_toconvert.TextColor = System.Drawing.Color.White;
            this.btn_toconvert.UseVisualStyleBackColor = false;
            this.btn_toconvert.Click += new System.EventHandler(this.btn_toconvert_Click);
            // 
            // Length
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btn_toconvert);
            this.Controls.Add(this.combo_form);
            this.Controls.Add(this.combo_to);
            this.Controls.Add(this.txbox_to);
            this.Controls.Add(this.txbox_from);
            this.Name = "Length";
            this.Size = new System.Drawing.Size(335, 415);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbox_from;
        private TextBox txbox_to;
        private ComboBox combo_to;
        private ComboBox combo_form;
        private CustomControls.RJControls.RJButton btn_toconvert;
    }
}
