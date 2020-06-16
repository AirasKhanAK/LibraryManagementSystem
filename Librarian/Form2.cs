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
    public partial class Form2 : Form
    {
        public string welcome;
        public static string[,] books;
        public Form2()
        {          
           InitializeComponent();



            string[] lines = File.ReadAllLines(@"books.txt");
            int len0 = lines.Length;
            int len1 = lines[0].Split(':').Length;
            string[,] books = new string[len0, len1];
            for (int i = 0; i < len0; i++)
            {
                string line = lines[i];
                string[] column = line.Split(':');
                if (column.Length != len1)
                    continue;
                for (int j = 0; j < len1; j++)
                {
                    books[i, j] = column[j];
                }
            }

            for (int i = 0; i < books.GetLength(0); i++)
            {
                string[] row = new string[books.GetLength(1)];

                for (int j = 0; j < books.GetLength(1); j++)
                {
                    row[j] = books[i, j];
                }

                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
        Form1 frm1 = new Form1();

        void gridserial() {
            int rindex = dataGridView1.RowCount - 1;
            int sd = Convert.ToInt32(dataGridView1.Rows[rindex].Cells[0].Value) + 1;
            textBox1.Text = sd.ToString();
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";

        }

        void savetofile() {

            TextWriter writer = new StreamWriter(@"books.txt");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j > 2)
                    {
                        writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                    else { writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString()+ ":"); }
                }
                writer.WriteLine();
            }
            writer.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = button1;
            gridserial();   
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text);
            gridserial();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            savetofile();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(0, 150, 136), 8),
                           this.DisplayRectangle);
        }
    }
}
