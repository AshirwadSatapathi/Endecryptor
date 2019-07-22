using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endecryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Encrypts the message using the key as passed in the parameter.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string encryptMessage(string message, int key)
        {
            string result = "";
            foreach (char a in message)
            {
                //Console.WriteLine((int)a);
                char value = Convert.ToChar(a + key);
                result = result + value;
            }
            //Console.ReadLine();
            return result;
        }
        /// <summary>
        /// Decrypts the message using the key as passed in the parameter.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string decryptMessage(string message, int key)
        {
            string result = "";
            foreach (char a in message)
            {
                //Console.WriteLine((int)a);
                char value = Convert.ToChar(a - key);
                result = result + value;
            }
            //Console.ReadLine();
            return result;
        }
        private void OnClickAction(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            int key = Convert.ToInt32(textBox2.Text);
            string dialogBoxName = "";
            string value = "";
            bool isCheckedRadioButton1 = radioButton1.Checked;
            bool isCheckedRadioButton2 = radioButton2.Checked;
            if (message == "" && textBox2.Text == "")
            {
                MessageBox.Show("Enter all the information in all the box", "Alert");
            }
            else if (message == "" || textBox2.Text == "")
                MessageBox.Show("Enter all the information in all the box", "Alert");
            else
            {
                if (isCheckedRadioButton1)
                {
                    value = radioButton1.Text;
                    string encryptedMessage = encryptMessage(message, key);
                    dialogBoxName = "Encrypted Message";
                    MessageBox.Show(encryptedMessage, dialogBoxName);
                }
                else if (isCheckedRadioButton2)
                {
                    value = radioButton2.Text;
                    string decryptedMessage = decryptMessage(message, key);
                    dialogBoxName = "Decrypted Message";
                    MessageBox.Show(decryptedMessage, dialogBoxName);
                }
                else
                {
                    dialogBoxName = "Information";
                    value = "Please Choose either of the option";
                    MessageBox.Show(value, dialogBoxName);
                }
            }
        }
    }
}
