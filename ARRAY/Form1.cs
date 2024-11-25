namespace ARRAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] student = new string[5];
            student[0] = "KIM";
            student[1] = "IQ";
            student[2] = "TATAH";
            student[3] = "NYONG";
            student[4] = "MICHAEL";
            string test = "";
            int n = student.Length;
            for (int i = 0; i < n; i++)
            {
                test += student[i] + Environment.NewLine;
            }
            MessageBox.Show(test);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruits = { "BANANA", "APPLE", "GRAPE", "ORANGE", "Melon", "Gomu Gomu no Mi" };
            string myFruit = "";
            foreach (string str in Fruits)
            {
                myFruit += str + ", ";
            }
            MessageBox.Show(myFruit, "My fruits");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines; //นำข้อมูลแต่ละบรรทัดไปใส่ใน array
            string result = "";
            foreach (string str in data)
            {
                if (str != "")
                {
                    result += str + Environment.NewLine;
                }

            }
            label1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            string result = "";
            int sum = 0;
            foreach (var str in data)
            {
                int x = 0;
                if (int.TryParse(str, out x))
                {
                    result += x.ToString() + Environment.NewLine;
                    sum += x;
                }
            }
            label1.Text = result;
            MessageBox.Show(sum.ToString(), "THE SUM");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "OPER";
            student[0, 1] = "BUNGKAN";
            student[1, 0] = "TATAH";
            student[1, 1] = "UDON";
            student[2, 0] = "M";
            student[2, 1] = "NONGBUALUMPHU";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j];
                    if (j < n - 1)
                    {
                        ResultData += "-";
                    }
                }
                ResultData += Environment.NewLine;
            }
            MessageBox.Show(ResultData, "Show data in array 2D");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Fruits = { "BANANA", "APPLE", "GRAPE", "ORANGE", "Melon", "Gomu Gomu no Mi" };
            comboBox1.Items.AddRange(Fruits);
            listBox1.Items.AddRange(Fruits);
            checkedListBox1.Items.AddRange(Fruits);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString();
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedIndex.ToString();
            str += listBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = checkedListBox1.SelectedIndex.ToString();
            str += checkedListBox1.SelectedItem;
            MessageBox.Show(str);
        }
    }
}
