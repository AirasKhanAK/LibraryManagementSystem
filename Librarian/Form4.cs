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
    public partial class Form4 : Form
    {
        
      
        public Form4()
        {
            InitializeComponent();
        }

        Form2 frm2 = new Form2();
        Records rec = new Records();
        Book_Issue book = new Book_Issue();

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            book.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(0, 150, 136), 8),
                           this.DisplayRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rec.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
