namespace ForbesRankUI
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
            tabControl1 = new TabControl();
            tabPagePersons = new TabPage();
            buttonSave = new Button();
            comboBoxCategory = new ComboBox();
            comboBoxCountry = new ComboBox();
            textBoxName = new TextBox();
            numericUpDownAge = new NumericUpDown();
            numericUpDownWorth = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonDeletePerson = new Button();
            listBoxPersons = new ListBox();
            tabPageCountries = new TabPage();
            tabPageCategories = new TabPage();
            listBoxCategories = new ListBox();
            buttonReRank = new Button();
            tabControl1.SuspendLayout();
            tabPagePersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWorth).BeginInit();
            tabPageCategories.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePersons);
            tabControl1.Controls.Add(tabPageCountries);
            tabControl1.Controls.Add(tabPageCategories);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(760, 345);
            tabControl1.TabIndex = 0;
            // 
            // tabPagePersons
            // 
            tabPagePersons.Controls.Add(buttonReRank);
            tabPagePersons.Controls.Add(buttonSave);
            tabPagePersons.Controls.Add(comboBoxCategory);
            tabPagePersons.Controls.Add(comboBoxCountry);
            tabPagePersons.Controls.Add(textBoxName);
            tabPagePersons.Controls.Add(numericUpDownAge);
            tabPagePersons.Controls.Add(numericUpDownWorth);
            tabPagePersons.Controls.Add(label5);
            tabPagePersons.Controls.Add(label4);
            tabPagePersons.Controls.Add(label3);
            tabPagePersons.Controls.Add(label2);
            tabPagePersons.Controls.Add(label1);
            tabPagePersons.Controls.Add(buttonDeletePerson);
            tabPagePersons.Controls.Add(listBoxPersons);
            tabPagePersons.Location = new Point(4, 29);
            tabPagePersons.Name = "tabPagePersons";
            tabPagePersons.Padding = new Padding(3);
            tabPagePersons.Size = new Size(752, 312);
            tabPagePersons.TabIndex = 0;
            tabPagePersons.Text = "Persons";
            tabPagePersons.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(520, 163);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(151, 29);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(520, 99);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 28);
            comboBoxCategory.TabIndex = 11;
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(520, 40);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(151, 28);
            comboBoxCountry.TabIndex = 10;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(324, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 27);
            textBoxName.TabIndex = 9;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(324, 103);
            numericUpDownAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(150, 27);
            numericUpDownAge.TabIndex = 8;
            // 
            // numericUpDownWorth
            // 
            numericUpDownWorth.Location = new Point(324, 163);
            numericUpDownWorth.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownWorth.Name = "numericUpDownWorth";
            numericUpDownWorth.Size = new Size(150, 27);
            numericUpDownWorth.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(520, 76);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 6;
            label5.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 17);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 140);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 4;
            label3.Text = "Net worth, $1000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 80);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 3;
            label2.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 17);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // buttonDeletePerson
            // 
            buttonDeletePerson.Location = new Point(324, 275);
            buttonDeletePerson.Name = "buttonDeletePerson";
            buttonDeletePerson.Size = new Size(94, 29);
            buttonDeletePerson.TabIndex = 1;
            buttonDeletePerson.Text = "Delete";
            buttonDeletePerson.UseVisualStyleBackColor = true;
            buttonDeletePerson.Click += buttonDeletePerson_Click;
            // 
            // listBoxPersons
            // 
            listBoxPersons.Dock = DockStyle.Left;
            listBoxPersons.FormattingEnabled = true;
            listBoxPersons.Location = new Point(3, 3);
            listBoxPersons.Name = "listBoxPersons";
            listBoxPersons.Size = new Size(304, 306);
            listBoxPersons.TabIndex = 0;
            // 
            // tabPageCountries
            // 
            tabPageCountries.Location = new Point(4, 29);
            tabPageCountries.Name = "tabPageCountries";
            tabPageCountries.Padding = new Padding(3);
            tabPageCountries.Size = new Size(752, 312);
            tabPageCountries.TabIndex = 1;
            tabPageCountries.Text = "Countries";
            tabPageCountries.UseVisualStyleBackColor = true;
            // 
            // tabPageCategories
            // 
            tabPageCategories.Controls.Add(listBoxCategories);
            tabPageCategories.Location = new Point(4, 29);
            tabPageCategories.Name = "tabPageCategories";
            tabPageCategories.Padding = new Padding(3);
            tabPageCategories.Size = new Size(752, 312);
            tabPageCategories.TabIndex = 2;
            tabPageCategories.Text = "Categories";
            tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // listBoxCategories
            // 
            listBoxCategories.Dock = DockStyle.Left;
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.Location = new Point(3, 3);
            listBoxCategories.Name = "listBoxCategories";
            listBoxCategories.Size = new Size(288, 306);
            listBoxCategories.TabIndex = 0;
            // 
            // buttonReRank
            // 
            buttonReRank.Location = new Point(323, 240);
            buttonReRank.Name = "buttonReRank";
            buttonReRank.Size = new Size(95, 29);
            buttonReRank.TabIndex = 13;
            buttonReRank.Text = "ReRank";
            buttonReRank.UseVisualStyleBackColor = true;
            buttonReRank.Click += buttonReRank_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 345);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPagePersons.ResumeLayout(false);
            tabPagePersons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWorth).EndInit();
            tabPageCategories.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPagePersons;
        private TabPage tabPageCountries;
        private TabPage tabPageCategories;
        private ListBox listBoxCategories;
        private ListBox listBoxPersons;
        private Button buttonDeletePerson;
        private ComboBox comboBoxCountry;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownAge;
        private NumericUpDown numericUpDownWorth;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonSave;
        private ComboBox comboBoxCategory;
        private Button buttonReRank;
    }
}
