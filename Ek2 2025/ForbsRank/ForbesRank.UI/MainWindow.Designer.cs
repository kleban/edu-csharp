namespace ForbesRank.UI
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
            tabControl = new TabControl();
            tabPagePersons = new TabPage();
            listBoxPersons = new ListBox();
            tabPageCountries = new TabPage();
            listBoxCountries = new ListBox();
            tabPageCategories = new TabPage();
            listBoxCategories = new ListBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            textBoxPersonName = new TextBox();
            numericUpDownPersonAge = new NumericUpDown();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxCountry = new ComboBox();
            comboBoxCategory = new ComboBox();
            buttonPersonClean = new Button();
            buttonAddUpdate = new Button();
            tabControl.SuspendLayout();
            tabPagePersons.SuspendLayout();
            tabPageCountries.SuspendLayout();
            tabPageCategories.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPersonAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPagePersons);
            tabControl.Controls.Add(tabPageCountries);
            tabControl.Controls.Add(tabPageCategories);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            // 
            // tabPagePersons
            // 
            tabPagePersons.Controls.Add(groupBox1);
            tabPagePersons.Controls.Add(listBoxPersons);
            tabPagePersons.Location = new Point(4, 29);
            tabPagePersons.Name = "tabPagePersons";
            tabPagePersons.Padding = new Padding(3);
            tabPagePersons.Size = new Size(792, 417);
            tabPagePersons.TabIndex = 0;
            tabPagePersons.Text = "Persons";
            tabPagePersons.UseVisualStyleBackColor = true;
            // 
            // listBoxPersons
            // 
            listBoxPersons.Dock = DockStyle.Left;
            listBoxPersons.FormattingEnabled = true;
            listBoxPersons.Location = new Point(3, 3);
            listBoxPersons.Name = "listBoxPersons";
            listBoxPersons.Size = new Size(270, 411);
            listBoxPersons.TabIndex = 0;
            // 
            // tabPageCountries
            // 
            tabPageCountries.Controls.Add(listBoxCountries);
            tabPageCountries.Location = new Point(4, 29);
            tabPageCountries.Name = "tabPageCountries";
            tabPageCountries.Padding = new Padding(3);
            tabPageCountries.Size = new Size(792, 417);
            tabPageCountries.TabIndex = 1;
            tabPageCountries.Text = "Countries";
            tabPageCountries.UseVisualStyleBackColor = true;
            // 
            // listBoxCountries
            // 
            listBoxCountries.Dock = DockStyle.Left;
            listBoxCountries.FormattingEnabled = true;
            listBoxCountries.Location = new Point(3, 3);
            listBoxCountries.Name = "listBoxCountries";
            listBoxCountries.Size = new Size(270, 411);
            listBoxCountries.TabIndex = 1;
            // 
            // tabPageCategories
            // 
            tabPageCategories.Controls.Add(listBoxCategories);
            tabPageCategories.Location = new Point(4, 29);
            tabPageCategories.Name = "tabPageCategories";
            tabPageCategories.Padding = new Padding(3);
            tabPageCategories.Size = new Size(792, 417);
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
            listBoxCategories.Size = new Size(270, 411);
            listBoxCategories.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAddUpdate);
            groupBox1.Controls.Add(buttonPersonClean);
            groupBox1.Controls.Add(comboBoxCategory);
            groupBox1.Controls.Add(comboBoxCountry);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDownPersonAge);
            groupBox1.Controls.Add(textBoxPersonName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(290, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 388);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = " Add / Edit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 98);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // textBoxPersonName
            // 
            textBoxPersonName.Location = new Point(21, 63);
            textBoxPersonName.Name = "textBoxPersonName";
            textBoxPersonName.Size = new Size(188, 27);
            textBoxPersonName.TabIndex = 2;
            // 
            // numericUpDownPersonAge
            // 
            numericUpDownPersonAge.Location = new Point(21, 125);
            numericUpDownPersonAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numericUpDownPersonAge.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            numericUpDownPersonAge.Name = "numericUpDownPersonAge";
            numericUpDownPersonAge.Size = new Size(188, 27);
            numericUpDownPersonAge.TabIndex = 3;
            numericUpDownPersonAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 164);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Final Worth";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(21, 190);
            numericUpDown1.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(188, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 223);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 6;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(193, 23);
            label5.Name = "label5";
            label5.Size = new Size(42, 28);
            label5.TabIndex = 7;
            label5.Text = "# 0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 280);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 8;
            label6.Text = "Category";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(21, 245);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(188, 28);
            comboBoxCountry.TabIndex = 9;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(21, 305);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(188, 28);
            comboBoxCategory.TabIndex = 10;
            // 
            // buttonPersonClean
            // 
            buttonPersonClean.Location = new Point(21, 348);
            buttonPersonClean.Name = "buttonPersonClean";
            buttonPersonClean.Size = new Size(94, 29);
            buttonPersonClean.TabIndex = 11;
            buttonPersonClean.Text = "Clean";
            buttonPersonClean.UseVisualStyleBackColor = true;
            // 
            // buttonAddUpdate
            // 
            buttonAddUpdate.Location = new Point(121, 348);
            buttonAddUpdate.Name = "buttonAddUpdate";
            buttonAddUpdate.Size = new Size(88, 29);
            buttonAddUpdate.TabIndex = 12;
            buttonAddUpdate.Text = "Add";
            buttonAddUpdate.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "MainWindow";
            Text = "Forbes Rank";
            Load += MainWindow_Load;
            tabControl.ResumeLayout(false);
            tabPagePersons.ResumeLayout(false);
            tabPageCountries.ResumeLayout(false);
            tabPageCategories.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPersonAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPagePersons;
        private TabPage tabPageCountries;
        private TabPage tabPageCategories;
        private ListBox listBoxPersons;
        private ListBox listBoxCountries;
        private ListBox listBoxCategories;
        private GroupBox groupBox1;
        private TextBox textBoxPersonName;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownPersonAge;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button buttonPersonClean;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxCountry;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button buttonAddUpdate;
    }
}
