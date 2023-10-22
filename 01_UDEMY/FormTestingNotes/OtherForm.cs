using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTestingNotes
{
    public partial class OtherForm : Form
    {
        public OtherForm()
        {
            InitializeComponent();
        }

        public void InitialSet()
        {
            textBox1.Text = "Hello World!";
        }

        private void Hello_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Another Hello!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
