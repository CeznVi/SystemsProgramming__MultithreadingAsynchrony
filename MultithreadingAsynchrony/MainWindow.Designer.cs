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
            button_RestartTreads = new Button();
            SuspendLayout();
            // 
            // button_GenereteSimlyInt
            // 
            button_GenereteSimlyInt.BackColor = Color.LightGray;
            button_GenereteSimlyInt.Location = new Point(168, 85);
            button_GenereteSimlyInt.Name = "button_GenereteSimlyInt";
            button_GenereteSimlyInt.Size = new Size(190, 30);
            button_GenereteSimlyInt.TabIndex = 0;
            button_GenereteSimlyInt.Text = "Сгенерировать простые числа";
            button_GenereteSimlyInt.UseVisualStyleBackColor = false;
            button_GenereteSimlyInt.Click += button_GenereteSimlyInt_Click;
            // 
            // textBox_MinValue
            // 
            textBox_MinValue.Location = new Point(222, 6);
            textBox_MinValue.Name = "textBox_MinValue";
            textBox_MinValue.Size = new Size(85, 23);
            textBox_MinValue.TabIndex = 1;
            textBox_MinValue.KeyPress += textBox_MinValue_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 2;
            label1.Text = "Начать генерацию с числа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(259, 21);
            label2.TabIndex = 3;
            label2.Text = "Верхняя граница числа генерации:";
            // 
            // textBox_MaxValue
            // 
            textBox_MaxValue.Location = new Point(277, 35);
            textBox_MaxValue.Name = "textBox_MaxValue";
            textBox_MaxValue.Size = new Size(81, 23);
            textBox_MaxValue.TabIndex = 4;
            textBox_MaxValue.KeyPress += textBox_MinValue_KeyPress;
            // 
            // listBox_ViewResult
            // 
            listBox_ViewResult.Dock = DockStyle.Bottom;
            listBox_ViewResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_ViewResult.FormattingEnabled = true;
            listBox_ViewResult.ItemHeight = 21;
            listBox_ViewResult.Location = new Point(0, 257);
            listBox_ViewResult.Name = "listBox_ViewResult";
            listBox_ViewResult.Size = new Size(800, 193);
            listBox_ViewResult.TabIndex = 5;
            // 
            // button_RestartTreads
            // 
            button_RestartTreads.Location = new Point(517, 169);
            button_RestartTreads.Name = "button_RestartTreads";
            button_RestartTreads.Size = new Size(261, 23);
            button_RestartTreads.TabIndex = 6;
            button_RestartTreads.Text = "Перазапустить потоки";
            button_RestartTreads.UseVisualStyleBackColor = true;
            button_RestartTreads.Click += button_RestartTreads_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_RestartTreads);
            Controls.Add(listBox_ViewResult);
            Controls.Add(textBox_MaxValue);
            Controls.Add(label2);
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
        private Button button_RestartTreads;
    }
}