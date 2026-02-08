namespace FrbsApp.UI
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonAdd = new Button();
            dateTimePickerDoB = new DateTimePicker();
            numericUpDownWorth = new NumericUpDown();
            comboBoxCategory = new ComboBox();
            comboBoxCity = new ComboBox();
            comboBoxCountry = new ComboBox();
            textBoxName = new TextBox();
            numericUpDownRank = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonRemovePerson = new Button();
            listBoxPeople = new ListBox();
            tabPage2 = new TabPage();
            listBoxCountries = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWorth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRank).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 549);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonAdd);
            tabPage1.Controls.Add(dateTimePickerDoB);
            tabPage1.Controls.Add(numericUpDownWorth);
            tabPage1.Controls.Add(comboBoxCategory);
            tabPage1.Controls.Add(comboBoxCity);
            tabPage1.Controls.Add(comboBoxCountry);
            tabPage1.Controls.Add(textBoxName);
            tabPage1.Controls.Add(numericUpDownRank);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(buttonRemovePerson);
            tabPage1.Controls.Add(listBoxPeople);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 516);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(436, 358);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(164, 29);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDoB
            // 
            dateTimePickerDoB.Location = new Point(536, 270);
            dateTimePickerDoB.Name = "dateTimePickerDoB";
            dateTimePickerDoB.Size = new Size(150, 27);
            dateTimePickerDoB.TabIndex = 15;
            // 
            // numericUpDownWorth
            // 
            numericUpDownWorth.Location = new Point(535, 128);
            numericUpDownWorth.Name = "numericUpDownWorth";
            numericUpDownWorth.Size = new Size(150, 27);
            numericUpDownWorth.TabIndex = 14;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(535, 309);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 28);
            comboBoxCategory.TabIndex = 13;
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(535, 228);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(151, 28);
            comboBoxCity.TabIndex = 12;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(534, 179);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(151, 28);
            comboBoxCountry.TabIndex = 11;
            comboBoxCountry.SelectedIndexChanged += comboBoxCountry_SelectedIndexChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(535, 74);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 27);
            textBoxName.TabIndex = 10;
            // 
            // numericUpDownRank
            // 
            numericUpDownRank.Location = new Point(535, 22);
            numericUpDownRank.Name = "numericUpDownRank";
            numericUpDownRank.Size = new Size(150, 27);
            numericUpDownRank.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(440, 312);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 8;
            label7.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(436, 270);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 7;
            label6.Text = "Date of birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 228);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 6;
            label5.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 179);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(436, 130);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Worth, $";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(436, 74);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(436, 24);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 2;
            label1.Text = "Rank";
            // 
            // buttonRemovePerson
            // 
            buttonRemovePerson.Location = new Point(436, 479);
            buttonRemovePerson.Name = "buttonRemovePerson";
            buttonRemovePerson.Size = new Size(164, 29);
            buttonRemovePerson.TabIndex = 1;
            buttonRemovePerson.Text = "Remove";
            buttonRemovePerson.UseVisualStyleBackColor = true;
            buttonRemovePerson.Click += buttonRemovePerson_Click;
            // 
            // listBoxPeople
            // 
            listBoxPeople.Dock = DockStyle.Left;
            listBoxPeople.FormattingEnabled = true;
            listBoxPeople.Location = new Point(3, 3);
            listBoxPeople.Name = "listBoxPeople";
            listBoxPeople.Size = new Size(410, 510);
            listBoxPeople.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBoxCountries);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 516);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Countries";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxCountries
            // 
            listBoxCountries.Dock = DockStyle.Left;
            listBoxCountries.Font = new Font("Segoe UI", 12F);
            listBoxCountries.FormattingEnabled = true;
            listBoxCountries.Location = new Point(3, 3);
            listBoxCountries.Name = "listBoxCountries";
            listBoxCountries.Size = new Size(270, 510);
            listBoxCountries.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(tabControl1);
            Name = "MainWindow";
            Text = "Frbs Rank App";
            Load += MainWindow_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWorth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRank).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBoxCountries;
        private ListBox listBoxPeople;
        private Button buttonRemovePerson;
        private Button buttonAdd;
        private DateTimePicker dateTimePickerDoB;
        private NumericUpDown numericUpDownWorth;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxCity;
        private ComboBox comboBoxCountry;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownRank;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
