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

        private List<InputedData> _list = new List<InputedData>();
        private List<InputedData> _listFibonaci = new List<InputedData>();


        private void GenerateSimplyInt(object obj)
        {
            if (obj is null)
                return;

            InputedData data = (InputedData)obj;

            for (int i = data.MinVal; i < data.MaxVal; i++)
            {

                if (data.IsEnded == true)
                    break;

                if (data.IsPaused == true)
                    while (true)
                    {
                        if (data.IsPaused == false)
                            break;
                        if (data.IsEnded == true)
                            break;
                    }


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
                        listBox_ViewResult.Items.Add(i.ToString());
                    }
                }

                Thread.Sleep(100);
                listBox_ViewResult.SelectedIndex = listBox_ViewResult.Items.Count - 1;

            }
            data.IsEnded = true;
            HowManySimplyIntThreads();
            listBox_ViewResult.Items.Add($"ÏÎÒÎÊ {Thread.CurrentThread.Name} ÇÀÊÎÍ×ÅÍ ");
            listBox_ViewResult.SelectedIndex = listBox_ViewResult.Items.Count - 1;

        }


        private void GenerateFibonacyInt(object obj)
        {
            if (obj is null)
                return;

            InputedData data = (InputedData)obj;

            int[] array = new int[40];


            for (int i = 0; i < 40; ++i)
            {
                if (data.IsEnded == true) { break; }

                if (data.IsPaused == true)
                    while (true)
                    {
                        if (data.IsPaused == false)
                            break;
                        if (data.IsEnded == true)
                            break;
                    }

                array[i] = i < 2 ? 1 : array[i - 2] + array[i - 1];

                listBox_ViewFibonachi.Items.Add(array[i]);

                Thread.Sleep(100);

                listBox_ViewFibonachi.SelectedIndex = listBox_ViewFibonachi.Items.Count - 1;
            }

            data.IsEnded = true;
            HowManyFibIntThreads();
            listBox_ViewFibonachi.Items.Add($"ÏÎÒÎÊ {Thread.CurrentThread.Name} ÇÀÊÎÍ×ÅÍ ");
            listBox_ViewFibonachi.SelectedIndex = listBox_ViewFibonachi.Items.Count - 1;

        }

        private void HowManySimplyIntThreads()
        {
            int count = 0;

            foreach (InputedData item in _list)
            {
                if (item.IsEnded == false)
                    count++;
            }

            label_howManyThreads.Text = count.ToString();
        }

        private void HowManyFibIntThreads()
        {
            int count = 0;

            foreach (InputedData item in _listFibonaci)
            {
                if (item.IsEnded == false)
                    count++;
            }

            label_CountThreadsFibonacy.Text = count.ToString();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ãåíåðèðóåò ïðîñòûå ÷èñëà
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_GenereteSimlyInt_Click(object sender, EventArgs e)
        {
            InputedData inputedData;

            /////////////ÏÐÎÂÅÐÊÀ
            if (textBox_MaxValue.Text.Length > 0 &&
                textBox_MinValue.Text.Length > 0 &&
                textBox_MaxValue.Text.Length <= 8 &&
                textBox_MinValue.Text.Length <= 8
                )
                inputedData = new InputedData()
                {
                    IsEnded = false,
                    IsPaused = false,
                    MaxVal = Int32.Parse(textBox_MaxValue.Text),
                    MinVal = Int32.Parse(textBox_MinValue.Text),
                };
            else
                inputedData = new InputedData()
                {
                    IsEnded = false,
                    IsPaused = false,
                    MaxVal = 0,
                    MinVal = 0,
                };
            /////////////ÏÐÎÂÅÐÊÀ----ÊÎÍÅÖ

            textBox_MaxValue.Clear();
            textBox_MinValue.Clear();

            _list.Add(inputedData);

            Thread thread = new Thread(new ParameterizedThreadStart(GenerateSimplyInt));
            thread.Name = $"{DateTime.Now.Millisecond}";

            thread.Start(inputedData);
            HowManySimplyIntThreads();
        }

        private void button_GenerateFib_Click(object sender, EventArgs e)
        {
            InputedData inputedData = new InputedData()
            {
                IsEnded = false,
                IsPaused = false,
                MaxVal = 0,
                MinVal = 0,
            };

            _listFibonaci.Add(inputedData);

            Thread thread = new Thread(new ParameterizedThreadStart(GenerateFibonacyInt));
            thread.Name = $"{DateTime.Now.Second}{DateTime.Now.Millisecond}";

            thread.Start(inputedData);

            HowManyFibIntThreads();
        }
        private void textBox_MinValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_RestartTreads_Click(object sender, EventArgs e)
        {
            foreach (InputedData inputedData in _list)
            {
                inputedData.IsEnded = true;

            }
        }

        private void button_StopThreadsFibonacy_Click(object sender, EventArgs e)
        {
            foreach (InputedData inputedData in _listFibonaci)
            {
                inputedData.IsEnded = true;

            }
        }

        private void button_RestartSimplyInt_Click(object sender, EventArgs e)
        {
            foreach (InputedData inputedData in _list)
            {
                inputedData.IsEnded = true;

            }
            _list.Clear();
        }

        private void button_PauseThreadsSimpleInt_Click(object sender, EventArgs e)
        {
            foreach (InputedData inputedData in _list)
            {
                inputedData.IsPaused = true;
            }
        }

        private void button_ResumeThreadsSimplInt_Click(object sender, EventArgs e)
        {
            foreach (InputedData inputedData in _list)
            {
                inputedData.IsPaused = false;
            }
        }

        private void button_PauseFibThread_Click(object sender, EventArgs e)
        {
            foreach (InputedData inputedData in _listFibonaci)
            {
                inputedData.IsPaused = true;
            }
        }

        private void button_resumeFibThreads_Click(object sender, EventArgs e)
        {
            foreach (InputedData inputedData in _listFibonaci)
            {
                inputedData.IsPaused = false;
            }
        }

        private void button_RestartThreads_Click(object sender, EventArgs e)
        {
            foreach (InputedData inputedData in _listFibonaci)
            {
                inputedData.IsEnded = true;

            }
            _listFibonaci.Clear();
        }
    }


    public class InputedData
    {
        private int _minVal;
        private int _maxVal;



        public int MinVal
        {
            get { return _minVal; }
            set
            {
                if (value < 2 && value > int.MaxValue)
                    _minVal = 2;
                else
                    _minVal = value;
            }
        }
        public int MaxVal
        {
            get { return _maxVal; }

            set
            {
                if (value < 2 || value > int.MaxValue)
                    _maxVal = int.MaxValue;
                else
                    _maxVal = value;

            }
        }

        public bool IsPaused { get; set; }
        public bool IsEnded { get; set; }
    }


}