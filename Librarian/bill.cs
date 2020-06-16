using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Librarian
{
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public string fullname, bookname, price, day, returnday;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bill_Load(object sender, EventArgs e)
        {
            label11.Text = fullname;
            label10.Text = bookname;
            label9.Text = returnday;
            label8.Text = day;
            label7.Text = price;
        }
    }
}
