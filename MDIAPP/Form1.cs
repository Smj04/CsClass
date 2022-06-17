using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("내용");

                DialogResult result;
            do
            {
                DialogResult = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning); 

            }while (DialogResult == DialogResult.Retry);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
           // form.MdiParent = this;
            form.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            form.ShowDialog();
        }
    }
}
