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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // the button is set to generate this action, you don't need to explecitly trigger the button 
            textBox1.Text = "Clicked on the button";
            MessageBox.Show("Something has been shown", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        // use this name to manipulate the object (textBox1) is created during the design of the form 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            
        }

        //Next Button 
        private void button2_Click(object sender, EventArgs e)
        {
            // Call another form when clickin the button 
            OtherForm other = new OtherForm();
            other.InitialSet();
            // Show the form 
            //other.ShowDialog();
            other.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();
            check.Name = "BOX";
            check.HeaderText = "PPP";
            // checks are created based on the number of elements in the data grid view, change index and clean he view everytime the method is executed 
            check.ReadOnly = true;
           
        }
    }
}
