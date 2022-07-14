namespace Calc0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        decimal a = 0, b = 0, c = 0;
        char z = '+';

        private void button7_Click(object sender, EventArgs e) // Результат "="
        {
            b = Convert.ToDecimal(textBox1.Text);

            switch (z)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    if (b == 0)
                    {
                        MessageBox.Show("Я не умею делить на ноль =(");
                        textBox1.Text = "Ошибка";
                    }
                    break;
            }
            textBox1.Text = c.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e) // Сложение
        {
            a = Convert.ToDecimal(textBox1.Text);
            z = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button3_Click(object sender, EventArgs e) // Вычитание
        {
            a = Convert.ToDecimal(textBox1.Text);
            z = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e) // Деление
        {
            a = Convert.ToDecimal(textBox1.Text);
            z = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e) // Умножение
        {
            a = Convert.ToDecimal(textBox1.Text);
            z = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e) // Загрузка формы
        {

        }
    }
}