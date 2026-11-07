namespace Практическая

    // Работу выполнили Седаш и Арбузов
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Fom1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Treug tr = new Treug (textBox1.Text, double.Parse(textBox2.Text), double.Parse(textBox3.Text));
        MessageBox.Show(tr.inf() + " с площадью " + tr.pl());
    }
}
}
