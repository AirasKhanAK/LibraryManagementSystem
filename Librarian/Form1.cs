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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Parent = this;
            pictureBox2.BackColor = Color.Transparent;
            this.ActiveControl = button1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
         
            
        }
        Class1 user = new Class1();
       
        
        public static string username;
        public void button1_Click(object sender, EventArgs e)
        {

            Form4 frm4 = new Form4();
            user.username = textBox1.Text;
            username = user.username;
            user.password = textBox2.Text;
            
            user.usercheck();
            if (user.cond == true)
            {
                
                frm4.Show();
                this.Hide();
            }
            else {MessageBox.Show("Username / Password dont match | try again"); }

        }
       

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password") { 
            textBox2.UseSystemPasswordChar = true;
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("new");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registration register = new Registration();
            register.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
    }
}
