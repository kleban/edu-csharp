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
            panel = new Panel();
            button2 = new Button();
            button1 = new Button();
            buttonShowHidePanel = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            panel.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxLocalities
            // 
            listBoxLocalities.FormattingEnabled = true;
            listBoxLocalities.Location = new Point(12, 12);
            listBoxLocalities.Name = "listBoxLocalities";
            listBoxLocalities.Size = new Size(280, 424);
            listBoxLocalities.TabIndex = 0;
            listBoxLocalities.SelectedIndexChanged += listBoxLocalities_SelectedIndexChanged;
            // 
            // labelLocality
            // 
            labelLocality.AutoSize = true;
            labelLocality.Location = new Point(315, 66);
            labelLocality.Name = "labelLocality";
            labelLocality.Size = new Size(50, 20);
            labelLocality.TabIndex = 1;
            labelLocality.Text = "label1";
            // 
            // comboBoxLocalities
            // 
            comboBoxLocalities.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLocalities.FormattingEnabled = true;
            comboBoxLocalities.Location = new Point(315, 12);
            comboBoxLocalities.Name = "comboBoxLocalities";
            comboBoxLocalities.Size = new Size(178, 28);
            comboBoxLocalities.TabIndex = 2;
            comboBoxLocalities.SelectedIndexChanged += listBoxLocalities_SelectedIndexChanged;
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ActiveCaption;
            panel.Controls.Add(button2);
            panel.Controls.Add(button1);
            panel.Location = new Point(315, 156);
            panel.Name = "panel";
            panel.Size = new Size(250, 125);
            panel.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(98, 72);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(43, 25);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonShowHidePanel
            // 
            buttonShowHidePanel.Location = new Point(315, 112);
            buttonShowHidePanel.Name = "buttonShowHidePanel";
            buttonShowHidePanel.Size = new Size(94, 29);
            buttonShowHidePanel.TabIndex = 4;
            buttonShowHidePanel.Text = "Hide Panel";
            buttonShowHidePanel.UseVisualStyleBackColor = true;
            buttonShowHidePanel.Click += buttonShowHidePanel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(538, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            button3.Location = new Point(78, 48);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(47, 83);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // ListsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(buttonShowHidePanel);
            Controls.Add(panel);
            Controls.Add(comboBoxLocalities);
            Controls.Add(labelLocality);
            Controls.Add(listBoxLocalities);
            Name = "ListsForm";
            Text = "ListsForm";
            Load += ListsForm_Load;
            panel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxLocalities;
        private Label labelLocality;
        private ComboBox comboBoxLocalities;
        private Panel panel;
        private Button button2;
        private Button button1;
        private Button buttonShowHidePanel;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
    }
}