using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Letterfrequenties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string stringToASCII(char c)
        {
            string finalValue = "";
            byte[] ascii = Encoding.ASCII.GetBytes(c.ToString());
            foreach (Byte b in ascii)
            {
                finalValue += b.ToString("X");
            }
            return finalValue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number = 0;
            string userInput = textBox1.Text;
            char charUserInput = userInput[0];
            Output.Visible = true;
            string text = System.IO.File.ReadAllText(@"C:\Users\Boas\Desktop\a.txt");
            char[] charArray = text.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (stringToASCII(charUserInput) == stringToASCII(charArray[i]))
                {
                    number++;
                }
            }
            Output.Text = "Letter found (" + number.ToString() + ") times";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
