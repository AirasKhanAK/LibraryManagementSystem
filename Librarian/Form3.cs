using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Librarian
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(7);
            dateTimePicker1.Enabled = false;
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(7);
            finalprice();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public int price;
        public double discount;

        void finalprice() {
            double perc = (Convert.ToDouble(numericUpDown1.Value)) / 100 ;
            discount = perc * Convert.ToDouble(price);
            
            if (discount == 0)
            {
                label18.Text = (price).ToString();
            }
            else { label18.Text = (price - discount).ToString(); }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int days = dateTimePicker2.Value.Day - dateTimePicker1.Value.Day;
            label20.Text = Convert.ToString(days);
            int baseprice = Convert.ToInt32(label21.Text);

            if (days >= 8)
            {
                price = days * 50;
                label21.Text = Convert.ToString(price);
                
            }

            else if (days == 7) {
                price = 7 * 50;
                label21.Text = Convert.ToString(price);
            }
            finalprice();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            finalprice();
        }

        public string bookname , author , serial;

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("records.txt");
            int len = lines.Length+1;
            File.AppendAllText("records.txt", Environment.NewLine +len + ":" + textBox1.Text+ " " + textBox2.Text + ":" + textBox7.Text + ":" + textBox3.Text + ":" + textBox5.Text +":" + textBox4.Text + ":" + dateTimePicker2.Value.ToShortDateString()+":"+ label18.Text +":" + "Not Returned");

            bill bill = new bill();
            bill.fullname = textBox1.Text + " " + textBox2.Text;
            bill.bookname = textBox7.Text;
            bill.returnday = dateTimePicker2.Value.ToShortDateString();
            bill.day = label20.Text ;
            bill.price = label18.Text;
            bill.Show();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(0, 150, 136), 8),
                           this.DisplayRectangle);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Book_Issue book = new Book_Issue();
            book.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            textBox6.Text = author;
            textBox7.Text = bookname;
            textBox8.Text = serial;
        }
    }
}
