namespace Пракктическая_16

    // работу выполнили Седаш и Арбузов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vNewChildForm(null);
        }
        private void vNewChildForm(string sS)
        {
            int vI = 0;
            Form2 child = new Form2(this);
            child.MdiParent = this;
            foreach (Form2 mdicf in this.MdiChildren)
            {
                vI++;

                if (mdicf.Text != "Окно № " + Convert.ToString(vI))
                {
                    break;
                }
            }
            child.Text = "Окно № " + Convert.ToString(vI);
            child.Show();
            LayoutMdi(MdiLayout.Cascade);

        }

        private void закрытьВсеДочерниеФормыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren) // в цикле перебираем все формы
            {
                child.Close();
            }
        }

        private void приемСообщенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form2 child in MdiChildren)
            {
                child.vSetPhrase("Всем студентам - С праздником 9 мая!");
            }
        }
        public void vSetText(string s)
        {
            MessageBox.Show("Мне прислали сообщение: " + s);
        }
    }
}
