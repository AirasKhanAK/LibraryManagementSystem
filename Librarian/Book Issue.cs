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
    public partial class Book_Issue : Form
    {
        public Book_Issue()
        {
            InitializeComponent();
        }

        private void Book_Issue_Load(object sender, EventArgs e)
        {

           
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


        Form3 frm3 = new Form3();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                 frm3.serial = row.Cells[0].Value.ToString();
                 frm3.bookname = row.Cells[1].Value.ToString();               
                 frm3.author = row.Cells[2].Value.ToString();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            frm3.Show();  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            Hide();
        }
    }
}

