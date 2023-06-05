namespace MultithreadingAsynchrony
{
    public partial class MainWindow : Form
    {

        private Color GetRandomColor()
        {
            Random random = new Random();

            random.Next();

            return Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

        }

        private void GenerateSimplyInt()
        {

            for (int i = 2; i < 50; i++)
            {
                if (i > 1)
                {
                    int count = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }

                    if (count == 2)
                    {
                        listBox_ViewResult.Invoke(() => listBox_ViewResult.Items.Add(i));


                        //listBox_ViewResult.Items.Add(i.ToString());



                        //listBox_ViewResult.SelectedIndex = listBox_ViewResult.Items.Count - 1;
                    }
                }
                Thread.Sleep(100);
            }


            listBox_ViewResult.Items.Add($"����� �������� ");
        }

        private List<Thread> _listTread = new List<Thread>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_GenereteSimlyInt_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(GenerateSimplyInt);
            _listTread.Add(thread);

            thread.Start();


        }

        private void textBox_MinValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_RestartTreads_Click(object sender, EventArgs e)
        {
            foreach (Thread item in _listTread)
            {
                listBox_ViewResult.Text = ($"�����: ( {item.Name} ), �� ���> {item.IsAlive}");
            }
        }
    }


    public class InputedData
    {
        public int MinVal { get; set; }
        public int MaxVal { get; set; }
    }


}