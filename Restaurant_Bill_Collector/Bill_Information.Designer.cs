namespace Restaurant_Bill_Collector
{
    partial class Bill_Information
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_Information));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Bev = new System.Windows.Forms.ComboBox();
            this.comboBox_App = new System.Windows.Forms.ComboBox();
            this.comboBox_Main = new System.Windows.Forms.ComboBox();
            this.comboBox_Des = new System.Windows.Forms.ComboBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.subtotal_textBox = new System.Windows.Forms.TextBox();
            this.tax_textBox = new System.Windows.Forms.TextBox();
            this.total_textBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beverage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Appetizer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Main Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dessert";
            // 
            // comboBox_Bev
            // 
            this.comboBox_Bev.FormattingEnabled = true;
            this.comboBox_Bev.Location = new System.Drawing.Point(110, 85);
            this.comboBox_Bev.Name = "comboBox_Bev";
            this.comboBox_Bev.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Bev.TabIndex = 2;
            // 
            // comboBox_App
            // 
            this.comboBox_App.FormattingEnabled = true;
            this.comboBox_App.Location = new System.Drawing.Point(110, 33);
            this.comboBox_App.Name = "comboBox_App";
            this.comboBox_App.Size = new System.Drawing.Size(121, 21);
            this.comboBox_App.TabIndex = 1;
            this.comboBox_App.SelectedIndexChanged += new System.EventHandler(this.comboBox_App_SelectedIndexChanged);
            // 
            // comboBox_Main
            // 
            this.comboBox_Main.FormattingEnabled = true;
            this.comboBox_Main.Location = new System.Drawing.Point(110, 135);
            this.comboBox_Main.Name = "comboBox_Main";
            this.comboBox_Main.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Main.TabIndex = 3;
            // 
            // comboBox_Des
            // 
            this.comboBox_Des.FormattingEnabled = true;
            this.comboBox_Des.Location = new System.Drawing.Point(110, 180);
            this.comboBox_Des.Name = "comboBox_Des";
            this.comboBox_Des.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Des.TabIndex = 4;
            // 
            // Add_button
            // 
            this.Add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Add_button.Location = new System.Drawing.Point(263, 108);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 5;
            this.Add_button.Text = "Add item>>";
            this.Add_button.UseVisualStyleBackColor = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total";
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(551, 306);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(75, 23);
            this.Clear_button.TabIndex = 6;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(516, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(623, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Price";
            // 
            // listView
            // 
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(385, 36);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(366, 165);
            this.listView.TabIndex = 22;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // subtotal_textBox
            // 
            this.subtotal_textBox.Location = new System.Drawing.Point(651, 216);
            this.subtotal_textBox.Name = "subtotal_textBox";
            this.subtotal_textBox.ReadOnly = true;
            this.subtotal_textBox.Size = new System.Drawing.Size(100, 20);
            this.subtotal_textBox.TabIndex = 23;
            this.subtotal_textBox.Text = "$0.00";
            // 
            // tax_textBox
            // 
            this.tax_textBox.Location = new System.Drawing.Point(651, 246);
            this.tax_textBox.Name = "tax_textBox";
            this.tax_textBox.ReadOnly = true;
            this.tax_textBox.Size = new System.Drawing.Size(100, 20);
            this.tax_textBox.TabIndex = 24;
            this.tax_textBox.Text = "$0.00";
            // 
            // total_textBox
            // 
            this.total_textBox.Location = new System.Drawing.Point(651, 277);
            this.total_textBox.Name = "total_textBox";
            this.total_textBox.ReadOnly = true;
            this.total_textBox.Size = new System.Drawing.Size(100, 20);
            this.total_textBox.TabIndex = 25;
            this.total_textBox.Text = "$0.00";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Bill_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 372);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.total_textBox);
            this.Controls.Add(this.tax_textBox);
            this.Controls.Add(this.subtotal_textBox);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.comboBox_Des);
            this.Controls.Add(this.comboBox_Main);
            this.Controls.Add(this.comboBox_App);
            this.Controls.Add(this.comboBox_Bev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bill_Information";
            this.Text = "Restaurant Bill Calculator";
            this.Load += new System.EventHandler(this.Bill_Information_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Bev;
        private System.Windows.Forms.ComboBox comboBox_App;
        private System.Windows.Forms.ComboBox comboBox_Main;
        private System.Windows.Forms.ComboBox comboBox_Des;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox subtotal_textBox;
        private System.Windows.Forms.TextBox tax_textBox;
        private System.Windows.Forms.TextBox total_textBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

