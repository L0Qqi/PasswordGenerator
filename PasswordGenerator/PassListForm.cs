using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PassListForm : Form
    {
        public PassListForm()
        {
            InitializeComponent();

            passListDGV.Columns.Add("Login", "Логин");
            passListDGV.Columns.Add("Password", "Пароль");

            try
            {
                using (StreamReader sr = new StreamReader(@"./../../Passwords.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string word = sr.ReadLine();
                        string[] parts = word.Split('|');
                        string login = parts[0]; 
                        string password = parts[1];
                        passListDGV.Rows.Add(login, password); 
                        
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
