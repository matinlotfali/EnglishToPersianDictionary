using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dictionary_in_2_lines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Refresh();

            string Meaning;
            Dictionary.Search(comboBox1.Text, out Meaning, true);

            richTextBox1.Text = Meaning;
            comboBox1.SelectAll();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Refresh();

            Dictionary.LoadWordsFromFile("dic.txt", comboBox1);
            Dictionary.MakeList(comboBox1);

            richTextBox1.Enabled = true;
            button1.Enabled = true;
            comboBox1.Enabled = true;
            label1.Enabled = true;
            comboBox1.Focus();
        }
    }
}
