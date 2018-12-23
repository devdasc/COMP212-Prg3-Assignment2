using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class LogInControl : UserControl
    {
        public LogInControl()
        {
            InitializeComponent();
        }

        private void LogInControl_Load(object sender, EventArgs e)
        {

        }
        public string getUsername()
        {
            return textBox1.Text;
        }

        public string getPassword()
        {
            return textBox2.Text;
        }
    }
}
