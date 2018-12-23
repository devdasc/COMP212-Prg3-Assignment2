using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Username_textBox.Clear();
            Password_textBox.Clear();
            Username_textBox.Focus();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string userName = "root";
            string pass = "pass";
            if (Username_textBox.Text == "" || Password_textBox.Text == "")
                MessageBox.Show("You can't leave any ogf the field empty!");
            else if((Username_textBox.Text== userName) && (Password_textBox.Text ==pass))
            {
                MessageBox.Show("Welcome " + userName);
                Username_textBox.Clear();
                Password_textBox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password");
                Username_textBox.Clear();
                Password_textBox.Clear();
                Username_textBox.Focus();

            }

        }
    }
}
