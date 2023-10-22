using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApplicationPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button != null)
            {
                //MessageBox.Show("Hello World");
                MessageBox.Show(button.Height.ToString());
            }
        }
    }
}
