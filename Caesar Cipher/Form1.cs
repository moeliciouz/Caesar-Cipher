using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string klarText = richTextBox1.Text;
            string Verschlüsselung = "";
            for (int i = 0; i < klarText.Length; i++)
            {
                klarText = klarText.ToLower();

                if (klarText[i] + numericUpDown1.Value >= 123)
                    Verschlüsselung += (char)((96 + (klarText[i] + numericUpDown1.Value)) % 122);

                else if (klarText[i] + numericUpDown1.Value <= 96)
                    Verschlüsselung += (char)(((klarText[i] + numericUpDown1.Value) + 26) % 123);

                else Verschlüsselung += (char)((klarText[i] + numericUpDown1.Value) % 122);

                richTextBox2.Text = Verschlüsselung;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Cipher = richTextBox2.Text;
            string Entschlüsselung = "";
            for (int i = 0; i < Cipher.Length; i++)
            {
                Cipher = Cipher.ToLower();

                if (Cipher[i] - numericUpDown1.Value >= 123)
                    Entschlüsselung += (char)((96 + (Cipher[i] - numericUpDown1.Value)) % 122);

                else if (Cipher[i] - numericUpDown1.Value <= 96)
                    Entschlüsselung += (char)(((Cipher[i] - numericUpDown1.Value) + 26) % 122);

                else Entschlüsselung += (char)((Cipher[i] - numericUpDown1.Value) % 122);

                richTextBox1.Text = Entschlüsselung;
            }
        }
    }
}
