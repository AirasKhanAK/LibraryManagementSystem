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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();

            string[] lines = File.ReadAllLines(@"records.txt");
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
   

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Records_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void savetofile()
        {

            TextWriter writer = new StreamWriter(@"records.txt");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j > 7)
                    {
                        writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                    else { writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + ":"); }
                }
                writer.WriteLine();
            }
            writer.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            savetofile(); 
                }

        private void Records_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(0, 150, 136), 8),
                           this.DisplayRectangle);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }
    }
}
