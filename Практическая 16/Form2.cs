using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Пракктическая_16
{
    public partial class Form2 : Form
    {
        private Form1 fmParent = null;

        public Form2()
        {
            InitializeComponent();

        }
        public Form2(Form1 fmParent)
        {
            this.fmParent = fmParent;
            InitializeComponent();
        }
        public void vSetPhrase(string s)
        {
            label1.Text = s;
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmParent.vSetText("Я, Ваша дочка \"" + Text + "\" закрылась!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = ParentForm.Name;
            MessageBox.Show("Мой родитель " + s + ".");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
