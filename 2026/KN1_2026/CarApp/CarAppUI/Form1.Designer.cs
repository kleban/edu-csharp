namespace CarAppUI
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            вийтиToolStripMenuItem = new ToolStripMenuItem();
            listBoxCars = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxModel = new TextBox();
            textBoxMark = new TextBox();
            buttonSave = new Button();
            textBoxYear = new MaskedTextBox();
            dateTimePickerRegDate = new DateTimePicker();
            numericUpDownPrice = new NumericUpDown();
            buttonClean = new Button();
            statusStrip1 = new StatusStrip();
            labelIFlePath = new ToolStripStatusLabel();
            labelEditedStatus = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { відкритиToolStripMenuItem, зберегтиToolStripMenuItem, зберегтиЯкToolStripMenuItem, toolStripSeparator1, вийтиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.Size = new Size(224, 26);
            відкритиToolStripMenuItem.Text = "Відкрити";
            відкритиToolStripMenuItem.Click += відкритиToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(224, 26);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            зберегтиЯкToolStripMenuItem.Size = new Size(224, 26);
            зберегтиЯкToolStripMenuItem.Text = "Зберегти як...";
            зберегтиЯкToolStripMenuItem.Click += зберегтиЯкToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // вийтиToolStripMenuItem
            // 
            вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            вийтиToolStripMenuItem.Size = new Size(224, 26);
            вийтиToolStripMenuItem.Text = "Вийти";
            // 
            // listBoxCars
            // 
            listBoxCars.FormattingEnabled = true;
            listBoxCars.Location = new Point(0, 28);
            listBoxCars.Name = "listBoxCars";
            listBoxCars.Size = new Size(237, 384);
            listBoxCars.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 42);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 104);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Марка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 164);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 4;
            label3.Text = "Рік";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 221);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 5;
            label4.Text = "Дата реєстрації";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(263, 278);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 6;
            label5.Text = "Ціна, $";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(263, 74);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(250, 27);
            textBoxModel.TabIndex = 7;
            // 
            // textBoxMark
            // 
            textBoxMark.Location = new Point(263, 134);
            textBoxMark.Name = "textBoxMark";
            textBoxMark.Size = new Size(250, 27);
            textBoxMark.TabIndex = 8;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(383, 351);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(130, 29);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(263, 191);
            textBoxYear.Mask = "0000";
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(250, 27);
            textBoxYear.TabIndex = 14;
            textBoxYear.ValidatingType = typeof(int);
            // 
            // dateTimePickerRegDate
            // 
            dateTimePickerRegDate.Location = new Point(263, 248);
            dateTimePickerRegDate.Name = "dateTimePickerRegDate";
            dateTimePickerRegDate.Size = new Size(250, 27);
            dateTimePickerRegDate.TabIndex = 15;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(263, 301);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(250, 27);
            numericUpDownPrice.TabIndex = 16;
            // 
            // buttonClean
            // 
            buttonClean.Location = new Point(263, 351);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(116, 29);
            buttonClean.TabIndex = 17;
            buttonClean.Text = "Clean";
            buttonClean.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelIFlePath, labelEditedStatus });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 18;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelIFlePath
            // 
            labelIFlePath.Name = "labelIFlePath";
            labelIFlePath.Size = new Size(0, 20);
            // 
            // labelEditedStatus
            // 
            labelEditedStatus.Name = "labelEditedStatus";
            labelEditedStatus.Size = new Size(138, 20);
            labelEditedStatus.Text = "Статус: Збережено";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(buttonClean);
            Controls.Add(numericUpDownPrice);
            Controls.Add(dateTimePickerRegDate);
            Controls.Add(textBoxYear);
            Controls.Add(buttonSave);
            Controls.Add(textBoxMark);
            Controls.Add(textBoxModel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxCars);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem вийтиToolStripMenuItem;
        private ListBox listBoxCars;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxModel;
        private TextBox textBoxMark;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDownPrice;
        private Button buttonClean;
        private Button buttonSave;
        private MaskedTextBox textBoxYear;
        private DateTimePicker dateTimePickerRegDate;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelIFlePath;
        private ToolStripStatusLabel labelEditedStatus;
    }
}
