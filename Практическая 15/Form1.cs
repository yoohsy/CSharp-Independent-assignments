namespace Практическая_15
{
    public partial class Form1 : Form
    {
        private readonly string filePath =
        Path.Combine(Application.StartupPath, "vbbook.txt");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("vbbook.txt");
            if (file.Exists == false)
            {
                file.Create().Close(); // Close() освобождает файл
            }
            else
            {
                MessageBox.Show("Файл уже создан");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("vbbook.txt");
            if (file.Exists == true)
            {
                file.Delete();
            }
            else
            {
                MessageBox.Show("Файла не существует");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("vbbook.txt");
            while (!streamReader.EndOfStream)
            {
                textBox1.Text += streamReader.ReadLine() + "\r\n";
            }
            streamReader.Close();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Сначала создайте файл");
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter write_text;
            FileInfo file = new FileInfo("vbbook.txt");
            write_text = file.AppendText();
            write_text.WriteLine(textBox1.Text);
            write_text.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = 0;
            int sum = 0;
            int max = int.MinValue;

            StreamReader streamReader = new StreamReader("vbbook.txt");
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                int n;
                if (int.TryParse(line.Trim(), out n))
                {
                    count++;
                    sum += n;
                    if (n > max) max = n;
                }
            }
            streamReader.Close();

            if (count == 0)
            {
                MessageBox.Show("В файле нет чисел");
                return;
            }
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Сначала создайте файл");
                return;
            }

            double average = (double)sum / count;

            // Дописываем результат в конец файла
            StreamWriter write_text = new FileInfo("vbbook.txt").AppendText();
            write_text.WriteLine("Количество чисел: " + count);
            write_text.WriteLine("Максимальный элемент: " + max);
            write_text.WriteLine("Среднее арифметическое: " + average.ToString("F2"));
            write_text.Close();

            label1.Text = "Результат записан в файл";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
