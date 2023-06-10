namespace MultithreadingAsynchrony
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            button_GenereteSimlyInt = new Button();
            textBox_MinValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_MaxValue = new TextBox();
            listBox_ViewResult = new ListBox();
            button_RestartTreadsSimplyInt = new Button();
            label_textInfo = new Label();
            label_description = new Label();
            label_howManyThreads = new Label();
            listBox_ViewFibonachi = new ListBox();
            label_FibonachiInfo = new Label();
            label3 = new Label();
            label_CountThreadsFibonacy = new Label();
            button_GenerateFib = new Button();
            button_StopThreadsFibonacy = new Button();
            button_PauseThreadsSimpleInt = new Button();
            button_ResumeThreadsSimplInt = new Button();
            button_RestartSimplyInt = new Button();
            button_PauseFibThread = new Button();
            button_resumeFibThreads = new Button();
            button_RestartThreads = new Button();
            SuspendLayout();
            // 
            // button_GenereteSimlyInt
            // 
            button_GenereteSimlyInt.BackColor = Color.LightGray;
            button_GenereteSimlyInt.Location = new Point(12, 71);
            button_GenereteSimlyInt.Name = "button_GenereteSimlyInt";
            button_GenereteSimlyInt.Size = new Size(190, 30);
            button_GenereteSimlyInt.TabIndex = 0;
            button_GenereteSimlyInt.Text = "Сгенерировать простые числа";
            button_GenereteSimlyInt.UseVisualStyleBackColor = false;
            button_GenereteSimlyInt.Click += button_GenereteSimlyInt_Click;
            // 
            // textBox_MinValue
            // 
            textBox_MinValue.Location = new Point(170, 6);
            textBox_MinValue.Name = "textBox_MinValue";
            textBox_MinValue.Size = new Size(85, 23);
            textBox_MinValue.TabIndex = 1;
            textBox_MinValue.KeyPress += textBox_MinValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 2;
            label1.Text = "Начать генерацию с числа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(200, 15);
            label2.TabIndex = 3;
            label2.Text = "Верхняя граница числа генерации:";
            // 
            // textBox_MaxValue
            // 
            textBox_MaxValue.Location = new Point(218, 34);
            textBox_MaxValue.Name = "textBox_MaxValue";
            textBox_MaxValue.Size = new Size(81, 23);
            textBox_MaxValue.TabIndex = 4;
            textBox_MaxValue.KeyPress += textBox_MinValue_KeyPress;
            // 
            // listBox_ViewResult
            // 
            listBox_ViewResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_ViewResult.FormattingEnabled = true;
            listBox_ViewResult.ItemHeight = 21;
            listBox_ViewResult.Location = new Point(0, 252);
            listBox_ViewResult.Name = "listBox_ViewResult";
            listBox_ViewResult.Size = new Size(299, 256);
            listBox_ViewResult.TabIndex = 5;
            // 
            // button_RestartTreadsSimplyInt
            // 
            button_RestartTreadsSimplyInt.Location = new Point(9, 107);
            button_RestartTreadsSimplyInt.Name = "button_RestartTreadsSimplyInt";
            button_RestartTreadsSimplyInt.Size = new Size(193, 22);
            button_RestartTreadsSimplyInt.TabIndex = 6;
            button_RestartTreadsSimplyInt.Text = "Остановить потоки";
            button_RestartTreadsSimplyInt.UseVisualStyleBackColor = true;
            button_RestartTreadsSimplyInt.Click += button_RestartTreads_Click;
            // 
            // label_textInfo
            // 
            label_textInfo.AutoSize = true;
            label_textInfo.Location = new Point(0, 218);
            label_textInfo.Name = "label_textInfo";
            label_textInfo.Size = new Size(175, 15);
            label_textInfo.TabIndex = 7;
            label_textInfo.Text = "Количество активных потоков";
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Location = new Point(0, 236);
            label_description.Name = "label_description";
            label_description.Size = new Size(255, 15);
            label_description.TabIndex = 8;
            label_description.Text = "Результат работы генератора простых чисел";
            // 
            // label_howManyThreads
            // 
            label_howManyThreads.AutoSize = true;
            label_howManyThreads.ForeColor = Color.Red;
            label_howManyThreads.Location = new Point(181, 218);
            label_howManyThreads.Name = "label_howManyThreads";
            label_howManyThreads.Size = new Size(13, 15);
            label_howManyThreads.TabIndex = 9;
            label_howManyThreads.Text = "0";
            // 
            // listBox_ViewFibonachi
            // 
            listBox_ViewFibonachi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_ViewFibonachi.FormattingEnabled = true;
            listBox_ViewFibonachi.ItemHeight = 21;
            listBox_ViewFibonachi.Location = new Point(314, 252);
            listBox_ViewFibonachi.Name = "listBox_ViewFibonachi";
            listBox_ViewFibonachi.Size = new Size(265, 256);
            listBox_ViewFibonachi.TabIndex = 10;
            // 
            // label_FibonachiInfo
            // 
            label_FibonachiInfo.AutoSize = true;
            label_FibonachiInfo.Location = new Point(314, 218);
            label_FibonachiInfo.Name = "label_FibonachiInfo";
            label_FibonachiInfo.Size = new Size(175, 15);
            label_FibonachiInfo.TabIndex = 11;
            label_FibonachiInfo.Text = "Количество активных потоков";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 236);
            label3.Name = "label3";
            label3.Size = new Size(265, 15);
            label3.TabIndex = 12;
            label3.Text = "Результат работы генератора чисел Фибоначи\r\n";
            // 
            // label_CountThreadsFibonacy
            // 
            label_CountThreadsFibonacy.AutoSize = true;
            label_CountThreadsFibonacy.ForeColor = Color.Red;
            label_CountThreadsFibonacy.Location = new Point(495, 218);
            label_CountThreadsFibonacy.Name = "label_CountThreadsFibonacy";
            label_CountThreadsFibonacy.Size = new Size(13, 15);
            label_CountThreadsFibonacy.TabIndex = 13;
            label_CountThreadsFibonacy.Text = "0";
            // 
            // button_GenerateFib
            // 
            button_GenerateFib.BackColor = Color.LightGray;
            button_GenerateFib.Location = new Point(314, 71);
            button_GenerateFib.Name = "button_GenerateFib";
            button_GenerateFib.Size = new Size(265, 30);
            button_GenerateFib.TabIndex = 14;
            button_GenerateFib.Text = "Сгенерировать числа Фибоначи";
            button_GenerateFib.UseVisualStyleBackColor = false;
            button_GenerateFib.Click += button_GenerateFib_Click;
            // 
            // button_StopThreadsFibonacy
            // 
            button_StopThreadsFibonacy.Location = new Point(315, 107);
            button_StopThreadsFibonacy.Name = "button_StopThreadsFibonacy";
            button_StopThreadsFibonacy.Size = new Size(264, 22);
            button_StopThreadsFibonacy.TabIndex = 15;
            button_StopThreadsFibonacy.Text = "Остановить потоки";
            button_StopThreadsFibonacy.UseVisualStyleBackColor = true;
            button_StopThreadsFibonacy.Click += button_StopThreadsFibonacy_Click;
            // 
            // button_PauseThreadsSimpleInt
            // 
            button_PauseThreadsSimpleInt.Location = new Point(9, 135);
            button_PauseThreadsSimpleInt.Name = "button_PauseThreadsSimpleInt";
            button_PauseThreadsSimpleInt.Size = new Size(193, 22);
            button_PauseThreadsSimpleInt.TabIndex = 16;
            button_PauseThreadsSimpleInt.Text = "Приостановить потоки";
            button_PauseThreadsSimpleInt.UseVisualStyleBackColor = true;
            button_PauseThreadsSimpleInt.Click += button_PauseThreadsSimpleInt_Click;
            // 
            // button_ResumeThreadsSimplInt
            // 
            button_ResumeThreadsSimplInt.Location = new Point(9, 163);
            button_ResumeThreadsSimplInt.Name = "button_ResumeThreadsSimplInt";
            button_ResumeThreadsSimplInt.Size = new Size(193, 22);
            button_ResumeThreadsSimplInt.TabIndex = 17;
            button_ResumeThreadsSimplInt.Text = "Востановить потоки";
            button_ResumeThreadsSimplInt.UseVisualStyleBackColor = true;
            button_ResumeThreadsSimplInt.Click += button_ResumeThreadsSimplInt_Click;
            // 
            // button_RestartSimplyInt
            // 
            button_RestartSimplyInt.Location = new Point(9, 191);
            button_RestartSimplyInt.Name = "button_RestartSimplyInt";
            button_RestartSimplyInt.Size = new Size(193, 22);
            button_RestartSimplyInt.TabIndex = 18;
            button_RestartSimplyInt.Text = "Рестарт";
            button_RestartSimplyInt.UseVisualStyleBackColor = true;
            button_RestartSimplyInt.Click += button_RestartSimplyInt_Click;
            // 
            // button_PauseFibThread
            // 
            button_PauseFibThread.Location = new Point(314, 135);
            button_PauseFibThread.Name = "button_PauseFibThread";
            button_PauseFibThread.Size = new Size(265, 22);
            button_PauseFibThread.TabIndex = 19;
            button_PauseFibThread.Text = "Приостановить потоки";
            button_PauseFibThread.UseVisualStyleBackColor = true;
            button_PauseFibThread.Click += button_PauseFibThread_Click;
            // 
            // button_resumeFibThreads
            // 
            button_resumeFibThreads.Location = new Point(314, 163);
            button_resumeFibThreads.Name = "button_resumeFibThreads";
            button_resumeFibThreads.Size = new Size(265, 22);
            button_resumeFibThreads.TabIndex = 20;
            button_resumeFibThreads.Text = "Востановить потоки";
            button_resumeFibThreads.UseVisualStyleBackColor = true;
            button_resumeFibThreads.Click += button_resumeFibThreads_Click;
            // 
            // button_RestartThreads
            // 
            button_RestartThreads.Location = new Point(314, 191);
            button_RestartThreads.Name = "button_RestartThreads";
            button_RestartThreads.Size = new Size(265, 22);
            button_RestartThreads.TabIndex = 21;
            button_RestartThreads.Text = "Рестарт";
            button_RestartThreads.UseVisualStyleBackColor = true;
            button_RestartThreads.Click += button_RestartThreads_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 520);
            Controls.Add(button_RestartThreads);
            Controls.Add(button_resumeFibThreads);
            Controls.Add(button_PauseFibThread);
            Controls.Add(button_RestartSimplyInt);
            Controls.Add(button_ResumeThreadsSimplInt);
            Controls.Add(button_PauseThreadsSimpleInt);
            Controls.Add(button_StopThreadsFibonacy);
            Controls.Add(button_GenerateFib);
            Controls.Add(label_CountThreadsFibonacy);
            Controls.Add(label3);
            Controls.Add(label_FibonachiInfo);
            Controls.Add(listBox_ViewFibonachi);
            Controls.Add(button_RestartTreadsSimplyInt);
            Controls.Add(textBox_MaxValue);
            Controls.Add(label_howManyThreads);
            Controls.Add(label2);
            Controls.Add(label_description);
            Controls.Add(label_textInfo);
            Controls.Add(listBox_ViewResult);
            Controls.Add(label1);
            Controls.Add(textBox_MinValue);
            Controls.Add(button_GenereteSimlyInt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "Многопоточность и асинхронность";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_GenereteSimlyInt;
        private TextBox textBox_MinValue;
        private Label label1;
        private Label label2;
        private TextBox textBox_MaxValue;
        private ListBox listBox_ViewResult;
        private Button button_RestartTreadsSimplyInt;
        private Label label_textInfo;
        private Label label_description;
        private Label label_howManyThreads;
        private ListBox listBox_ViewFibonachi;
        private Label label_FibonachiInfo;
        private Label label3;
        private Label label_CountThreadsFibonacy;
        private Button button_GenerateFib;
        private Button button_StopThreadsFibonacy;
        private Button button_PauseThreadsSimpleInt;
        private Button button_ResumeThreadsSimplInt;
        private Button button_RestartSimplyInt;
        private Button button_PauseFibThread;
        private Button button_resumeFibThreads;
        private Button button_RestartThreads;
    }
}