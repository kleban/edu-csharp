namespace FormsDemoApp
{
    partial class ListsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxLocalities = new ListBox();
            labelLocality = new Label();
            comboBoxLocalities = new ComboBox();
            panel1 = new Panel();
            buttonDeleteItem = new Button();
            buttonShowBlock = new Button();
            groupBoxNewLocality = new GroupBox();
            buttonSaveLocality = new Button();
            textBoxLocalityName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBoxNewLocality.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxLocalities
            // 
            listBoxLocalities.Dock = DockStyle.Fill;
            listBoxLocalities.FormattingEnabled = true;
            listBoxLocalities.ItemHeight = 15;
            listBoxLocalities.Location = new Point(0, 0);
            listBoxLocalities.Margin = new Padding(3, 2, 3, 2);
            listBoxLocalities.Name = "listBoxLocalities";
            listBoxLocalities.Size = new Size(242, 508);
            listBoxLocalities.TabIndex = 0;
            listBoxLocalities.SelectedIndexChanged += listBoxLocalities_SelectedIndexChanged;
            // 
            // labelLocality
            // 
            labelLocality.AutoSize = true;
            labelLocality.Location = new Point(276, 50);
            labelLocality.Name = "labelLocality";
            labelLocality.Size = new Size(38, 15);
            labelLocality.TabIndex = 1;
            labelLocality.Text = "label1";
            // 
            // comboBoxLocalities
            // 
            comboBoxLocalities.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLocalities.FormattingEnabled = true;
            comboBoxLocalities.Location = new Point(276, 9);
            comboBoxLocalities.Margin = new Padding(3, 2, 3, 2);
            comboBoxLocalities.Name = "comboBoxLocalities";
            comboBoxLocalities.Size = new Size(156, 23);
            comboBoxLocalities.TabIndex = 2;
            comboBoxLocalities.SelectedIndexChanged += listBoxLocalities_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(buttonDeleteItem);
            panel1.Controls.Add(listBoxLocalities);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 508);
            panel1.TabIndex = 3;
            // 
            // buttonDeleteItem
            // 
            buttonDeleteItem.Dock = DockStyle.Bottom;
            buttonDeleteItem.Enabled = false;
            buttonDeleteItem.Location = new Point(0, 485);
            buttonDeleteItem.Name = "buttonDeleteItem";
            buttonDeleteItem.Size = new Size(242, 23);
            buttonDeleteItem.TabIndex = 0;
            buttonDeleteItem.Text = "Видалити";
            buttonDeleteItem.UseVisualStyleBackColor = true;
            buttonDeleteItem.Click += buttonDeleteItem_Click;
            // 
            // buttonShowBlock
            // 
            buttonShowBlock.Location = new Point(276, 78);
            buttonShowBlock.Name = "buttonShowBlock";
            buttonShowBlock.Size = new Size(200, 23);
            buttonShowBlock.TabIndex = 4;
            buttonShowBlock.Text = "Я хочу додати населений пункт";
            buttonShowBlock.UseVisualStyleBackColor = true;
            buttonShowBlock.Click += buttonShowBlock_Click;
            // 
            // groupBoxNewLocality
            // 
            groupBoxNewLocality.Controls.Add(buttonSaveLocality);
            groupBoxNewLocality.Controls.Add(textBoxLocalityName);
            groupBoxNewLocality.Controls.Add(label1);
            groupBoxNewLocality.Location = new Point(276, 114);
            groupBoxNewLocality.Name = "groupBoxNewLocality";
            groupBoxNewLocality.Size = new Size(200, 121);
            groupBoxNewLocality.TabIndex = 5;
            groupBoxNewLocality.TabStop = false;
            groupBoxNewLocality.Text = "Новий населений пункт";
            groupBoxNewLocality.Visible = false;
            // 
            // buttonSaveLocality
            // 
            buttonSaveLocality.Location = new Point(13, 80);
            buttonSaveLocality.Name = "buttonSaveLocality";
            buttonSaveLocality.Size = new Size(75, 23);
            buttonSaveLocality.TabIndex = 2;
            buttonSaveLocality.Text = "Зберегти";
            buttonSaveLocality.UseVisualStyleBackColor = true;
            buttonSaveLocality.Click += buttonSaveLocality_Click;
            // 
            // textBoxLocalityName
            // 
            textBoxLocalityName.Location = new Point(13, 47);
            textBoxLocalityName.Name = "textBoxLocalityName";
            textBoxLocalityName.Size = new Size(155, 23);
            textBoxLocalityName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Назва";
            // 
            // ListsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 508);
            Controls.Add(groupBoxNewLocality);
            Controls.Add(buttonShowBlock);
            Controls.Add(panel1);
            Controls.Add(comboBoxLocalities);
            Controls.Add(labelLocality);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListsForm";
            Text = "ListsForm";
            Load += ListsForm_Load;
            panel1.ResumeLayout(false);
            groupBoxNewLocality.ResumeLayout(false);
            groupBoxNewLocality.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxLocalities;
        private Label labelLocality;
        private ComboBox comboBoxLocalities;
        private Panel panel1;
        private Button buttonDeleteItem;
        private Button buttonShowBlock;
        private GroupBox groupBoxNewLocality;
        private Button buttonSaveLocality;
        private TextBox textBoxLocalityName;
        private Label label1;
    }
}