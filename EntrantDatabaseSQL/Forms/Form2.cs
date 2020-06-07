using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntrantDatabaseSQL
{
    public partial class Form2 : Form
    {
        private static int checkPassCount = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkPassCount++;
            Controls.Clear();
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button4);
            label1.Visible = true;
            textBox1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            if (checkPassCount == 1)
            {
                button3.Click += CheckPass;
            }
        }
        private void CheckPass(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kolbasa33")
            {
                textBox1.Text = "";
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Неправильний пароль");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(button1);
            Controls.Add(button2);
        }
    }
}
