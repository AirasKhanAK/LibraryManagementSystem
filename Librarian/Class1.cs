using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Librarian
{
    
    class Class1
    {
        public string username;
        public string password;
        public bool cond = false;

        public void usercheck() {
            string[] lines = File.ReadAllLines(@"accounts.txt");
            int len0 = lines.Length; //len0 is lines lenght
            int len1 = lines[0].Split(':').Length;  //len1 is basically columns lenght
            string[,] accounts = new string[len0, len1];
            for (int i = 0; i < len0; i++)
            {
                string line = lines[i];
                string[] column = line.Split(':');
                if (column.Length != len1) //Added this condition so if there is any bad pattern in file the program wont break
                    continue;
                for (int j = 0; j < len1; j++)
                {
                    accounts[i,j] = column[j];
                }
            }

            for (int i = 0; i < accounts.GetLength(0); i++)
            {
                if (username.ToLower() == accounts[i, 0] && password == accounts[i, 1]) { cond = true; }

            }

            
        }
    }

  
}
