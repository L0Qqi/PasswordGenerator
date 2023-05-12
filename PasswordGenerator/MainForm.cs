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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PasswordGenerator
{
    public partial class MainForm : Form
    {
        private readonly Random random = new Random();

        private const string LowerChars = "abcdefghjklmnpqrstuvwxyz";
        private const string UpperChars = "ABCDEFGHJKMNPQRSTUVWXYZ";
        private const string NumberChars = "23456789";
        private const string SymbolsChars = "!@#$%^&*()_+-=[]{}|;:,./?><";
        private const string SameChars = "iI1Lo0O";
        public MainForm()
        {
            InitializeComponent();
        }

        private void passGenerateB_Click(object sender, EventArgs e)
        {
            int passwordLength = (int)passLengthNUD.Value;
            bool includeLowerChars = lowerCharsCB.Checked;
            bool includeUpperChars = upperCharsCB.Checked;
            bool includeNumersChars = numbersCharsCB.Checked;
            bool includeSymbolsChars = symbolsCharCB.Checked;
            bool includeSameChars = sameCB.Checked;
            

            string charPool = "";

            if (includeLowerChars)
            {
                charPool += LowerChars;
            }

            if (includeUpperChars)
            {
                charPool += UpperChars;
            }

            if (includeNumersChars)
            {
                charPool += NumberChars;
            }

            if (includeSymbolsChars)
            {
                charPool += SymbolsChars;
            }
            if (includeSameChars)
            {
                charPool += SameChars;
            }

            if (charPool.Length == 0)
            {
                MessageBox.Show("Выберите параметры для генерации");
                return;
            }

            char[] password = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
            {
                password[i] = charPool[random.Next(charPool.Length)];
            }
            passwordTB.Text = new string(password);

            
        }

        private void savePassB_Click(object sender, EventArgs e)
        {
            string password = passwordTB.Text;
            string login = loginTB.Text;

            using (StreamWriter sw = new StreamWriter(@"./../../Passwords.txt", true))
            {
                sw.WriteLine($"{login}|{password}"); // Сохраняем каждое слово на новой строке
            }

        }

        private void toPassListB_Click(object sender, EventArgs e)
        {
            
            PassListForm passListForm = new PassListForm();
            passListForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
