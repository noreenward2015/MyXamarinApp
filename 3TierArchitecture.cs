using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.BLL;
namespace WindowsFormsApplication1
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PersonBLL p = new PersonBLL();
                this.dataGridView1.DataSource = p.GetPersons(Convert.ToInt16(this.txtID.Text));
            }
            catch
            {
                MessageBox.Show("Error Occurred");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                PersonBLL p = new PersonBLL();
                this.dataGridView1.DataSource = p.GetPersons();
            }
            catch
            {
                MessageBox.Show("Error Occurred");
            }
        }
    }
}