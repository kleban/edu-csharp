namespace FormsDemo
{
    partial class MainForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            buttonStartTimer = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(29, 22);
            button1.Name = "button1";
            button1.Size = new Size(201, 98);
            button1.TabIndex = 0;
            button1.Text = "Створити форму";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(236, 22);
            button2.Name = "button2";
            button2.Size = new Size(201, 98);
            button2.TabIndex = 1;
            button2.Text = "Створити 10 форм";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(29, 126);
            button3.Name = "button3";
            button3.Size = new Size(201, 98);
            button3.TabIndex = 2;
            button3.Text = "Зміни фони";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F);
            button4.Location = new Point(236, 126);
            button4.Name = "button4";
            button4.Size = new Size(201, 98);
            button4.TabIndex = 3;
            button4.Text = "Зміни позиції";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonStartTimer
            // 
            buttonStartTimer.Font = new Font("Segoe UI", 15F);
            buttonStartTimer.Location = new Point(400, 274);
            buttonStartTimer.Name = "buttonStartTimer";
            buttonStartTimer.Size = new Size(201, 98);
            buttonStartTimer.TabIndex = 4;
            buttonStartTimer.Text = "Запустити таймер";
            buttonStartTimer.UseVisualStyleBackColor = true;
            buttonStartTimer.Click += buttonStartTimer_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(632, 410);
            Controls.Add(buttonStartTimer);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            TransparencyKey = Color.White;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button buttonStartTimer;
    }
}
